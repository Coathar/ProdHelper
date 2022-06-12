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

        public static Color ColorFromState(CamState camState)
        {
            Color toReturn = Color.White;

            switch (camState)
            {
                case CamState.Preview:
                    toReturn = Color.FromArgb(255, 183, 0);
                    break;
                case CamState.Active:
                    toReturn = Color.FromArgb(255, 0, 0);
                    break;
                case CamState.Clear:
                    toReturn = Color.FromArgb(100, 100, 255);
                    break;
                case CamState.NotFound:
                    toReturn = Color.White;
                    break;

            }

            return toReturn;
        }
    }

    public enum CamState
    {
        NotFound,
        Clear,
        Preview,
        Active,


    }

    
}
