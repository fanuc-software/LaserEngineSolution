using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc
{
    public class WorkStationInfo
    {
        public bool MainWorkStationUp { get; set; }
        public bool MainWorkStationDown { get; set; }
        public bool MainWorkStationLeft { get; set; }
        public bool MainWorkStationRight { get; set; }

        public bool SubWorkStationUp { get; set; }
        public bool SubWorkStationDown { get; set; }
        public bool SubWorkStationLeft { get; set; }
        public bool SubWorkStationRight { get; set; }

    }
}
