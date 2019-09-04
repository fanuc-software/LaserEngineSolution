using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucCnc
{
    public class CncStateInfo
    {
        public int CncState { get; set; }

        public int LaserState { get; set; }

        public int ServoState { get; set; }

        public string CncModeState { get; set; }
        public string CncRunState { get; set; }
        public string CncMotionState { get; set; }
        public string CncMSTBState { get; set; }
        public string CncEmergState { get; set; }
        public string CncAlarmState { get; set; }

        public string ProgramNum { get; set; }

        public string BlockNum { get; set; }

        public string CycleTime { get; set; }

        public string CncAlarm { get; set; }

        

        private List<CncAlarm> _CncAlarmList = new List<CncAlarm>();
        public List<CncAlarm> CncAlarmList
        {
            get { return _CncAlarmList; }
            set
            {
                _CncAlarmList = value;
            }
        }

        public int CncMessageFlag { get; set; }

        private List<CncMessage> _CncMessageList = new List<CncMessage>();
        public List<CncMessage> CncMessageList
        {
            get { return _CncMessageList; }
            set
            {
                _CncMessageList = value;
            }
        }

        public bool LaserStartStatus { get; set; }

        public bool LaserAlarmStatus { get; set; }


        public bool WorkMode_Punch { get; set; }
        public bool WorkMode_Laser { get; set; }
        public bool LaserState_WaterTemperature { get; set; }
        public bool LaserState_LaserOK { get; set; }
        public bool LaserState_MicroPower { get; set; }
        public bool PuhchState_Single { get; set; }
        public bool PuhchState_Roll { get; set; }
        public bool PuhchState_Mark { get; set; }
        public bool PuhchState_Double { get; set; }
        public bool PuhchPos_Unknow { get; set; }
        public bool PuhchPos_Change { get; set; }
        public bool PuhchPos_UDC { get; set; }
        public bool PuhchPos_DDC { get; set; }
        public bool REF_X { get; set; }
        public bool REF_Y { get; set; }
        public bool REF_T { get; set; }
        public bool REF_C { get; set; }
        public bool REF_Z { get; set; }
        public bool REF_A { get; set; }
        public bool REF_B { get; set; }
    }

    public class CncAlarm
    {
        public short Type { get; set; }
        public int Alm_No { get; set; }
        public short Axis { get; set; }
        public string Alm_Msg { get; set; }

    }

    public class CncMessage
    {
        public short Type { get; set; }
        public short Msg_No { get; set; }
        public string Alm_Msg { get; set; }

    }
}
