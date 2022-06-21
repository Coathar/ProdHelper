using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallyLightShared.Models;

namespace TallyLightShared.ConfigUtils
{
    internal class TallyLightProductionOptions
    {
        public List<TallyLightCam>? SavedCameras { get; set; }

        public string? TallyLightServer { get; set; }

        public string? TallyLightProductionName { get; set; }
    }
}
