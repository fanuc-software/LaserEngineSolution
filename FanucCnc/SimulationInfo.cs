using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc
{
    public class SimulationInfo
    {
        public double SIMULATION_STATUS_PC { get; set; }
        public double SIMULATION_STATUS_FR { get; set; }
        public double SIMULATION_STATUS_DU { get; set; }
        public double SIMULATION_STATUS_PA { get; set; }
        public double SIMULATION_STATUS_E0XX { get; set; }
        public double SIMULATION_STATUS_E10X { get; set; }
        public double SIMULATION_STATUS_F { get; set; }
        public byte SIMULATION_STATUS_LASEROV_PC { get; set; }
        public byte SIMULATION_STATUS_LASEROV_FR { get; set; }
        public byte SIMULATION_STATUS_LASEROV_DU { get; set; }
        public bool SIMULATION_STATUS_NANOPC { get; set; }
        public bool SIMULATION_STATUS_POWERCONTROL { get; set; }
        public bool SIMULATION_STATUS_EDGECUTTING { get; set; }


    }
}
