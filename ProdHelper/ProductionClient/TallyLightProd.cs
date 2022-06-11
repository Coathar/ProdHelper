using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Types;
using ProdHelper.Models;
using System.Net.Http;

namespace ProdHelper.ProductionClient
{
    public partial class TallyLightProd : Form
    {

        public string Server { get; set; } = string.Empty;

        public string ProdName { get; set; } = string.Empty;

        protected OBSWebsocket obs;

        HttpClient httpClient = new HttpClient();

        bool sendUpdates;

        public TallyLightProd()
        {
            obs = new OBSWebsocket();
            InitializeComponent();
        }

        private void TallyLightAddBtn_Click(object sender, EventArgs e)
        {
            TallyLightCam toAdd = new TallyLightCam($"New Camera {tallyLightCamBindingSource.Count + 1}", "");
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
                MessageBox.Show("Prod name is a required value.");
                return;
            }

            ProdName = ProdNameTxt.Text;

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

                await httpClient.SendAsync(new HttpRequestMessage()
                {
                    RequestUri = new Uri($"{Server}/setCams"),
                    Method = HttpMethod.Put,
                    Content = payload
                });
            }
        }

        private void onConnect(object? sender, EventArgs e)
        {
            
        }

        private void onDisconnect(object? sender, EventArgs e)
        {
            WebsocketServerTxt.Enabled = true;
            WebsocketPasswordTxt.Enabled = true;

            StartWebsocketBtn.Text = "Start";
        }

        private void onSceneChanged(OBSWebsocket sender, string newSceneName)
        {
            if (sender.StudioModeEnabled())
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

                SendUpdate();

                TallyLightCamListBox.Invalidate();
            }
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
                    MessageBox.Show("Error connecting to websocket. Check the server IP and password and try again. Check the console for more information");
                    Console.WriteLine(ex.Message);
                    return;
                }

                if (!obs.IsConnected)
                {
                    MessageBox.Show("Error connecting to websocket. Check the server IP and password and try again.");
                    return;
                }

                obs.Connected += onConnect;
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

                obs.Connected -= onConnect;
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
            Application.EnableVisualStyles();
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

            SolidBrush backgroundBrush = new SolidBrush(Color.FromKnownColor(KnownColor.White));
            int redValue = 255;

            // Set alpha of selected box
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backgroundBrush = new SolidBrush(Color.FromArgb(56, Color.FromKnownColor(KnownColor.Highlight)));
            }

            if(obs.IsConnected)
            {
                if (cam?.State == CamState.Active)
                {
                    backgroundBrush = new SolidBrush(Color.FromArgb(128, 255, 0, 0));
                }
                else if (cam?.State == CamState.Preview)
                {
                    backgroundBrush = new SolidBrush(Color.FromArgb(128, 255, 183, 0));
                }
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
            if (!obs.IsConnected)
            {
                SceneComboBox.Items.Clear();
            }
        }
    }
}
