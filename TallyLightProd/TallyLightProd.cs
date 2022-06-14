using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Types;
using System.Net.Http;
using TallyLightShared.Models;

namespace TallyLightProd
{
    public partial class TallyLightProd : Form
    {

        public string Server { get; set; } = string.Empty;

        public string ProdName { get; set; } = string.Empty;

        protected OBSWebsocket obs;

        private HttpClient httpClient = new HttpClient();
        private int lastTallyLightCamNumber = 1;
        bool sendUpdates;

        public TallyLightProd()
        {
            obs = new OBSWebsocket();
            InitializeComponent();
        }

        private void TallyLightAddBtn_Click(object sender, EventArgs e)
        {
            TallyLightCam toAdd = new TallyLightCam($"New Camera {lastTallyLightCamNumber++}", "");
            tallyLightCamBindingSource.Add(toAdd);
            TallyLightCamListBox.SelectedIndex = tallyLightCamBindingSource.Count - 1;

            SendUpdate();

            LoadCamInfo(toAdd);

            TallyLightCamListBox.Invalidate();
        }

        private void TallyLightRemoveBtn_Click(object sender, EventArgs e)
        {
            tallyLightCamBindingSource.Remove(TallyLightCamListBox.SelectedItem);

            TallyLightCam? selectedCam = TallyLightCamListBox.SelectedItem as TallyLightCam;

            SendUpdate();

            LoadCamInfo(selectedCam);

            TallyLightCamListBox.Invalidate();
        }

        private void TallyLightCamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TallyLightCam? selectedCam = TallyLightCamListBox.SelectedItem as TallyLightCam;

            LoadCamInfo(selectedCam);

            TallyLightCamListBox.Invalidate();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            TallyLightCam? selectedCam = TallyLightCamListBox.SelectedItem as TallyLightCam;

            if (selectedCam != null)
            {
                selectedCam.CameraName = CameraNameTxt.Text;
                selectedCam.Scene = SceneComboBox.Text;
                tallyLightCamBindingSource.ResetBindings(false);

                onSceneChanged(obs, "");
            }
        }

        private void LoadCamInfo(TallyLightCam? selectedCam)
        {
            if (selectedCam != null)
            {
                CameraNameTxt.Text = selectedCam.CameraName;
                SceneComboBox.Text = selectedCam.Scene;
                CameraNameTxt.Enabled = true;
                SceneComboBox.Enabled = true;
                UpdateBtn.Enabled = true;
            }
            else
            {
                CameraNameTxt.Text = string.Empty;
                SceneComboBox.Text = string.Empty;
                CameraNameTxt.Enabled = false;
                SceneComboBox.Enabled = false;
                UpdateBtn.Enabled = false;
            }
        }

