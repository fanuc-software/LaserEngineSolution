using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace DataCenter.Model
{
    public class MachiningLib_PiercingDto : ViewModelBase
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

        private short eNo;
        public short ENO
        {
            get { return eNo; }
            set
            {
                if (eNo != value)
                {
                    eNo = value;
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
            get
            {

                string temp = "";
                switch (ENO)
                {
                    case 101:
                        temp = "一级穿孔";
                        break;
                    case 102:
                        temp = "二级穿孔";
                        break;
                    case 103:
                        temp = "三级穿孔";
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

        private short piercing_Power;
        public short Piercing_Power
        {
            get { return piercing_Power; }
            set
            {
                if (piercing_Power != value)
                {
                    piercing_Power = value;
                    RaisePropertyChanged(() => Piercing_Power);
                }
            }
        }

        private short piercing_Freq;
        public short Piercing_Freq
        {
            get { return piercing_Freq; }
            set
            {
                if (piercing_Freq != value)
                {
                    piercing_Freq = value;
                    RaisePropertyChanged(() => Piercing_Freq);
                }
            }
        }

        private short piercing_Duty;
        public short Piercing_Duty
        {
            get { return piercing_Duty; }
            set
            {
                if (piercing_Duty != value)
                {
                    piercing_Duty = value;
                    RaisePropertyChanged(() => Piercing_Duty);
                }
            }
        }

        private short piercing_I_Freq;
        public short Piercing_I_Freq
        {
            get { return piercing_I_Freq; }
            set
            {
                if (piercing_I_Freq != value)
                {
                    piercing_I_Freq = value;
                    RaisePropertyChanged(() => Piercing_I_Freq);
                }
            }
        }

        private short piercing_I_Duty;
        public short Piercing_I_Duty
        {
            get { return piercing_I_Duty; }
            set
            {
                if (piercing_I_Duty != value)
                {
                    piercing_I_Duty = value;
                    RaisePropertyChanged(() => Piercing_I_Duty);
                }
            }
        }

        private double piercing_Step_T;
        public double Piercing_Step_T
        {
            get { return piercing_Step_T; }
            set
            {
                if (piercing_Step_T != value)
                {
                    piercing_Step_T = value;
                    RaisePropertyChanged(() => Piercing_Step_T);
                }
            }
        }

        private short piercing_Step_Sum;
        public short Piercing_Step_Sum
        {
            get { return piercing_Step_Sum; }
            set
            {
                if (piercing_Step_Sum != value)
                {
                    piercing_Step_Sum = value;
                    RaisePropertyChanged(() => Piercing_Step_Sum);
                }
            }
        }

        private double piercing_Pier_T;
        public double Piercing_Pier_T
        {
            get { return piercing_Pier_T; }
            set
            {
                if (piercing_Pier_T != value)
                {
                    piercing_Pier_T = value;
                    RaisePropertyChanged(() => Piercing_Pier_T);
                }
            }
        }

        private double piercing_G_Press;
        public double Piercing_G_Press
        {
            get { return piercing_G_Press; }
            set
            {
                if (piercing_G_Press != value)
                {
                    piercing_G_Press = value;
                    RaisePropertyChanged(() => Piercing_G_Press);
                }
            }
        }

        private short piercing_G_Kind;
        public short Piercing_G_Kind
        {
            get { return piercing_G_Kind; }
            set
            {
                if (piercing_G_Kind != value)
                {
                    piercing_G_Kind = value;
                    RaisePropertyChanged(() => Piercing_G_Kind);
                }
            }
        }

        public string StrPiercing_G_Kind
        {
            get
            {
                if (piercing_G_Kind == 0) return "空气";
                else if (piercing_G_Kind == 1) return "氧气";
                else if (piercing_G_Kind == 2) return "氮气";
                else return "未知";
            }

        }

        private double piercing_G_Time;
        public double Piercing_G_Time
        {
            get { return piercing_G_Time; }
            set
            {
                if (piercing_G_Time != value)
                {
                    piercing_G_Time = value;
                    RaisePropertyChanged(() => Piercing_G_Time);
                }
            }
        }

        private double piercing_Def_Pos;
        public double Piercing_Def_Pos
        {
            get { return piercing_Def_Pos; }
            set
            {
                if (piercing_Def_Pos != value)
                {
                    piercing_Def_Pos = value;
                    RaisePropertyChanged(() => Piercing_Def_Pos);
                }
            }
        }

        private double piercing_Def_Pos2;
        public double Piercing_Def_Pos2
        {
            get { return piercing_Def_Pos2; }
            set
            {
                if (piercing_Def_Pos2 != value)
                {
                    piercing_Def_Pos2 = value;
                    RaisePropertyChanged(() => Piercing_Def_Pos2);
                }
            }
        }

        private string piercing_Gap_Axis;
        public string Piercing_Gap_Axis
        {
            get { return piercing_Gap_Axis; }
            set
            {
                if (piercing_Gap_Axis != value)
                {
                    piercing_Gap_Axis = value;
                    RaisePropertyChanged(() => Piercing_Gap_Axis);
                }
            }
        }

        private string piercing_Def_Pos2_Dec;
        public string Piercing_Def_Pos2_Dec
        {
            get { return piercing_Def_Pos2_Dec; }
            set
            {
                if (piercing_Def_Pos2_Dec != value)
                {
                    piercing_Def_Pos2_Dec = value;
                    RaisePropertyChanged(() => Piercing_Def_Pos2_Dec);
                }
            }
        }

        private Nullable<short> piercing_Reserve;
        public Nullable<short> Piercing_Reserve
        {
            get { return piercing_Reserve; }
            set
            {
                if (piercing_Reserve != value)
                {
                    piercing_Reserve = value;
                    RaisePropertyChanged(() => Piercing_Reserve);
                }
            }
        }

        private string piercing_Reverse_Info_1;
        public string Piercing_Reserve_Info_1
        {
            get { return piercing_Reverse_Info_1; }
            set
            {
                if (piercing_Reverse_Info_1 != value)
                {
                    piercing_Reverse_Info_1 = value;
                    RaisePropertyChanged(() => Piercing_Reserve_Info_1);
                }
            }
        }

        private string piercing_Reverse_Info_2;
        public string Piercing_Reserve_Info_2
        {
            get { return piercing_Reverse_Info_2; }
            set
            {
                if (piercing_Reverse_Info_2 != value)
                {
                    piercing_Reverse_Info_2 = value;
                    RaisePropertyChanged(() => Piercing_Reserve_Info_2);
                }
            }
        }

        private string piercing_Reverse_Info_3;
        public string Piercing_Reserve_Info_3
        {
            get { return piercing_Reverse_Info_3; }
            set
            {
                if (piercing_Reverse_Info_3 != value)
                {
                    piercing_Reverse_Info_3 = value;
                    RaisePropertyChanged(() => Piercing_Reserve_Info_3);
                }
            }
        }

    }
}
