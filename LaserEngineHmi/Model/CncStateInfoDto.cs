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
    public class CncMessage : ViewModelBase
    {
        private short _type;
        public short Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged(() => Type);
                }
            }
        }

        private short _msg_No;
        public short Msg_No
        {
            get { return _msg_No; }
            set
            {
                if (_msg_No != value)
                {
                    _msg_No = value;
                    RaisePropertyChanged(() => Msg_No);
                }
            }
        }

        private string _alm_Msg;
        public string Alm_Msg
        {
            get { return _alm_Msg; }
            set
            {
                if (_alm_Msg != value)
                {
                    _alm_Msg = value;
                    RaisePropertyChanged(() => Alm_Msg);
                }
            }
        }

    }


    public class CncAlarm : ViewModelBase
    {
        private short _type;
        public short Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    RaisePropertyChanged(() => Type);
                }
            }
        }

        private int _alm_No;
        public int Alm_No
        {
            get { return _alm_No; }
            set
            {
                if (_alm_No != value)
                {
                    _alm_No = value;
                    RaisePropertyChanged(() => Alm_No);
                }
            }
        }

        private short _axis;
        public short Axis
        {
            get { return _axis; }
            set
            {
                if (_axis != value)
                {
                    _axis = value;
                    RaisePropertyChanged(() => Axis);
                }
            }
        }

        private string _alm_Msg;
        public string Alm_Msg
        {
            get { return _alm_Msg; }
            set
            {
                if (_alm_Msg != value)
                {
                    _alm_Msg = value;
                    RaisePropertyChanged(() => Alm_Msg);
                }
            }
        }


    }

    public class CncStateInfoDto : ViewModelBase
    {
        private int _cncState;
        public int CncState
        {
            get { return _cncState; }
            set
            {
                if (_cncState != value)
                {
                    _cncState = value;
                    RaisePropertyChanged(() => CncState);
                }
            }
        }

        private int _servoState;
        public int ServoState
        {
            get { return _servoState; }
            set
            {
                if (_servoState != value)
                {
                    _servoState = value;
                    RaisePropertyChanged(() => ServoState);
                }
            }
        }

        private int _laserState;
        public int LaserState
        {
            get { return _laserState; }
            set
            {
                if (_laserState != value)
                {
                    _laserState = value;
                    RaisePropertyChanged(() => LaserState);
                }
            }
        }

        private string _cncModeStateMode;
        public string CncModeState
        {
            get { return _cncModeStateMode; }
            set
            {
                if (_cncModeStateMode != value)
                {
                    _cncModeStateMode = value;
                    RaisePropertyChanged(() => CncModeState);
                }
            }
        }

        private string _cncRunState;
        public string CncRunState
        {
            get { return _cncRunState; }
            set
            {
                if (_cncRunState != value)
                {
                    _cncRunState = value;
                    RaisePropertyChanged(() => CncRunState);
                }
            }
        }

        private string _cncMotionState;
        public string CncMotionState
        {
            get { return _cncMotionState; }
            set
            {
                if (_cncMotionState != value)
                {
                    _cncMotionState = value;
                    RaisePropertyChanged(() => CncMotionState);
                }
            }
        }

        private string _cncMSTBState;
        public string CncMSTBState
        {
            get { return _cncMSTBState; }
            set
            {
                if (_cncMSTBState != value)
                {
                    _cncMSTBState = value;
                    RaisePropertyChanged(() => CncMSTBState);
                }
            }
        }

        private string _cncEmergState;
        public string CncEmergState
        {
            get { return _cncEmergState; }
            set
            {
                if (_cncEmergState != value)
                {
                    _cncEmergState = value;
                    RaisePropertyChanged(() => CncEmergState);
                }
            }
        }

        private string _cncAlarmState;
        public string CncAlarmState
        {
            get { return _cncAlarmState; }
            set
            {
                if (_cncAlarmState != value)
                {
                    _cncAlarmState = value;
                    RaisePropertyChanged(() => CncAlarmState);
                }
            }
        }

        private string _ProgramNum;
        public string ProgramNum
        {
            get { return _ProgramNum; }
            set
            {
                if (_ProgramNum != value)
                {
                    _ProgramNum = value;
                    RaisePropertyChanged(() => ProgramNum);
                }
            }
        }
        
        private string _BlockNum;
        public string BlockNum
        {
            get { return _BlockNum; }
            set
            {
                if (_BlockNum != value)
                {
                    _BlockNum = value;
                    RaisePropertyChanged(() => BlockNum);
                }
            }
        }

        private string _CycleTime;
        public string CycleTime
        {
            get { return _CycleTime; }
            set
            {
                if (_CycleTime != value)
                {
                    _CycleTime = value;
                    RaisePropertyChanged(() => CycleTime);
                }
            }
        }

        private string _CncAlarm;
        public string CncAlarm
        {
            get { return _CncAlarm; }
            set
            {
                if (_CncAlarm != value)
                {
                    _CncAlarm = value;
                    RaisePropertyChanged(() => CncAlarm);
                }
            }
        }

        private List<CncAlarm> _cncAlarmList = new List<CncAlarm>();
        public List<CncAlarm> CncAlarmList
        {
            get { return _cncAlarmList; }
            set
            {
                if (_cncAlarmList != value)
                {
                    _cncAlarmList = value;
                    RaisePropertyChanged(() => CncAlarmList);
                }
            }
        }
        

        private int _CncMessageFlag;
        public int CncMessageFlag
        {
            get { return _CncMessageFlag; }
            set
            {
                if (_CncMessageFlag != value)
                {
                    _CncMessageFlag = value;
                    RaisePropertyChanged(() => CncMessageFlag);
                }
            }
        }

        private List<CncMessage> _CncMessageList = new List<CncMessage>();
        public List<CncMessage> CncMessageList
        {
            get { return _CncMessageList; }
            set
            {
                if (_CncMessageList != value)
                {
                    _CncMessageList = value;
                    RaisePropertyChanged(() => CncMessageList);
                }
            }
        }

        private bool _LaserStartStatus;
        public bool LaserStartStatus
        {
            get { return _LaserStartStatus; }
            set
            {
                if (_LaserStartStatus != value)
                {
                    _LaserStartStatus = value;
                    RaisePropertyChanged(() => LaserStartStatus);
                }
            }
        }

        private bool _LaserAlarmStatus;
        public bool LaserAlarmStatus
        {
            get { return _LaserAlarmStatus; }
            set
            {
                if (_LaserAlarmStatus != value)
                {
                    _LaserAlarmStatus = value;
                    RaisePropertyChanged(() => LaserAlarmStatus);
                }
            }
        }

        private bool _WorkMode_Punch;
        public bool WorkMode_Punch
        {
            get { return _WorkMode_Punch; }
            set
            {
                if (_WorkMode_Punch != value)
                {
                    _WorkMode_Punch = value;
                    RaisePropertyChanged(() => WorkMode_Punch);
                }
            }
        }

        private bool _WorkMode_Laser;
        public bool WorkMode_Laser
        {
            get { return _WorkMode_Laser; }
            set
            {
                if (_WorkMode_Laser != value)
                {
                    _WorkMode_Laser = value;
                    RaisePropertyChanged(() => WorkMode_Laser);
                }
            }
        }

        private bool _LaserState_WaterTemperature;
        public bool LaserState_WaterTemperature
        {
            get { return _LaserState_WaterTemperature; }
            set
            {
                if (_LaserState_WaterTemperature != value)
                {
                    _LaserState_WaterTemperature = value;
                    RaisePropertyChanged(() => LaserState_WaterTemperature);
                }
            }
        }

        private bool _LaserState_LaserOK;
        public bool LaserState_LaserOK
        {
            get { return _LaserState_LaserOK; }
            set
            {
                if (_LaserState_LaserOK != value)
                {
                    _LaserState_LaserOK = value;
                    RaisePropertyChanged(() => LaserState_LaserOK);
                }
            }
        }

        private bool _LaserState_MicroPower;
        public bool LaserState_MicroPower
        {
            get { return _LaserState_MicroPower; }
            set
            {
                if (_LaserState_MicroPower != value)
                {
                    _LaserState_MicroPower = value;
                    RaisePropertyChanged(() => LaserState_MicroPower);
                }
            }
        }

        private bool _PuhchState_Single;
        public bool PuhchState_Single
        {
            get { return _PuhchState_Single; }
            set
            {
                if (_PuhchState_Single != value)
                {
                    _PuhchState_Single = value;
                    RaisePropertyChanged(() => PuhchState_Single);
                }
            }
        }

        private bool _PuhchState_Roll;
        public bool PuhchState_Roll
        {
            get { return _PuhchState_Roll; }
            set
            {
                if (_PuhchState_Roll != value)
                {
                    _PuhchState_Roll = value;
                    RaisePropertyChanged(() => PuhchState_Roll);
                }
            }
        }

        private bool _PuhchState_Mark;
        public bool PuhchState_Mark
        {
            get { return _PuhchState_Mark; }
            set
            {
                if (_PuhchState_Mark != value)
                {
                    _PuhchState_Mark = value;
                    RaisePropertyChanged(() => PuhchState_Mark);
                }
            }
        }

        private bool _PuhchState_Double;
        public bool PuhchState_Double
        {
            get { return _PuhchState_Double; }
            set
            {
                if (_PuhchState_Double != value)
                {
                    _PuhchState_Double = value;
                    RaisePropertyChanged(() => PuhchState_Double);
                }
            }
        }

        private bool _PuhchPos_Unknow;
        public bool PuhchPos_Unknow
        {
            get { return _PuhchPos_Unknow; }
            set
            {
                if (_PuhchPos_Unknow != value)
                {
                    _PuhchPos_Unknow = value;
                    RaisePropertyChanged(() => PuhchPos_Unknow);
                }
            }
        }

        private bool _PuhchPos_Change;
        public bool PuhchPos_Change
        {
            get { return _PuhchPos_Change; }
            set
            {
                if (_PuhchPos_Change != value)
                {
                    _PuhchPos_Change = value;
                    RaisePropertyChanged(() => PuhchPos_Change);
                }
            }
        }

        private bool _PuhchPos_UDC;
        public bool PuhchPos_UDC
        {
            get { return _PuhchPos_UDC; }
            set
            {
                if (_PuhchPos_UDC != value)
                {
                    _PuhchPos_UDC = value;
                    RaisePropertyChanged(() => PuhchPos_UDC);
                }
            }
        }

        private bool _PuhchPos_DDC;
        public bool PuhchPos_DDC
        {
            get { return _PuhchPos_DDC; }
            set
            {
                if (_PuhchPos_DDC != value)
                {
                    _PuhchPos_DDC = value;
                    RaisePropertyChanged(() => PuhchPos_DDC);
                }
            }
        }

        private bool _REF_X;
        public bool REF_X
        {
            get { return _REF_X; }
            set
            {
                if (_REF_X != value)
                {
                    _REF_X = value;
                    RaisePropertyChanged(() => REF_X);
                }
            }
        }

        private bool _REF_Y;
        public bool REF_Y
        {
            get { return _REF_Y; }
            set
            {
                if (_REF_Y != value)
                {
                    _REF_Y = value;
                    RaisePropertyChanged(() => REF_Y);
                }
            }
        }

        private bool _REF_T;
        public bool REF_T
        {
            get { return _REF_T; }
            set
            {
                if (_REF_T != value)
                {
                    _REF_T = value;
                    RaisePropertyChanged(() => REF_T);
                }
            }
        }

        private bool _REF_C;
        public bool REF_C
        {
            get { return _REF_C; }
            set
            {
                if (_REF_C != value)
                {
                    _REF_C = value;
                    RaisePropertyChanged(() => REF_C);
                }
            }
        }

        private bool _REF_Z;
        public bool REF_Z
        {
            get { return _REF_Z; }
            set
            {
                if (_REF_Z != value)
                {
                    _REF_Z = value;
                    RaisePropertyChanged(() => REF_Z);
                }
            }
        }

        private bool _REF_A;
        public bool REF_A
        {
            get { return _REF_A; }
            set
            {
                if (_REF_A != value)
                {
                    _REF_A = value;
                    RaisePropertyChanged(() => REF_A);
                }
            }
        }

        private bool _REF_B;
        public bool REF_B
        {
            get { return _REF_B; }
            set
            {
                if (_REF_B != value)
                {
                    _REF_B = value;
                    RaisePropertyChanged(() => REF_B);
                }
            }
        }
    }
}
