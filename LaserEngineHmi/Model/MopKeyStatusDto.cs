using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;

namespace LaserEngineHmi.Model
{
    public class MopKeyStatusDto : ViewModelBase
    {
        private bool mop_Auto_Status;
        public bool Mop_Auto_Status
        {
            get { return mop_Auto_Status; }
            set
            {
                if (mop_Auto_Status != value)
                {
                    mop_Auto_Status = value;
                    RaisePropertyChanged(() => Mop_Auto_Status);
                }
            }
        }

        private bool mop_Edit_Status;
        public bool Mop_Edit_Status
        {
            get { return mop_Edit_Status; }
            set
            {
                if (mop_Edit_Status != value)
                {
                    mop_Edit_Status = value;
                    RaisePropertyChanged(() => Mop_Edit_Status);
                }
            }
        }

        private bool mop_Mdi_Status;
        public bool Mop_Mdi_Status
        {
            get { return mop_Mdi_Status; }
            set
            {
                if (mop_Mdi_Status != value)
                {
                    mop_Mdi_Status = value;
                    RaisePropertyChanged(() => Mop_Mdi_Status);
                }
            }
        }

        private bool mop_Rmt_Status;
        public bool Mop_Rmt_Status
        {
            get { return mop_Rmt_Status; }
            set
            {
                if (mop_Rmt_Status != value)
                {
                    mop_Rmt_Status = value;
                    RaisePropertyChanged(() => Mop_Rmt_Status);
                }
            }
        }

        private bool mop_Rtn_Status;
        public bool Mop_Rtn_Status
        {
            get { return mop_Rtn_Status; }
            set
            {
                if (mop_Rtn_Status != value)
                {
                    mop_Rtn_Status = value;
                    RaisePropertyChanged(() => Mop_Rtn_Status);
                }
            }
        }

        private bool mop_Jog_Status;
        public bool Mop_Jog_Status
        {
            get { return mop_Jog_Status; }
            set
            {
                if (mop_Jog_Status != value)
                {
                    mop_Jog_Status = value;
                    RaisePropertyChanged(() => Mop_Jog_Status);
                }
            }
        }

        private bool mop_Handle_Status;
        public bool Mop_Handle_Status
        {
            get { return mop_Handle_Status; }
            set
            {
                if (mop_Handle_Status != value)
                {
                    mop_Handle_Status = value;
                    RaisePropertyChanged(() => Mop_Handle_Status);
                }
            }
        }

        private bool mop_Step_Status;
        public bool Mop_Step_Status
        {
            get { return mop_Step_Status; }
            set
            {
                if (mop_Step_Status != value)
                {
                    mop_Step_Status = value;
                    RaisePropertyChanged(() => Mop_Step_Status);
                }
            }
        }

        private bool mop_Skip_Status;
        public bool Mop_Skip_Status
        {
            get { return mop_Skip_Status; }
            set
            {
                if (mop_Skip_Status != value)
                {
                    mop_Skip_Status = value;
                    RaisePropertyChanged(() => Mop_Skip_Status);
                }
            }
        }

        private bool mop_Opt_Status;
        public bool Mop_Opt_Status
        {
            get { return mop_Opt_Status; }
            set
            {
                if (mop_Opt_Status != value)
                {
                    mop_Opt_Status = value;
                    RaisePropertyChanged(() => Mop_Opt_Status);
                }
            }
        }

        private bool mop_Dry_Status;
        public bool Mop_Dry_Status
        {
            get { return mop_Dry_Status; }
            set
            {
                if (mop_Dry_Status != value)
                {
                    mop_Dry_Status = value;
                    RaisePropertyChanged(() => Mop_Dry_Status);
                }
            }
        }

        private bool mop_AutoStart_Status;
        public bool Mop_AutoStart_Status
        {
            get { return mop_AutoStart_Status; }
            set
            {
                if (mop_AutoStart_Status != value)
                {
                    mop_AutoStart_Status = value;
                    RaisePropertyChanged(() => Mop_AutoStart_Status);
                }
            }
        }

