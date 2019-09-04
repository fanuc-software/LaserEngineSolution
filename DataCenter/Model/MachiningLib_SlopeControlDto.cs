using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace DataCenter.Model
{
    public class MachiningLib_SlopeControlDto : ViewModelBase
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

        public string StrSlopeControl_G_Kind
        {
            get
            {
                if (slopeControl_Reserve_2 == 0) return "空气";
                else if (slopeControl_Reserve_2 == 1) return "氧气";
                else if (slopeControl_Reserve_2 == 2) return "氮气";
                else return "未知";
            }

        }

        private short slopeControl_PowerMin;
        public short SlopeControl_PowerMin
        {
            get { return slopeControl_PowerMin; }
            set
            {
                if (slopeControl_PowerMin != value)
                {
                    slopeControl_PowerMin = value;
                    RaisePropertyChanged(() => SlopeControl_PowerMin);
                }
            }
        }

        private short slopeControl_PwrSpZr;
        public short SlopeControl_PwrSpZr
        {
            get { return slopeControl_PwrSpZr; }
            set
            {
                if (slopeControl_PwrSpZr != value)
                {
                    slopeControl_PwrSpZr = value;
                    RaisePropertyChanged(() => SlopeControl_PwrSpZr);
                }
            }
        }

        private short slopeControl_FreqMin;
        public short SlopeControl_FreqMin
        {
            get { return slopeControl_FreqMin; }
            set
            {
                if (slopeControl_FreqMin != value)
                {
                    slopeControl_FreqMin = value;
                    RaisePropertyChanged(() => SlopeControl_FreqMin);
                }
            }
        }

        private short slopeControl_FreqSpZr;
        public short SlopeControl_FreqSpZr
        {
            get { return slopeControl_FreqSpZr; }
            set
            {
                if (slopeControl_FreqSpZr != value)
                {
                    slopeControl_FreqSpZr = value;
                    RaisePropertyChanged(() => SlopeControl_FreqSpZr);
                }
            }
        }

        private short slopeControl_DutyMin;
        public short SlopeControl_DutyMin
        {
            get { return slopeControl_DutyMin; }
            set
            {
                if (slopeControl_DutyMin != value)
                {
                    slopeControl_DutyMin = value;
                    RaisePropertyChanged(() => SlopeControl_DutyMin);
                }
            }
        }

        private short slopeControl_DutySpZr;
        public short SlopeControl_DutySpZr
        {
            get { return slopeControl_DutySpZr; }
            set
            {
                if (slopeControl_DutySpZr != value)
                {
                    slopeControl_DutySpZr = value;
                    RaisePropertyChanged(() => SlopeControl_DutySpZr);
                }
            }
        }

        private short slopeControl_FeedRDec;
        public short SlopeControl_FeedRDec
        {
            get { return slopeControl_FeedRDec; }
            set
            {
                if (slopeControl_FeedRDec != value)
                {
                    slopeControl_FeedRDec = value;
                    RaisePropertyChanged(() => SlopeControl_FeedRDec);
                }
            }
        }
        private double slopeControl_FeedR;
        public double SlopeControl_FeedR
        {
            get { return slopeControl_FeedR; }
            set
            {
                if (slopeControl_FeedR != value)
                {
                    slopeControl_FeedR = value;
                    RaisePropertyChanged(() => SlopeControl_FeedR);
                }
            }
        }
        
        private Nullable<short> slopeControl_Reserve_1;
        public Nullable<short> SlopeControl_Reserve_1
        {
            get { return slopeControl_Reserve_1; }
            set
            {
                if (slopeControl_Reserve_1 != value)
                {
                    slopeControl_Reserve_1 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_1);
                }
            }
        }

        private Nullable<short> slopeControl_Reserve_2;
        public Nullable<short> SlopeControl_Reserve_2
        {
            get { return slopeControl_Reserve_2; }
            set
            {
                if (slopeControl_Reserve_2 != value)
                {
                    slopeControl_Reserve_2 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_2);
                }
            }
        }

        private Nullable<short> slopeControl_Reserve_3;
        public Nullable<short> SlopeControl_Reserve_3
        {
            get { return slopeControl_Reserve_3; }
            set
            {
                if (slopeControl_Reserve_3 != value)
                {
                    slopeControl_Reserve_3 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_3);
                }
            }
        }

        private Nullable<short> slopeControl_Reserve_4;
        public Nullable<short> SlopeControl_Reserve_4
        {
            get { return slopeControl_Reserve_4; }
            set
            {
                if (slopeControl_Reserve_4 != value)
                {
                    slopeControl_Reserve_4 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_4);
                }
            }
        }

        private Nullable<short> slopeControl_Reserve_5;
        public Nullable<short> SlopeControl_Reserve_5
        {
            get { return slopeControl_Reserve_5; }
            set
            {
                if (slopeControl_Reserve_5 != value)
                {
                    slopeControl_Reserve_5 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_5);
                }
            }
        }

        private Nullable<short> slopeControl_Reserve_6;
        public Nullable<short> SlopeControl_Reserve_6
        {
            get { return slopeControl_Reserve_6; }
            set
            {
                if (slopeControl_Reserve_6 != value)
                {
                    slopeControl_Reserve_6 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_6);
                }
            }
        }

        private Nullable<short> slopeControl_Reserve_7;
        public Nullable<short> SlopeControl_Reserve_7
        {
            get { return slopeControl_Reserve_7; }
            set
            {
                if (slopeControl_Reserve_7 != value)
                {
                    slopeControl_Reserve_7 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_7);
                }
            }
        }

        private Nullable<short> slopeControl_Reserve_8;
        public Nullable<short> SlopeControl_Reserve_8
        {
            get { return slopeControl_Reserve_8; }
            set
            {
                if (slopeControl_Reserve_8 != value)
                {
                    slopeControl_Reserve_8 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_8);
                }
            }
        }

        private Nullable<short> slopeControl_Reserve_9;
        public Nullable<short> SlopeControl_Reserve_9
        {
            get { return slopeControl_Reserve_9; }
            set
            {
                if (slopeControl_Reserve_9 != value)
                {
                    slopeControl_Reserve_9 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_9);
                }
            }
        }

        private Nullable<short> slopeControl_Reserve_10;
        public Nullable<short> SlopeControl_Reserve_10
        {
            get { return slopeControl_Reserve_10; }
            set
            {
                if (slopeControl_Reserve_10 != value)
                {
                    slopeControl_Reserve_10 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_10);
                }
            }
        }

        private string slopeControl_Reserve_Info_1;
        public string SlopeControl_Reserve_Info_1
        {
            get { return slopeControl_Reserve_Info_1; }
            set
            {
                if (slopeControl_Reserve_Info_1 != value)
                {
                    slopeControl_Reserve_Info_1 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_Info_1);
                }
            }
        }

        private string slopeControl_Reserve_Info_2;
        public string SlopeControl_Reserve_Info_2
        {
            get { return slopeControl_Reserve_Info_2; }
            set
            {
                if (slopeControl_Reserve_Info_2 != value)
                {
                    slopeControl_Reserve_Info_2 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_Info_1);
                }
            }
        }

        private string slopeControl_Reserve_Info_3;
        public string SlopeControl_Reserve_Info_3
        {
            get { return slopeControl_Reserve_Info_3; }
            set
            {
                if (slopeControl_Reserve_Info_3 != value)
                {
                    slopeControl_Reserve_Info_3 = value;
                    RaisePropertyChanged(() => SlopeControl_Reserve_Info_3);
                }
            }
        }

       


    }
}
