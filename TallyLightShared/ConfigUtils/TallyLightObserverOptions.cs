using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallyLightShared.Models;

namespace TallyLightShared.ConfigUtils
{
    public class TallyLightObserverOptions
    {
        public ObserverOptions? SavedObserverOptions { get; set; }

        public class ObserverOptions
        {
            public int DefaultSize { get; set; }

            public TallyLightShape DefaultShape { get; set; }

            // Configurable colors?
        }
    }
}
