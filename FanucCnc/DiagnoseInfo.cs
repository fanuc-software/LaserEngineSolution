using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc
{
    public class DiagnoseInfo
    {
        public double DIAGNOSE_VALUE_PC { get; set; }
        
        public double DIAGNOSE_VALUE_FR { get; set; }
        
        public double DIAGNOSE_VALUE_DU { get; set; }
        
        public double DIAGNOSE_VALUE_PA { get; set; }
        
        public double DIAGNOSE_VALUE_F { get; set; }
        
        public byte DIAGNOSE_PERCENT_PC { get; set; }
        
        public byte DIAGNOSE_PERCENT_FR { get; set; }
        
        public byte DIAGNOSE_PERCENT_DU { get; set; }

        public double DIAGNOSE_REFLECTEDLIGHT { get; set; }

        public double DIAGNOSE_COOLWATER_FLUX_PATH1 { get; set; }

        public double DIAGNOSE_COOLWATER_FLUX_PATH2 { get; set; }

        public double DIAGNOSE_COOLWATER_TEMP { get; set; }

        public double DIAGNOSE_FOGGING_TEMP { get; set; }

        public double DIAGNOSE_LASER_TEMP { get; set; }

        public double DIAGNOSE_LASER_HUMIDITY { get; set; }

    }
}