        private void SetServerBtn_ClickAsync(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProdNameTxt.Text))
            {
                MessageBox.Show("Producer is a required value.");
                return;
            }

            ProdName = ProdNameTxt.Text;

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(ServerTxt.Text + "/ping").Result;

                if (response.IsSuccessStatusCode)
                {
                    Server = ServerTxt.Text;
                    StartBtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Could not make connection. Check the Server field and try again.");
                    StartBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while connecting to server. Check the console for more information.");
                Console.WriteLine(ex.Message);
                StartBtn.Enabled = false;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            // Stop sending updates
            if (sendUpdates)
            {
                sendUpdates = false;
                StartBtn.Text = "Start";
            }
            else if (!string.IsNullOrEmpty(Server))
            {
                sendUpdates = true;
                StartBtn.Text = "Stop";
                SendUpdate();
            }
        }

        private async void SendUpdate()
        {
            if (sendUpdates)
            {
                string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    Cams = tallyLightCamBindingSource.List,
                    Prod = ProdName
                });

                StringContent payload = new StringContent(jsonString);

                try
                {
                    await httpClient.SendAsync(new HttpRequestMessage()
                    {
                        RequestUri = new Uri($"{Server}/setCams"),
                        Method = HttpMethod.Put,
                        Content = payload
                    });
                }
                catch (HttpRequestException ex)
                {
                    if (ex.StatusCode == null)
                    {
                        MessageBox.Show("Error reaching server");
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void onDisconnect(object? sender, EventArgs e)
        {
            WebsocketServerTxt.Enabled = true;
            WebsocketPasswordTxt.Enabled = true;

            StartWebsocketBtn.Text = "Start";
        }

        private void onSceneChanged(OBSWebsocket sender, string newSceneName)
        {
            if (sender.IsConnected && sender.StudioModeEnabled())
            {
                foreach (TallyLightCam cam in tallyLightCamBindingSource)
                {
                    if (cam.Scene == sender.GetCurrentScene().Name)
                    {
                        cam.State = CamState.Active;
                    }
                    else if (cam.Scene == sender.GetPreviewScene().Name)
                    {
                        cam.State = CamState.Preview;
                    }
                    else
                    {
                        cam.State = CamState.Clear;
                    }
                }

                TallyLightCamListBox.Invalidate();
            }

            SendUpdate();
        }

        private void StartWebsocketBtn_Click(object sender, EventArgs e)
        {
            if (!obs.IsConnected)
            {
                try
                {
                    obs.Connect(WebsocketServerTxt.Text, WebsocketPasswordTxt.Text);
                }
                catch (Exception ex)
                {
                    if (ex is AuthFailureException)
                    {
                        MessageBox.Show("Unable to connect to websocket server due to bad authentication. Check the password and try again.");
                        return;
                    }

                    MessageBox.Show("Error connecting to websocket. Check the server IP and password and try again. Check the console for more information");
                    Console.WriteLine(ex.Message);
                    return;
                }

                if (!obs.IsConnected)
                {
                    MessageBox.Show("Error connecting to websocket. Check the server IP and password and try again.");
                    return;
                }

                obs.Disconnected += onDisconnect;
                obs.SceneChanged += onSceneChanged;
                obs.PreviewSceneChanged += onSceneChanged;

                WebsocketServerTxt.Enabled = false;
                WebsocketPasswordTxt.Enabled = false;

                StartWebsocketBtn.Text = "Stop";

                onSceneChanged(obs, "");
            }
            else
            {
                obs.Disconnect();

                obs.Disconnected -= onDisconnect;
                obs.SceneChanged -= onSceneChanged;
                obs.PreviewSceneChanged -= onSceneChanged;
            }
        }

        private void ShowPasswordChk_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox chkbox)
            {
                if (chkbox.Checked)
                {
                    WebsocketPasswordTxt.PasswordChar = '\0';
                    return;
                }

                WebsocketPasswordTxt.PasswordChar = '*';
            }
        }

        private void TallyLightProd_Load(object sender, EventArgs e)
        {
            WebsocketServerTxt.Text = "ws://127.0.0.1:4444";
            Activate();
        }

        private void TallyLightCamListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index < 0)
            {
                return;
            }

            TallyLightCam? cam = TallyLightCamListBox.Items[e.Index] as TallyLightCam;
            Graphics g = e.Graphics;

            SolidBrush backgroundBrush = new SolidBrush(Color.White);

            // Set alpha of selected box
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backgroundBrush = new SolidBrush(Color.FromArgb(56, Color.FromKnownColor(KnownColor.Highlight)));
            }

            if(obs.IsConnected)
            {
                backgroundBrush = new SolidBrush(Color.FromArgb(128, TallyLightCam.ColorFromState(cam.State)));
            }

            g.FillRectangle(backgroundBrush, e.Bounds);

            g.DrawString(TallyLightCamListBox.Items[e.Index].ToString(),
                e.Font, new SolidBrush(Color.Black), e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
        }

        private void SceneComboBox_DropDown(object sender, EventArgs e)
        {
            if (!obs.IsConnected)
            {
                SceneComboBox.Items.Add("Connect to load scenes");
            }
            else
            {
                SceneComboBox.Items.Clear();

                foreach (OBSScene scene in obs.ListScenes())
                    SceneComboBox.Items.Add(scene.Name);
            }
        }

        private void SceneComboBox_DropDownClosed(object sender, EventArgs e)
        {
            SceneComboBox.Items.Clear();
        }

        private void MoveUpBtn_Click(object sender, EventArgs e)
        {
            MoveItem(true);
        }

        private void MoveDownBtn_Click(object sender, EventArgs e)
        {
            MoveItem(false);
        }

        private void MoveItem(bool up)
        {
            int currentIndex = TallyLightCamListBox.SelectedIndex;

            if (currentIndex < 0 || (!up && currentIndex + 1 >= TallyLightCamListBox.Items.Count) || (up && currentIndex - 1 < 0))
            {
                return;
            }

            List<TallyLightCam> currentItems = new List<TallyLightCam>(TallyLightCamListBox.Items.Cast<TallyLightCam>());

            if (up)
            {
                TallyLightCam old = currentItems[currentIndex - 1];
                currentItems[currentIndex - 1] = currentItems[currentIndex];
                currentItems[currentIndex] = old;
                TallyLightCamListBox.SelectedIndex = currentIndex - 1;
            }
            else
            {

                TallyLightCam old = currentItems[currentIndex + 1];
                currentItems[currentIndex + 1] = currentItems[currentIndex];
                currentItems[currentIndex] = old;
                TallyLightCamListBox.SelectedIndex = currentIndex + 1;
            }

            tallyLightCamBindingSource.DataSource = currentItems;
        }
    }
}
