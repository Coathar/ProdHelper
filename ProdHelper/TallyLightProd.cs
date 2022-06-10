using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdHelper
{
    public partial class TallyLightProd : Form
    {

        public string Server { get; set; } = string.Empty;

        protected OBSWebsocket obs;

        public TallyLightProd()
        {
            InitializeComponent();
        }

        private void TallyLightAddBtn_Click(object sender, EventArgs e)
        {
            tallyLightCamBindingSource.Add(new TallyLightCam($"New Camera {tallyLightCamBindingSource.Count}", ""));

            TallyLightCam? selectedCam = TallyLightCamListBox.SelectedItem as TallyLightCam;

            LoadCamInfo(selectedCam);
        }

        private void TallyLightRemoveBtn_Click(object sender, EventArgs e)
        {
            tallyLightCamBindingSource.Remove(TallyLightCamListBox.SelectedItem);

            TallyLightCam? selectedCam = TallyLightCamListBox.SelectedItem as TallyLightCam;

            LoadCamInfo(selectedCam);
        }

        private void TallyLightCamListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TallyLightCam? selectedCam = TallyLightCamListBox.SelectedItem as TallyLightCam;

            LoadCamInfo(selectedCam);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            TallyLightCam? selectedCam = TallyLightCamListBox.SelectedItem as TallyLightCam;

            if (selectedCam != null)
            {
                selectedCam.CameraName = CameraNameTxt.Text;
                selectedCam.Scene = SceneNameTxt.Text;
                tallyLightCamBindingSource.ResetBindings(false);
            }
        }

        private void LoadCamInfo(TallyLightCam? selectedCam)
        {
            if (selectedCam != null)
            {
                CameraNameTxt.Text = selectedCam.CameraName;
                SceneNameTxt.Text = selectedCam.Scene;
            }
            else
            {
                CameraNameTxt.Text = string.Empty;
                SceneNameTxt.Text = string.Empty;
            }
        }

        private void SetServerBtn_Click(object sender, EventArgs e)
        {
            Server = ServerTxt.Text;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            obs = new OBSWebsocket();

            obs.Connected += onConnect;
            obs.Disconnected += onDisconnect;
            obs.SceneChanged += onSceneChanged;


            obs.StreamStatus += onStreamData;
        }

        private void onConnect(object sender, EventArgs e)
        {
        }

        private void onDisconnect(object sender, EventArgs e)
        {

        }

        private void onSceneChanged(OBSWebsocket sender, string newSceneName)
        {

        }

        private void onStreamData(OBSWebsocket sender, StreamStatus data)
        {

        }
    }
}