        private bool mop_StorageStop_Status;
        public bool Mop_StorageStop_Status
        {
            get { return mop_StorageStop_Status; }
            set
            {
                if (mop_StorageStop_Status != value)
                {
                    mop_StorageStop_Status = value;
                    RaisePropertyChanged(() => Mop_StorageStop_Status);
                }
            }
        }

        private bool mop_RollBack_Status;
        public bool Mop_RollBack_Status
        {
            get { return mop_RollBack_Status; }
            set
            {
                if (mop_RollBack_Status != value)
                {
                    mop_RollBack_Status = value;
                    RaisePropertyChanged(() => Mop_RollBack_Status);
                }
            }
        }

        private bool mop_PiercingDelay_Status;
        public bool Mop_PiercingDelay_Status
        {
            get { return mop_PiercingDelay_Status; }
            set
            {
                if (mop_PiercingDelay_Status != value)
                {
                    mop_PiercingDelay_Status = value;
                    RaisePropertyChanged(() => Mop_PiercingDelay_Status);
                }
            }
        }

        private bool mop_PiercingShorten_Status;
        public bool Mop_PiercingShorten_Status
        {
            get { return mop_PiercingShorten_Status; }
            set
            {
                if (mop_PiercingShorten_Status != value)
                {
                    mop_PiercingShorten_Status = value;
                    RaisePropertyChanged(() => Mop_PiercingShorten_Status);
                }
            }
        }

        private bool mop_DustClear_Status;
        public bool Mop_DustClear_Status
        {
            get { return mop_DustClear_Status; }
            set
            {
                if (mop_DustClear_Status != value)
                {
                    mop_DustClear_Status = value;
                    RaisePropertyChanged(() => Mop_DustClear_Status);
                }
            }
        }


        private bool mop_LampOn_Status;
        public bool Mop_LampOn_Status
        {
            get { return mop_LampOn_Status; }
            set
            {
                if (mop_LampOn_Status != value)
                {
                    mop_LampOn_Status = value;
                    RaisePropertyChanged(() => Mop_LampOn_Status);
                }
            }
        }

        private bool mop_FollowOn_Status;
        public bool Mop_FollowOn_Status
        {
            get { return mop_FollowOn_Status; }
            set
            {
                if (mop_FollowOn_Status != value)
                {
                    mop_FollowOn_Status = value;
                    RaisePropertyChanged(() => Mop_FollowOn_Status);
                }
            }
        }

        private bool mop_FollowLock_Status;
        public bool Mop_FollowLock_Status
        {
            get { return mop_FollowLock_Status; }
            set
            {
                if (mop_FollowLock_Status != value)
                {
                    mop_FollowLock_Status = value;
                    RaisePropertyChanged(() => Mop_FollowLock_Status);
                }
            }
        }

        private bool mop_RapidOv0_Status;
        public bool Mop_RapidOv0_Status
        {
            get { return mop_RapidOv0_Status; }
            set
            {
                if (mop_RapidOv0_Status != value)
                {
                    mop_RapidOv0_Status = value;
                    RaisePropertyChanged(() => Mop_RapidOv0_Status);
                }
            }
        }

        private bool mop_RapidOv25_Status;
        public bool Mop_RapidOv25_Status
        {
            get { return mop_RapidOv25_Status; }
            set
            {
                if (mop_RapidOv25_Status != value)
                {
                    mop_RapidOv25_Status = value;
                    RaisePropertyChanged(() => Mop_RapidOv25_Status);
                }
            }
        }

        private bool mop_RapidOv50_Status;
        public bool Mop_RapidOv50_Status
        {
            get { return mop_RapidOv50_Status; }
            set
            {
                if (mop_RapidOv50_Status != value)
                {
                    mop_RapidOv50_Status = value;
                    RaisePropertyChanged(() => Mop_RapidOv50_Status);
                }
            }
        }

