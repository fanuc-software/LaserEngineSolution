using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc
{
    public class MopKeyStatus
    {
        public bool Mop_Auto_Status { get; set; }
        public bool Mop_Edit_Status { get; set; }
        public bool Mop_Mdi_Status { get; set; }
        public bool Mop_Rmt_Status { get; set; }
        public bool Mop_Rtn_Status { get; set; }
        public bool Mop_Jog_Status { get; set; }
        public bool Mop_Handle_Status { get; set; }


        public bool Mop_Step_Status { get; set; }

        public bool Mop_Skip_Status { get; set; }

        public bool Mop_Opt_Status { get; set; }

        public bool Mop_Dry_Status { get; set; }

        public bool Mop_AutoStart_Status { get; set; }

        public bool Mop_StorageStop_Status { get; set; }

        public bool Mop_RollBack_Status { get; set; }

        public bool Mop_PiercingDelay_Status { get; set; }

        public bool Mop_PiercingShorten_Status { get; set; }

        public bool Mop_DustClear_Status { get; set; }

        public bool Mop_LampOn_Status { get; set; }

        public bool Mop_FollowOn_Status { get; set; }

        public bool Mop_FollowLock_Status { get; set; }

        public bool Mop_RapidOv0_Status { get; set; }
        public bool Mop_RapidOv25_Status { get; set; }
        public bool Mop_RapidOv50_Status { get; set; }
        public bool Mop_RapidOv100_Status { get; set; }

        public bool Mop_HandleOv1_Status { get; set; }
        public bool Mop_HandleOv10_Status { get; set; }
        public bool Mop_HandleOv100_Status { get; set; }
        public bool Mop_HandleOv1000_Status { get; set; }

        public bool Mop_AXIS_X_Status { get; set; }
        public bool Mop_AXIS_Y_Status { get; set; }
        public bool Mop_AXIS_Z_Status { get; set; }
        public bool Mop_AXIS_4_Status { get; set; }

        public bool Mop_Manual_Plus_Status { get; set; }
        public bool Mop_Manual_Rapid_Status { get; set; }
        public bool Mop_Manual_Subtract_Status { get; set; }

        public byte Mop_Aux_G_Value { get; set; }
        public byte Mop_Laser_Power_Value { get; set; }
        public byte Mop_Laser_Freq_Value { get; set; }
        public byte Mop_Laser_Duty_Value { get; set; }
        public short Mop_Jog_Override_Value { get; set; }


        public short Mop_Laser_Power_Data { get; set; }

        public short Mop_Laser_Power_Percent { get; set; }

        public bool XPLUS { get; set; }
        public bool YPLUS { get; set; }
        public bool ZPLUS { get; set; }
        public bool BPLUS { get; set; }

        public bool XMINUS { get; set; }
        public bool YMINUS { get; set; }
        public bool ZMINUS { get; set; }
        public bool BMINUS { get; set; }

        public double AirPressure { get; set; }

        public double NAirPressure { get; set; }

        public double OAirPressure { get; set; }

        public double FocusPosition { get; set; }

        public double CutPressureSet { get; set; }

        public double CutPressureActual { get; set; }

        public bool GAS_A { get; set; }

        public bool GAS_O { get; set; }

        public bool GAS_N { get; set; }
    }
}
