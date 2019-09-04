using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using FanucCnc;
using LaserEngineHmi.Model;

namespace LaserEngineHmi.ViewModel
{
    public class CutCenterViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        #region 属性
        private CncStateInfoDto m_CncStateInfo = new CncStateInfoDto();
        public CncStateInfoDto CncStateInfo
        {
            get { return m_CncStateInfo; }
            set
            {
                if (m_CncStateInfo != value)
                {
                    m_CncStateInfo = value;
                    RaisePropertyChanged(() => CncStateInfo);
                }
            }
        }

        private double m_PC = new double();
        public double PC
        {
            get { return m_PC; }
            set
            {
                if (m_PC != value)
                {

                    var ret = _fanuc.CutterCenter_SET_PC(value);
                    if (ret != 0)
                    {

                        PC = m_PC;
                        return;
                    }
                    m_PC = value;
                    RaisePropertyChanged(() => PC);
                }
            }
        }

        private double m_FR = new double();
        public double FR
        {
            get { return m_FR; }
            set
            {
                if (m_FR != value)
                {

                    var ret = _fanuc.CutterCenter_SET_FR(value);
                    if (ret != 0)
                    {

                        FR = m_FR;
                        return;
                    }
                    m_FR = value;
                    RaisePropertyChanged(() => FR);
                }
            }
        }

        private double m_DU = new double();
        public double DU
        {
            get { return m_DU; }
            set
            {
                if (m_DU != value)
                {

                    var ret = _fanuc.CutterCenter_SET_DU(value);
                    if (ret != 0)
                    {

                        DU = m_DU;
                        return;
                    }
                    m_DU = value;
                    RaisePropertyChanged(() => DU);
                }
            }
        }

        private double m_TIME = new double();
        public double TIME
        {
            get { return m_TIME; }
            set
            {
                if (m_TIME != value)
                {

                    var ret = _fanuc.CutterCenter_SET_TIME(value);
                    if (ret != 0)
                    {

                        TIME = m_TIME;
                        return;
                    }
                    m_TIME = value;
                    RaisePropertyChanged(() => TIME);
                }
            }
        }

        private bool m_LASERSTATUS;
        public bool LASERSTATUS
        {
            get { return m_LASERSTATUS; }
        }

        private bool m_LASERALARM;
        public bool LASERALARM
        {
            get { return m_LASERALARM; }
        }

        #endregion



        private ICommand StartCommand { get; set; }

        #region ctor
        public CutCenterViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            double temp = 0;
            _fanuc.CutterCenter_GET_PC(ref temp);
            PC = temp;
            _fanuc.CutterCenter_GET_FR(ref temp);
            FR = temp;
            _fanuc.CutterCenter_GET_DU(ref temp);
            DU = temp;
            _fanuc.CutterCenter_GET_TIME(ref temp);
            TIME = temp;

            Messenger.Default.Register<CncStateInfo>(this, "CncStateMsg", msg =>
            {
                CncStateInfo = _mapper.Map<CncStateInfo, CncStateInfoDto>(msg);
            });

            StartCommand = new RelayCommand(OnStart);

        }

        #endregion

        private void OnStart()
        {
            var ret =_fanuc.CutterCenter_Start();

            if (ret != 0)
            {
                Messenger.Default.Send<string>("程序调用失败，请检查操作方式", "OperateNotice");
            }
        }
    }
}