        private bool mop_RapidOv100_Status;
        public bool Mop_RapidOv100_Status
        {
            get { return mop_RapidOv100_Status; }
            set
            {
                if (mop_RapidOv100_Status != value)
                {
                    mop_RapidOv100_Status = value;
                    RaisePropertyChanged(() => Mop_RapidOv100_Status);
                }
            }
        }

        private bool mop_HandleOv1_Status;
        public bool Mop_HandleOv1_Status
        {
            get { return mop_HandleOv1_Status; }
            set
            {
                if (mop_HandleOv1_Status != value)
                {
                    mop_HandleOv1_Status = value;
                    RaisePropertyChanged(() => Mop_HandleOv1_Status);
                }
            }
        }

        private bool mop_HandleOv10_Status;
        public bool Mop_HandleOv10_Status
        {
            get { return mop_HandleOv10_Status; }
            set
            {
                if (mop_HandleOv10_Status != value)
                {
                    mop_HandleOv10_Status = value;
                    RaisePropertyChanged(() => Mop_HandleOv10_Status);
                }
            }
        }

        private bool mop_HandleOv100_Status;
        public bool Mop_HandleOv100_Status
        {
            get { return mop_HandleOv100_Status; }
            set
            {
                if (mop_HandleOv100_Status != value)
                {
                    mop_HandleOv100_Status = value;
                    RaisePropertyChanged(() => Mop_HandleOv100_Status);
                }
            }
        }

        private bool mop_HandleOv1000_Status;
        public bool Mop_HandleOv1000_Status
        {
            get { return mop_HandleOv1000_Status; }
            set
            {
                if (mop_HandleOv1000_Status != value)
                {
                    mop_HandleOv1000_Status = value;
                    RaisePropertyChanged(() => Mop_HandleOv1000_Status);
                }
            }
        }

        private bool mop_AXIS_X_Status;
        public bool Mop_AXIS_X_Status
        {
            get { return mop_AXIS_X_Status; }
            set
            {
                if (mop_AXIS_X_Status != value)
                {
                    mop_AXIS_X_Status = value;
                    RaisePropertyChanged(() => Mop_AXIS_X_Status);
                }
            }
        }


        private bool mop_AXIS_Y_Status;
        public bool Mop_AXIS_Y_Status
        {
            get { return mop_AXIS_Y_Status; }
            set
            {
                if (mop_AXIS_Y_Status != value)
                {
                    mop_AXIS_Y_Status = value;
                    RaisePropertyChanged(() => Mop_AXIS_Y_Status);
                }
            }
        }

        private bool mop_AXIS_Z_Status;
        public bool Mop_AXIS_Z_Status
        {
            get { return mop_AXIS_Z_Status; }
            set
            {
                if (mop_AXIS_Z_Status != value)
                {
                    mop_AXIS_Z_Status = value;
                    RaisePropertyChanged(() => Mop_AXIS_Z_Status);
                }
            }
        }

        private bool mop_AXIS_4_Status;
        public bool Mop_AXIS_4_Status
        {
            get { return mop_AXIS_4_Status; }
            set
            {
                if (mop_AXIS_4_Status != value)
                {
                    mop_AXIS_4_Status = value;
                    RaisePropertyChanged(() => Mop_AXIS_4_Status);
                }
            }
        }

        private bool mop_Manual_Plus_Status;
        public bool Mop_Manual_Plus_Status
        {
            get { return mop_Manual_Plus_Status; }
            set
            {
                if (mop_Manual_Plus_Status != value)
                {
                    mop_Manual_Plus_Status = value;
                    RaisePropertyChanged(() => Mop_Manual_Plus_Status);
                }
            }
        }

        private bool mop_Manual_Rapid_Status;
        public bool Mop_Manual_Rapid_Status
        {
            get { return mop_Manual_Rapid_Status; }
            set
            {
                if (mop_Manual_Rapid_Status != value)
                {
                    mop_Manual_Rapid_Status = value;
                    RaisePropertyChanged(() => Mop_Manual_Rapid_Status);
                }
            }
        }

