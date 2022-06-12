using ProdHelper.Models;
using ProdHelper.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdHelper.ObserverClient
{
    public partial class TallyLightObserver : Form
    {
        public string ProdName { get; set; } = string.Empty;

        public string Server { get; set; } = string.Empty;

        public string Camera { get; set; } = string.Empty;

        public bool ValidatedServer { get; set; } = false;

        private HttpClient httpClient;

        private int failedConnectionCount = 0;

        private TallyLightForm tallyLightForm;
        private System.Windows.Forms.Timer updateTimer;
        private Process targetProcess;

        private Dictionary<string, string> cachedProcesses = new Dictionary<string, string>();

        public TallyLightObserver()
        {
            httpClient = new HttpClient();

            InitializeComponent();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ProdNameTxt.Text))
            {
                MessageBox.Show("Producer is a required value.");
                return;
            }

            if (string.IsNullOrEmpty(CameraNameTxt.Text))
            {
                MessageBox.Show("Camera Name is a required value.");
                return;
            }

            ProdName = ProdNameTxt.Text;
            Camera = CameraNameTxt.Text;

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(ServerTxt.Text + "/ping").Result;

                if (response.IsSuccessStatusCode)
                {
                    Server = ServerTxt.Text;
                    ValidatedServer = true;

                    if (!OverlayAppChk.Checked || !string.IsNullOrEmpty(ApplicationComboBox.Text))
                    {
                        OpenBtn.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Could not make connection. Check the Server field and try again.");
                    OpenBtn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while connecting to server. Check the console for more information.");
                Console.WriteLine(ex.Message);
                OpenBtn.Enabled = false;
            }
        }

        private void ApplicationComboBox_DropDown(object sender, EventArgs e)
        {
            ApplicationComboBox.Items.Clear();
            cachedProcesses.Clear();

            List<string> toShow = new List<string>();

            Process[] processes = Process.GetProcesses();

            foreach (Process p in processes)
            {
                if (!string.IsNullOrEmpty(p.MainWindowTitle))
                {
                    string fileName = string.Empty;

                    try
                    {
                        fileName = $" - ({Path.GetFileName(p?.MainModule?.FileName)})";
                    }
                    catch (Win32Exception)
                    { }

                    string displayName = $"{p.MainWindowTitle}{fileName}";
                    if (cachedProcesses.ContainsKey(displayName))
                    {
                        displayName += "(1)";
                    }

                    toShow.Add(displayName);
                    cachedProcesses.Add(displayName, p.ProcessName);
                }
            }

            ApplicationComboBox.Items.Clear();
            ApplicationComboBox.Items.AddRange(toShow.OrderBy(s => s).ToArray());

            int maxWidth = 0, temp = 0;

            foreach (var obj in ApplicationComboBox.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), ApplicationComboBox.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }

            ApplicationComboBox.DropDownWidth = maxWidth;
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            if (updateTimer == null || !updateTimer.Enabled)
            {
                if (!OverlayAppChk.Checked)
                {
                    tallyLightForm = new TallyLightForm();
                }
                else
                {
                    Process[] foundProcesses = Process.GetProcessesByName(cachedProcesses[ApplicationComboBox.Text]);

                    if (foundProcesses.Length > 0)
                    {
                        targetProcess = foundProcesses[0];
                        tallyLightForm = new TallyLightForm(targetProcess);
                    }
                    else
                    {
                        MessageBox.Show("Invalid process selected. Please try selecting the process again.");
                        return;
                    }
                }

                tallyLightForm.FormClosed += StopTimer;

                updateTimer = new System.Windows.Forms.Timer();
                updateTimer.Interval = 100;
                updateTimer.Tick += GetCamState;
                updateTimer.Enabled = true;

                OpenBtn.Text = "Close";
            }
            else
            {
                StopTimer(sender, e);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            StopTimer(this, e);
        }

        private void StopTimer(object? sender, EventArgs e)
        {
            if (tallyLightForm != null && sender != tallyLightForm)
            {
                tallyLightForm.Close();
            }

            if (updateTimer != null)
            {
                updateTimer.Enabled = false;
                updateTimer.Dispose();
            }
           
            OpenBtn.Text = "Open Tally Light";
        }

        private async void GetCamState(object? sender, EventArgs e)
        {
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
                Camera = Camera,
                Prod = ProdName
            });

            StringContent payload = new StringContent(jsonString);

            CamState camState = CamState.NotFound;

            try
            {
                HttpResponseMessage response = await httpClient.SendAsync(new HttpRequestMessage()
                {
                    RequestUri = new Uri($"{Server}/getCams"),
                    Method = HttpMethod.Get,
                    Content = payload
                });

                using (StreamReader reader = new StreamReader(response.Content.ReadAsStream()))
                {
                    camState = (CamState)int.Parse(reader.ReadToEnd());
                }

                failedConnectionCount = 0;
            }
            catch (HttpRequestException ex )
            {
                // "Lost" connection
                if (ex.StatusCode == null)
                {
                    failedConnectionCount++;
                }

                if (failedConnectionCount > 10)
                {
                    camState = CamState.Disconnected;
                }
            }

            tallyLightForm.UpdateForm(camState);
        }

        private void OverlayAppChk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                ApplicationComboBox.Enabled = true;
                
                OpenBtn.Enabled = false;
            }
            else
            {
                ApplicationComboBox.Enabled = false;

                if (ValidatedServer)
                {
                    OpenBtn.Enabled = true;
                }
            }
        }

        private void ApplicationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenBtn.Enabled = true;
        }

        private void ApplicationComboBox_TextUpdate(object sender, EventArgs e)
        {
            OpenBtn.Enabled = !string.IsNullOrEmpty(ApplicationComboBox.Text);
        }

        private void TallyLightObserver_Load(object sender, EventArgs e)
        {
            Activate();
        }
    }
}
