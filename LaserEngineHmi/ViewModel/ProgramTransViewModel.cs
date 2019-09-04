using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using LaserEngineHmi.View;

namespace LaserEngineHmi.ViewModel
{
    public class ProgramTransViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;
        
        public ICommand SelectNcFolderCommand { get; set; }
        public ICommand ChangePcProgramRootCommand { get; set; }
        public ICommand RefreshPcProgramCommand { get; set; }
        public ICommand DeletePcProgramCommand{ get; set; }
        public ICommand RefreshNcProgramCommand { get; set; }
        public ICommand DeleteNcProgramCommand { get; set; }
        public ICommand UploadProgramFromCncToPcCommand { get; set; }
        public ICommand DowloadProgramFromPcToCncCommand { get; set; }

        public ICommand SetMainProgramCommand { get; set; }

        public ICommand OpenPcProgramCommand { get; set; }

        #region 属性
        private string m_PcProgramRoot;
        public string PcProgramRoot
        {
            get { return m_PcProgramRoot; }
            set
            {
                if (m_PcProgramRoot != value)
                {
                    m_PcProgramRoot = value;
                    RaisePropertyChanged(() => PcProgramRoot);
                    GetPcPrograms(m_PcProgramRoot);
                }
            }
        }

        private ObservableCollection<PcProgramDto> m_pcPrograms = new ObservableCollection<PcProgramDto>();
        public ObservableCollection<PcProgramDto> PcPrograms
        {
            get { return m_pcPrograms; }
            set
            {
                if (m_pcPrograms != value)
                {
                    m_pcPrograms = value;
                    RaisePropertyChanged(() => PcPrograms);
                }
            }
        }

        private PcProgramDto m_selPcProgram = new PcProgramDto();
        public PcProgramDto SelPcProgram
        {
            get { return m_selPcProgram; }
            set
            {
                if (m_selPcProgram != value)
                {
                    m_selPcProgram = value;
                    RaisePropertyChanged(() => SelPcProgram);
                }
            }
        }

        private string m_NcProgramRoot;
        public string NcProgramRoot
        {
            get { return m_NcProgramRoot; }
            set
            {
                if (m_NcProgramRoot != value)
                {
                    m_NcProgramRoot = value;
                    RaisePropertyChanged(() => NcProgramRoot);
                    GetNcPrograms(m_NcProgramRoot);
                }
            }
        }

        private ObservableCollection<NcProgramDto> m_NcPrograms = new ObservableCollection<NcProgramDto>();
        public ObservableCollection<NcProgramDto> NcPrograms
        {
            get { return m_NcPrograms; }
            set
            {
                if (m_NcPrograms != value)
                {
                    m_NcPrograms = value;
                    RaisePropertyChanged(() => NcPrograms);
                }
            }
        }

        private NcProgramDto m_selNcProgram = new NcProgramDto();
        public NcProgramDto SelNcProgram
        {
            get { return m_selNcProgram; }
            set
            {
                if (m_selNcProgram != value)
                {
                    m_selNcProgram = value;
                    RaisePropertyChanged(() => SelNcProgram);
                }
            }
        }

        #endregion

        #region ctor
        public ProgramTransViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            SelectNcFolderCommand = new RelayCommand(OnSelectNcFolder);
            ChangePcProgramRootCommand = new RelayCommand(OnChangePcProgramRoot);
            RefreshPcProgramCommand = new RelayCommand(OnRefreshPcProgram);
            DeletePcProgramCommand = new RelayCommand(OnDeletePcProgram);
            RefreshNcProgramCommand = new RelayCommand(OnRefreshNcProgram);
            DeleteNcProgramCommand = new RelayCommand(OnDeleteNcProgram);
            UploadProgramFromCncToPcCommand = new RelayCommand(OnUploadProgramFromCncToPc);
            DowloadProgramFromPcToCncCommand = new RelayCommand(OnDowloadProgramFromPcToCnc);
            SetMainProgramCommand = new RelayCommand(OnSetMainProgram);
            OpenPcProgramCommand = new RelayCommand(OnOpenPcProgram);
            
            PcProgramRoot = @"D:\";
            