        private bool mop_Manual_Subtract_Status;
        public bool Mop_Manual_Subtract_Status
        {
            get { return mop_Manual_Subtract_Status; }
            set
            {
                if (mop_Manual_Subtract_Status != value)
                {
                    mop_Manual_Subtract_Status = value;
                    RaisePropertyChanged(() => Mop_Manual_Subtract_Status);
                }
            }
        }

        private byte mop_Aux_G_Value;
        public byte Mop_Aux_G_Value
        {
            get { return mop_Aux_G_Value; }
            set
            {
                if (mop_Aux_G_Value != value)
                {
                    mop_Aux_G_Value = value;
                    RaisePropertyChanged(() => Mop_Aux_G_Value);
                }
            }
        }

        private byte mop_Laser_Power_Value;
        public byte Mop_Laser_Power_Value
        {
            get { return mop_Laser_Power_Value; }
            set
            {
                if (mop_Laser_Power_Value != value)
                {
                    mop_Laser_Power_Value = value;
                    RaisePropertyChanged(() => Mop_Laser_Power_Value);
                }
            }
        }

        private byte mop_Laser_Freq_Value;
        public byte Mop_Laser_Freq_Value
        {
            get { return mop_Laser_Freq_Value; }
            set
            {
                if (mop_Laser_Freq_Value != value)
                {
                    mop_Laser_Freq_Value = value;
                    RaisePropertyChanged(() => Mop_Laser_Freq_Value);
                }
            }
        }

        private byte mop_Laser_Duty_Value;
        public byte Mop_Laser_Duty_Value
        {
            get { return mop_Laser_Duty_Value; }
            set
            {
                if (mop_Laser_Duty_Value != value)
                {
                    mop_Laser_Duty_Value = value;
                    RaisePropertyChanged(() => Mop_Laser_Duty_Value);
                }
            }
        }

        private short mop_Jog_Override_Value;
        public short Mop_Jog_Override_Value
        {
            get { return mop_Jog_Override_Value; }
            set
            {
                if (mop_Jog_Override_Value != value)
                {
                    mop_Jog_Override_Value = value;
                    RaisePropertyChanged(() => Mop_Jog_Override_Value);
                }
            }
        }

        private short mop_Laser_Power_Data;
        public short Mop_Laser_Power_Data
        {
            get { return mop_Laser_Power_Data; }
            set
            {
                if (mop_Laser_Power_Data != value)
                {
                    mop_Laser_Power_Data = value;
                    RaisePropertyChanged(() => Mop_Laser_Power_Data);
                }
            }
        }

        private short mop_Laser_Power_Percent;
        public short Mop_Laser_Power_Percent
        {
            get { return mop_Laser_Power_Percent; }
            set
            {
                if (mop_Laser_Power_Percent != value)
                {
                    mop_Laser_Power_Percent = value;
                    RaisePropertyChanged(() => Mop_Laser_Power_Percent);
                }
            }
        }

        private bool mop_XPLUSt;
        public bool XPLUS
        {
            get { return mop_XPLUSt; }
            set
            {
                if (mop_XPLUSt != value)
                {
                    mop_XPLUSt = value;
                    RaisePropertyChanged(() => XPLUS);
                }
            }
        }

        private bool mop_YPLUS;
        public bool YPLUS
        {
            get { return mop_YPLUS; }
            set
            {
                if (mop_YPLUS != value)
                {
                    mop_YPLUS = value;
                    RaisePropertyChanged(() => YPLUS);
                }
            }
        }

        private bool mop_YMINUS;
        public bool YMINUS
        {
            get { return mop_YMINUS; }
            set
            {
                if (mop_YMINUS != value)
                {
                    mop_YMINUS = value;
                    RaisePropertyChanged(() => YMINUS);
                }
            }
        }

        private bool mop_XMINUS;
        public bool XMINUS
        {
            get { return mop_XMINUS; }
            set
            {
                if (mop_XMINUS != value)
                {
                    mop_XMINUS = value;
                    RaisePropertyChanged(() => XMINUS);
                }
            }
        }

