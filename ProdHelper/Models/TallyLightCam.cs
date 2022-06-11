namespace ProdHelper.Models
{
    public class TallyLightCam
    {
        public string CameraName { get; set; }

        public string Scene { get; set; }

        public CamState State { get; set; }

        public TallyLightCam(string cameraName, string scene)
        {
            CameraName = cameraName;
            Scene = scene;
            State = CamState.Clear;
        }

        public override string ToString()
        {
            return $"{CameraName} - {Scene}";
        }
    }

    public enum CamState
    {
        Clear,
        Active,
        Preview,
    }
}
