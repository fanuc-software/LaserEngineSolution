using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace DataCenter.Model
{
    public class MachiningLib_CuttingDto : ViewModelBase
    {

        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged(() => Id);
                }
            }
        }

        private short eNO;
        public short ENO
        {
            get { return eNO; }
            set
            {
                if (eNO != value)
                {
                    eNO = value;
                    RaisePropertyChanged(() => ENO);
                }
            }
        }

        private string machiningType;
        public string MachiningType
        {
            get { return machiningType; }
            set
            {
                if (machiningType != value)
                {
                    machiningType = value;
                    RaisePropertyChanged(() => MachiningType);
                }
            }
        }

        public string AKMachiningType
        {
            get {

                string temp = "";
                switch(ENO)
                {
                    case 1:
                        temp = "小轮廓";
                        break;
                    case 2:
                        temp = "中轮廓";
                        break;
                    case 3:
                        temp = "大轮廓";
                        break;
                    case 4:
                        temp = "超大轮廓";
                        break;
                    case 5:
                        temp = "其他";
                        break;
                    case 6:
                        temp = "其他";
                        break;
                    case 7:
                        temp = "栅格";
                        break;
                    case 8:
                        temp = "标记";
                        break;
                    case 9:
                        temp = "喷模";
                        break;
                    case 10:
                        temp = "其他";
                        break;
                    default:
                        temp = "其他";
                        break;

                }

                return temp;


            }
        }

        private string materialType;
        public string MaterialType
        {
            get { return materialType; }
            set
            {
                if (materialType != value)
                {
                    materialType = value;
                    RaisePropertyChanged(() => MaterialType);
                }
            }
        }

        private double materialThickness;
        public double MaterialThickness
        {
            get { return materialThickness; }
            set
            {
                if (materialThickness != value)
                {
                    materialThickness = value;
                    RaisePropertyChanged(() => MaterialThickness);
                }
            }
        }

        private double focalDistance;
        public double FocalDistance
        {
            get { return focalDistance; }
            set
            {
                if (focalDistance != value)
                {
                    focalDistance = value;
                    RaisePropertyChanged(() => FocalDistance);
                }
            }
        }

        private double focalPosition;
        public double FocalPosition
        {
            get { return focalPosition; }
            set
            {
                if (focalPosition != value)
                {
                    focalPosition = value;
                    RaisePropertyChanged(() => FocalPosition);
                }
            }
        }

        private string cutterType;
        public string CutterType
        {
            get { return cutterType; }
            set
            {
                if (cutterType != value)
                {
                    cutterType = value;
                    RaisePropertyChanged(() => CutterType);
                }
            }
        }

        private double cutterDiameter;
        public double CutterDiameter
        {
            get { return cutterDiameter; }
            set
            {
                if (cutterDiameter != value)
                {
                    cutterDiameter = value;
                    RaisePropertyChanged(() => CutterDiameter);
                }
            }
        }

        private double cutting_Feed;
        public double Cutting_Feed
        {
            get { return cutting_Feed; }
            set
            {
                if (cutting_Feed != value)
                {
                    cutting_Feed = value;
                    RaisePropertyChanged(() => Cutting_Feed);
                }
            }
        }

        private short cutting_Power;
        public short Cutting_Power
        {
            get { return cutting_Power; }
            set
            {
                if (cutting_Power != value)
                {
                    cutting_Power = value;
                    RaisePropertyChanged(() => Cutting_Power);
                }
            }
        }

        private short cutting_Freq;
        public short Cutting_Freq
        {
            get { return cutting_Freq; }
            set
            {
                if (cutting_Freq != value)
                {
                    cutting_Freq = value;
                    RaisePropertyChanged(() => Cutting_Freq);
                }
            }
        }

        private short cutting_Duty;
        public short Cutting_Duty
        {
            get { return cutting_Duty; }
            set
            {
                if (cutting_Duty != value)
                {
                    cutting_Duty = value;
                    RaisePropertyChanged(() => Cutting_Duty);
                }
            }
        }

        private double cutting_G_Press;
        public double Cutting_G_Press
        {
            get { return cutting_G_Press; }
            set
            {
                if (cutting_G_Press != value)
                {
                    cutting_G_Press = value;
                    RaisePropertyChanged(() => Cutting_G_Press);
                }
            }
        }

        private short cutting_G_Kind;
        public short Cutting_G_Kind
        {
            get { return cutting_G_Kind; }
            set
            {
                if (cutting_G_Kind != value)
                {
                    cutting_G_Kind = value;
                    RaisePropertyChanged(() => Cutting_G_Kind);
                }
            }
        }

        public string StrCutting_G_Kind
        {
            get
            {
                if (cutting_G_Kind == 0) return "空气";
                else if (cutting_G_Kind == 1) return "氧气";
                else if (cutting_G_Kind == 2) return "氮气";
                else return "未知";
            }

        }
        

        private double cutting_G_Ready_T;
        public double Cutting_G_Ready_T
        {
            get { return cutting_G_Ready_T; }
            set
            {
                if (cutting_G_Ready_T != value)
                {
                    cutting_G_Ready_T = value;
                    RaisePropertyChanged(() => Cutting_G_Ready_T);
                }
            }
        }

        private double cutting_Displace;
        public double Cutting_Displace
        {
            get { return cutting_Displace; }
            set
            {
                if (cutting_Displace != value)
                {
                    cutting_Displace = value;
                    RaisePropertyChanged(() => Cutting_Displace);
                }
            }
        }

        private double cutting_Supple;
        public double Cutting_Supple
        {
            get { return cutting_Supple; }
            set
            {
                if (cutting_Supple != value)
                {
                    cutting_Supple = value;
                    RaisePropertyChanged(() => Cutting_Supple);
                }
            }
        }

        private short cutting_Edge_Slt;
        public short Cutting_Edge_Slt
        {
            get { return cutting_Edge_Slt; }
            set
            {
                if (cutting_Edge_Slt != value)
                {
                    cutting_Edge_Slt = value;
                    RaisePropertyChanged(() => Cutting_Edge_Slt);
                }
            }
        }

        private short cutting_Appr_Slt;
        public short Cutting_Appr_Slt
        {
            get { return cutting_Appr_Slt; }
            set
            {
                if (cutting_Appr_Slt != value)
                {
                    cutting_Appr_Slt = value;
                    RaisePropertyChanged(() => Cutting_Appr_Slt);
                }
            }
        }

        private short cutting_Pwr_Ctrl;
        public short Cutting_Pwr_Ctrl
        {
            get { return cutting_Pwr_Ctrl; }
            set
            {
                if (cutting_Pwr_Ctrl != value)
                {
                    cutting_Pwr_Ctrl = value;
                    RaisePropertyChanged(() => Cutting_Pwr_Ctrl);
                }
            }
        }

        private double cutting_Displace_2;
        public double Cutting_Displace_2
        {
            get { return cutting_Displace_2; }
            set
            {
                if (cutting_Displace_2 != value)
                {
                    cutting_Displace_2 = value;
                    RaisePropertyChanged(() => Cutting_Displace_2);
                }
            }
        }

        private string cutting_Gap_Axis;
        public string Cutting_Gap_Axis
        {
            get { return cutting_Gap_Axis; }
            set
            {
                if (cutting_Gap_Axis != value)
                {
                    cutting_Gap_Axis = value;
                    RaisePropertyChanged(() => Cutting_Gap_Axis);
                }
            }
        }

        private string cutting_Feed_Dec;
        public string Cutting_Feed_Dec
        {
            get { return cutting_Feed_Dec; }
            set
            {
                if (cutting_Feed_Dec != value)
                {
                    cutting_Feed_Dec = value;
                    RaisePropertyChanged(() => Cutting_Feed_Dec);
                }
            }
        }

        private string cutting_Supple_Dec;
        public string Cutting_Supple_Dec
        {
            get { return cutting_Supple_Dec; }
            set
            {
                if (cutting_Supple_Dec != value)
                {
                    cutting_Supple_Dec = value;
                    RaisePropertyChanged(() => Cutting_Supple_Dec);
                }
            }
        }

        private string cutting_Dsp2_Dec;
        public string Cutting_Dsp2_Dec
        {
            get { return cutting_Dsp2_Dec; }
            set
            {
                if (cutting_Dsp2_Dec != value)
                {
                    cutting_Dsp2_Dec = value;
                    RaisePropertyChanged(() => Cutting_Dsp2_Dec);
                }
            }
        }

        private string cutting_Reverse_Info_1;
        public string Cutting_Reverse_Info_1
        {
            get { return cutting_Reverse_Info_1; }
            set
            {
                if (cutting_Reverse_Info_1 != value)
                {
                    cutting_Reverse_Info_1 = value;
                    RaisePropertyChanged(() => Cutting_Reverse_Info_1);
                }
            }
        }

        private string cutting_Reverse_Info_2;
        public string Cutting_Reserve_Info_2
        {
            get { return cutting_Reverse_Info_2; }
            set
            {
                if ( cutting_Reverse_Info_2 != value)
                {
                    cutting_Reverse_Info_2 = value;
                    RaisePropertyChanged(() => Cutting_Reserve_Info_2);
                }
            }
        }

        private string cutting_Reverse_Info_3;
        public string Cutting_Reserve_Info_3
        {
            get { return cutting_Reverse_Info_3; }
            set
            {
                if (cutting_Reverse_Info_3 != value)
                {
                    cutting_Reverse_Info_3 = value;
                    RaisePropertyChanged(() => Cutting_Reserve_Info_3);
                }
            }
        }

        private Nullable<double> beamspot;
        public Nullable<double> BEAMSPOT
        {
            get { return beamspot; }
            set
            {
                if (beamspot != value)
                {
                    beamspot = value;
                    RaisePropertyChanged(() => BEAMSPOT);
                }
            }
        }

        private Nullable<double> liftspot;
        public Nullable<double> LIFTDIST
        {
            get { return liftspot; }
            set
            {
                if (liftspot != value)
                {
                    liftspot = value;
                    RaisePropertyChanged(() => LIFTDIST);
                }
            }
        }


    }
}
