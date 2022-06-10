using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdHelper
{
    public class TallyLightCam
    {
        public string CameraName { get; set; }

        public string Scene { get; set; }

        public TallyLightCam(string cameraName, string scene)
        {
            CameraName = cameraName;
            Scene = scene;
        }

        public static void Test()
        {

        }
    }
}
