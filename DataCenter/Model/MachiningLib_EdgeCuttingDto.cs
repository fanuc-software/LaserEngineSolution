using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace DataCenter.Model
{
    public class MachiningLib_EdgeCuttingDto : ViewModelBase
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
        public short NO
        {
            get { return eNo; }
            set
            {
                if (eNo != value)
                {
                    eNo = value;
                    RaisePropertyChanged(() => NO);
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

        private double edgeCutting_Angle;
        public double EdgeCutting_Angle
        {
            get { return edgeCutting_Angle; }
            set
            {
                if (edgeCutting_Angle != value)
                {
                    edgeCutting_Angle = value;
                    RaisePropertyChanged(() => EdgeCutting_Angle);
                }
            }
        }

        private short edgeCutting_Power;
        public short EdgeCutting_Power
        {
            get { return edgeCutting_Power; }
            set
            {
                if (edgeCutting_Power != value)
                {
                    edgeCutting_Power = value;
                    RaisePropertyChanged(() => EdgeCutting_Power);
                }
            }
        }

        private short edgeCutting_Freq;
        public short EdgeCutting_Freq
        {
            get { return edgeCutting_Freq; }
            set
            {
                if (edgeCutting_Freq != value)
                {
                    edgeCutting_Freq = value;
                    RaisePropertyChanged(() => EdgeCutting_Freq);
                }
            }
        }

        private short edgeCutting_Duty;
        public short EdgeCutting_Duty
        {
            get { return edgeCutting_Duty; }
            set
            {
                if (edgeCutting_Duty != value)
                {
                    edgeCutting_Duty = value;
                    RaisePropertyChanged(() => EdgeCutting_Duty);
                }
            }
        }

        private double edgeCutting_Pier_T;
        public double EdgeCutting_Pier_T
        {
            get { return edgeCutting_Pier_T; }
            set
            {
                if (edgeCutting_Pier_T != value)
                {
                    edgeCutting_Pier_T = value;
                    RaisePropertyChanged(() => EdgeCutting_Pier_T);
                }
            }
        }

        private double edgeCutting_G_Press;
        public double EdgeCutting_G_Press
        {
            get { return edgeCutting_G_Press; }
            set
            {
                if (edgeCutting_G_Press != value)
                {
                    edgeCutting_G_Press = value;
                    RaisePropertyChanged(() => EdgeCutting_G_Press);
                }
            }
        }

        private short edgeCutting_G_Kind;
        public short EdgeCutting_G_Kind
        {
            get { return edgeCutting_G_Kind; }
            set
            {
                if (edgeCutting_G_Kind != value)
                {
                    edgeCutting_G_Kind = value;
                    RaisePropertyChanged(() => EdgeCutting_G_Kind);
                }
            }
        }

        public string StrEdgeCutting_G_Kind
        {
            get
            {
                if (edgeCutting_G_Kind == 0) return "空气";
                else if (edgeCutting_G_Kind == 1) return "氧气";
                else if (edgeCutting_G_Kind == 2) return "氮气";
                else return "未知";
            }

        }

        private double edgeCutting_R_Len;
        public double EdgeCutting_R_Len
        {
            get { return edgeCutting_R_Len; }
            set
            {
                if (edgeCutting_R_Len != value)
                {
                    edgeCutting_R_Len = value;
                    RaisePropertyChanged(() => EdgeCutting_R_Len);
                }
            }
        }

        private double edgeCutting_R_Feed;
        public double EdgeCutting_R_Feed
        {
            get { return edgeCutting_R_Feed; }
            set
            {
                if (edgeCutting_R_Feed != value)
                {
                    edgeCutting_R_Feed = value;
                    RaisePropertyChanged(() => EdgeCutting_R_Feed);
                }
            }
        }

        private short edgeCutting_R_Freq;
        public short EdgeCutting_R_Freq
        {
            get { return edgeCutting_R_Freq; }
            set
            {
                if (edgeCutting_R_Freq != value)
                {
                    edgeCutting_R_Freq = value;
                    RaisePropertyChanged(() => EdgeCutting_R_Freq);
                }
            }
        }

        private short edgeCutting_R_Duty;
        public short EdgeCutting_R_Duty
        {
            get { return edgeCutting_R_Duty; }
            set
            {
                if (edgeCutting_R_Duty != value)
                {
                    edgeCutting_R_Duty = value;
                    RaisePropertyChanged(() => EdgeCutting_R_Duty);
                }
            }
        }

        private double edgeCutting_Gap;
        public double EdgeCutting_Gap
        {
            get { return edgeCutting_Gap; }
            set
            {
                if (edgeCutting_Gap != value)
                {
                    edgeCutting_Gap = value;
                    RaisePropertyChanged(() => EdgeCutting_Gap);
                }
            }
        }

        private Nullable<short> edgeCutting_Reserve_1;
        public Nullable<short> EdgeCutting_Reserve_1
        {
            get { return edgeCutting_Reserve_1; }
            set
            {
                if (edgeCutting_Reserve_1 != value)
                {
                    edgeCutting_Reserve_1 = value;
                    RaisePropertyChanged(() => EdgeCutting_Reserve_1);
                }
            }
        }

        private Nullable<short> edgeCutting_Reserve_2;
        public Nullable<short> EdgeCutting_Reserve_2
        {
            get { return edgeCutting_Reserve_2; }
            set
            {
                if (edgeCutting_Reserve_2 != value)
                {
                    edgeCutting_Reserve_2 = value;
                    RaisePropertyChanged(() => EdgeCutting_Reserve_2);
                }
            }
        }

        private Nullable<short> edgeCutting_Reserve_3;
        public Nullable<short> EdgeCutting_Reserve_3
        {
            get { return edgeCutting_Reserve_3; }
            set
            {
                if (edgeCutting_Reserve_3 != value)
                {
                    edgeCutting_Reserve_3 = value;
                    RaisePropertyChanged(() => EdgeCutting_Reserve_3);
                }
            }
        }

        private Nullable<short> edgeCutting_Reserve_4;
        public Nullable<short> EdgeCutting_Reserve_4
        {
            get { return edgeCutting_Reserve_4; }
            set
            {
                if (edgeCutting_Reserve_4 != value)
                {
                    edgeCutting_Reserve_4 = value;
                    RaisePropertyChanged(() => EdgeCutting_Reserve_4);
                }
            }
        }

        private string edgeCutting_Reverse_Info_1;
        public string EdgeCutting_Reverse_Info_1
        {
            get { return edgeCutting_Reverse_Info_1; }
            set
            {
                if (edgeCutting_Reverse_Info_1 != value)
                {
                    edgeCutting_Reverse_Info_1 = value;
                    RaisePropertyChanged(() => EdgeCutting_Reverse_Info_1);
                }
            }
        }

        private string edgeCutting_Reverse_Info_2;
        public string EdgeCutting_Reverse_Info_2
        {
            get { return edgeCutting_Reverse_Info_2; }
            set
            {
                if (edgeCutting_Reverse_Info_2 != value)
                {
                    edgeCutting_Reverse_Info_2 = value;
                    RaisePropertyChanged(() => EdgeCutting_Reverse_Info_2);
                }
            }
        }

        private string edgeCutting_Reverse_Info_3;
        public string EdgeCutting_Reverse_Info_3
        {
            get { return edgeCutting_Reverse_Info_3; }
            set
            {
                if (edgeCutting_Reverse_Info_3 != value)
                {
                    edgeCutting_Reverse_Info_3 = value;
                    RaisePropertyChanged(() => EdgeCutting_Reverse_Info_3);
                }
            }
        }

    }
}
