using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallyLightShared.Models;

namespace TallyLightShared.ConfigUtils
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class GlobalConfigOptions
    {
        public string? LastOverwatchConfigFolder { get; set; }

        public List<string>? RecentProductionFiles { get; set; }

        public List<ToolStripMenuItem>? RecentObserverFiles { get; set; }
    }
}