            Messenger.Default.Register<NcFolderDto>(this, "NcProgramFolderMsg", msg =>
            {
                NcProgramRoot = msg.Path;
            });

            NcProgramRoot = "//CNC_MEM/USER/PATH1/";
        }

        #endregion

        #region command
        private void OnChangePcProgramRoot()
        {
            System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK || dlg.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                var last_c = dlg.SelectedPath.Substring(dlg.SelectedPath.Length - 1, 1);
                if (last_c != @"\") PcProgramRoot = dlg.SelectedPath + @"\";
                else PcProgramRoot = dlg.SelectedPath;
            }
        }

        private void OnRefreshPcProgram()
        {
            GetPcPrograms(PcProgramRoot);
        }

        private void OnDeletePcProgram()
        {
            try
            {
                if (File.Exists(SelPcProgram.Path))
                    File.Delete(SelPcProgram.Path);
                GetPcPrograms(PcProgramRoot);
            }
            catch (Exception ex)
            {
            }
        }

        private void OnRefreshNcProgram()
        {
            GetNcPrograms(NcProgramRoot);
        }

        private void OnDeleteNcProgram()
        {
            DelNcPrograms();
            GetNcPrograms(NcProgramRoot);
        }

        private void OnUploadProgramFromCncToPc()
        {
            _fanuc.UpLoadNcProgramFromCncToPc(PcProgramRoot+SelNcProgram.Name, SelNcProgram.Path, true);
            GetPcPrograms(PcProgramRoot);
        }

        private void OnDowloadProgramFromPcToCnc()
        {
            _fanuc.DownLoadNcProgramFromPcToCnc(SelPcProgram.Path, NcProgramRoot, true);
            GetNcPrograms(NcProgramRoot);
        }

        private void OnSetMainProgram()
        {
            if(SelNcProgram == null)
            {
                Messenger.Default.Send<string>("请选择CNC加工程序", "OperateNotice");
                return;
            }
            var ret = _fanuc.SetMainProgram(NcProgramRoot + "/" + SelNcProgram.Name);

            if (ret == 12)
            {
                Messenger.Default.Send<string>("设定主程序失败,请切换至EDIT方式", "OperateNotice");
                return;
            }
            if (ret !=0)
            {
                Messenger.Default.Send<string>("设定主程序失败,返回:"+ret.ToString(), "OperateNotice");
                return;
            }

        }

        private void OnOpenPcProgram()
        {
            if (SelPcProgram == null)
            {
                Messenger.Default.Send<string>("请选择PC加工程序", "OperateNotice");
                return;
            }

            try
            {
                System.Diagnostics.Process.Start(@"Notepad.exe", SelPcProgram.Path);
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<string>("打开PC加工程序失败", "OperateNotice");
            }
        }

        private void OnSelectNcFolder()
        {
            var win = new NcFolderSelectionWindow();
            win.ShowDialog();
        }

        #endregion

        #region private
        private void GetPcPrograms(string root)
        {
            try
            {
                //var files = Directory.GetFiles(root, "*.*", SearchOption.TopDirectoryOnly)
                //.Where(s => s.EndsWith(".nc") || s.EndsWith(".NC") || s.EndsWith(".MPF") || s.EndsWith(".mpf") || s.EndsWith(".TXT") || s.EndsWith(".txt"));

                var files = Directory.GetFiles(root, "*.*", SearchOption.TopDirectoryOnly);

                PcPrograms.Clear();
                foreach (string f in files)
                {
                    PcProgramDto pf = new PcProgramDto();
                    pf.Name = System.IO.Path.GetFileName(f);
                    pf.Path = f;
                    PcPrograms.Add(pf);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void GetNcPrograms(string root)
        {
            ObservableCollection<NcProgram> progs = new ObservableCollection<NcProgram>();
            short ret = _fanuc.GetPrograms(root, ref progs);

            NcPrograms=_mapper.Map<ObservableCollection<NcProgram>, ObservableCollection<NcProgramDto>>(progs);
        }

        private void DelNcPrograms()
        {
            short ret = _fanuc.DeleteNcProgram2(SelNcProgram.Path);
            
        }

        #endregion
    }
}