        private bool mop_BPLUS;
        public bool BPLUS
        {
            get { return mop_BPLUS; }
            set
            {
                if (mop_BPLUS != value)
                {
                    mop_BPLUS = value;
                    RaisePropertyChanged(() => BPLUS);
                }
            }
        }

        private bool mop_BMINUS;
        public bool BMINUS
        {
            get { return mop_BMINUS; }
            set
            {
                if (mop_BMINUS != value)
                {
                    mop_BMINUS = value;
                    RaisePropertyChanged(() => BMINUS);
                }
            }
        }

        private bool mop_ZPLUS;
        public bool ZPLUS
        {
            get { return mop_ZPLUS; }
            set
            {
                if (mop_ZPLUS != value)
                {
                    mop_ZPLUS = value;
                    RaisePropertyChanged(() => ZPLUS);
                }
            }
        }

        private bool mop_ZMINUS;
        public bool ZMINUS
        {
            get { return mop_ZMINUS; }
            set
            {
                if (mop_ZMINUS != value)
                {
                    mop_ZMINUS = value;
                    RaisePropertyChanged(() => ZMINUS);
                }
            }
        }

        private bool mop_GAS_A;
        public bool GAS_A
        {
            get { return mop_GAS_A; }
            set
            {
                if (mop_GAS_A != value)
                {
                    mop_GAS_A = value;
                    RaisePropertyChanged(() => GAS_A);
                }
            }
        }

        private bool mop_GAS_O;
        public bool GAS_O
        {
            get { return mop_GAS_O; }
            set
            {
                if (mop_GAS_O != value)
                {
                    mop_GAS_O = value;
                    RaisePropertyChanged(() => GAS_O);
                }
            }
        }

        private bool mop_GAS_N;
        public bool GAS_N
        {
            get { return mop_GAS_N; }
            set
            {
                if (mop_GAS_N != value)
                {
                    mop_GAS_N = value;
                    RaisePropertyChanged(() => GAS_N);
                }
            }
        }

        public string StrGAS
        {
            get
            {
                if (GAS_A == true && GAS_O == false && GAS_N == false) return "空气";
                if (GAS_A == false && GAS_O == true && GAS_N == false) return "氧气";
                if (GAS_A == false && GAS_O == false && GAS_N == true) return "氮气";
                return "";

            }
        }

        private double mop_AirPressure;
        public double AirPressure
        {
            get { return mop_AirPressure; }
            set
            {
                if (mop_AirPressure != value)
                {
                    mop_AirPressure = value;
                    RaisePropertyChanged(() => AirPressure);
                }
            }
        }

        private double mop_NAirPressure;
        public double NAirPressure
        {
            get { return mop_NAirPressure; }
            set
            {
                if (mop_NAirPressure != value)
                {
                    mop_NAirPressure = value;
                    RaisePropertyChanged(() => NAirPressure);
                }
            }
        }

        private double mop_OAirPressure;
        public double OAirPressure
        {
            get { return mop_OAirPressure; }
            set
            {
                if (mop_OAirPressure != value)
                {
                    mop_OAirPressure = value;
                    RaisePropertyChanged(() => OAirPressure);
                }
            }
        }

        private double mop_FocusPosition;
        public double FocusPosition
        {
            get { return mop_FocusPosition; }
            set
            {
                if (mop_FocusPosition != value)
                {
                    mop_FocusPosition = value;
                    RaisePropertyChanged(() => FocusPosition);
                }
            }
        }

        private double mop_CutPressureSet;
        public double CutPressureSet
        {
            get { return mop_CutPressureSet; }
            set
            {
                if (mop_CutPressureSet != value)
                {
                    mop_CutPressureSet = value;
                    RaisePropertyChanged(() => CutPressureSet);
                }
            }
        }

        private double mop_CutPressureActual;
        public double CutPressureActual
        {
            get { return mop_CutPressureActual; }
            set
            {
                if (mop_CutPressureActual != value)
                {
                    mop_CutPressureActual = value;
                    RaisePropertyChanged(() => CutPressureActual);
                }
            }
        }
    }
}
