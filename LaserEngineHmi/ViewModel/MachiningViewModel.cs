using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using LaserEngineHmi.View;
using DataCenter.Services;
using DataCenter.Model;
using ConfigCenter;
using FanucCnc;
using AutoMapper;
using DataCenter.Entities;

namespace LaserEngineHmi.ViewModel
{
    public class MachiningViewModel : ViewModelBase
    {
       

        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }

        public ICommand _SendToCncCmd { get; set; }

        public ICommand _Material_Changed_Command { get; set; }

        public ICommand AddMatrialCommand { get; set; }

        public ICommand DelMatrialCommand { get; set; }



        #region properties
        private MachiningLibService m_mchiningSrv;
        private Fanuc _fanuc;
        private IMapper _mapper;

        private Page m_MachiningLibContent;
        public Page _MachiningLib_Content
        {
            get { return m_MachiningLibContent; }
            set
            {
                if (m_MachiningLibContent != value)
                {
                    m_MachiningLibContent = value;
                    RaisePropertyChanged(() => _MachiningLib_Content);
                }
            }
        }

        private string laserType;
        public string _LaserType
        {
            get { return laserType; }
            set
            {
                if (laserType != value)
                {
                    laserType = value;
                    RaisePropertyChanged(() => _LaserType);
                }
            }
        }

        private string cutterType;
        public string _CutterType
        {
            get { return cutterType; }
            set
            {
                if (cutterType != value)
                {
                    cutterType = value;
                    RaisePropertyChanged(() => _CutterType);
                }
            }
        }

        private double cutterDiameter;
        public double _CutterDiameter
        {
            get { return cutterDiameter; }
            set
            {
                if (cutterDiameter != value)
                {
                    cutterDiameter = value;
                    RaisePropertyChanged(() => _CutterDiameter);
                }
            }
        }


        private short g_Kind;
        public short _G_Kind
        {
            get { return g_Kind; }
            set
            {
                if (g_Kind != value)
                {
                    g_Kind = value;
                    RaisePropertyChanged(() => _G_Kind);
                }
            }
        }


        private string opticalType;
        public string _OpticalType
        {
            get { return opticalType; }
            set
            {
                if (opticalType != value)
                {
                    opticalType = value;
                    RaisePropertyChanged(() => _OpticalType);
                }
            }
        }

        private ObservableCollection<string> materialNames;
        public ObservableCollection<string> _MaterialNames
        {
            get { return materialNames; }
            set
            {
                if (materialNames != value)
                {
                    materialNames = value;
                    RaisePropertyChanged(() => _MaterialNames);
                }
            }
        }

        private ObservableCollection<MachiningLib_MaterialDto> materialDtos=new ObservableCollection<MachiningLib_MaterialDto>();
        public ObservableCollection<MachiningLib_MaterialDto> _MaterialDtos
        {
            get { return materialDtos; }
            set
            {
                if (materialDtos != value)
                {
                    materialDtos = value;
                    RaisePropertyChanged(() => _MaterialDtos);
                }
            }
        }

        private string selectedMaterialName;
        public string _SelectedMaterialName
        {
            get { return selectedMaterialName; }
            set
            {
                if (selectedMaterialName != value)
                {
                    selectedMaterialName = value;
                    RaisePropertyChanged(() => _SelectedMaterialName);
                }
            }
        }

        private MachiningLib_MaterialDto selectedMaterial;
        public MachiningLib_MaterialDto _SelectedMaterial
        {
            get { return selectedMaterial; }
            set
            {
                if (selectedMaterial != value)
                {
                    selectedMaterial = value;
                    RaisePropertyChanged(() => _SelectedMaterial);
                }
            }
        }

        private object oUpload = new object();

        private bool uploadEnable;
        public bool _UploadEnable
        {
            get { return uploadEnable; }
            set
            {
                if (uploadEnable != value)
                {
                    uploadEnable = value;
                    RaisePropertyChanged(() => _UploadEnable);
                }
            }
        }

        private object oSearch = new object();

        private bool searchEnable;
        public bool _SearchEnable
        {
            get { return searchEnable; }
            set
            {
                if (searchEnable != value)
                {
                    searchEnable = value;
                    RaisePropertyChanged(() => _SearchEnable);
                }
            }
        }

        private ObservableCollection<MachiningLib_CuttingDto> cuttingDtos=new ObservableCollection<MachiningLib_CuttingDto>();
        public ObservableCollection<MachiningLib_CuttingDto> _CuttingDtos
        {
            get { return cuttingDtos; }
            set
            {
                if (cuttingDtos != value)
                {
                    cuttingDtos = value;
                    RaisePropertyChanged(() => _CuttingDtos);
                }
            }
        }

        private ObservableCollection<MachiningLib_PiercingDto> piercingDtos=new ObservableCollection<MachiningLib_PiercingDto>();
        public ObservableCollection<MachiningLib_PiercingDto> _PiercingDtos
        {
            get { return piercingDtos; }
            set
            {
                if (piercingDtos != value)
                {
                    piercingDtos = value;
                    RaisePropertyChanged(() => _PiercingDtos);
                }
            }
        }

        private ObservableCollection<MachiningLib_EdgeCuttingDto> edgeCuttingDtos=new ObservableCollection<MachiningLib_EdgeCuttingDto>();
        public ObservableCollection<MachiningLib_EdgeCuttingDto> _EdgeCuttingDtos
        {
            get { return edgeCuttingDtos; }
            set
            {
                if (edgeCuttingDtos != value)
                {
                    edgeCuttingDtos = value;
                    RaisePropertyChanged(() => _EdgeCuttingDtos);
                }
            }
        }

        private ObservableCollection<MachiningLib_SlopeControlDto> slopeControlDtos=new ObservableCollection<MachiningLib_SlopeControlDto>();
        public ObservableCollection<MachiningLib_SlopeControlDto> _SlopeControlDtos
        {
            get { return slopeControlDtos; }
            set
            {
                if (slopeControlDtos != value)
                {
                    slopeControlDtos = value;
                    RaisePropertyChanged(() => _SlopeControlDtos);
                }
            }
        }

        #endregion

        #region lib menu button
        private bool m_MachiningCutClicked;
        public bool _MachiningCutClicked
        {
            get { return m_MachiningCutClicked; }
            set
            {
                if (m_MachiningCutClicked != value)
                {
                    m_MachiningCutClicked = value;
                    RaisePropertyChanged(() => _MachiningCutClicked);
                }
            }
        }

        private bool m_MachiningHoleClicked;
        public bool _MachiningHoleClicked
        {
            get { return m_MachiningHoleClicked; }
            set
            {
                if (m_MachiningHoleClicked != value)
                {
                    m_MachiningHoleClicked = value;
                    RaisePropertyChanged(() => _MachiningHoleClicked);
                }
            }
        }

        private bool m_MachiningCornerClicked;
        public bool _MachiningCornerClicked
        {
            get { return m_MachiningCornerClicked; }
            set
            {
                if (m_MachiningCornerClicked != value)
                {
                    m_MachiningCornerClicked = value;
                    RaisePropertyChanged(() => _MachiningCornerClicked);
                }
            }
        }

        private bool m_MachiningStartClicked;
        public bool _MachiningStartClicked
        {
            get { return m_MachiningStartClicked; }
            set
            {
                if (m_MachiningStartClicked != value)
                {
                    m_MachiningStartClicked = value;
                    RaisePropertyChanged(() => _MachiningStartClicked);
                }
            }
        }

        private bool m_MachiningPowerClicked;
        public bool _MachiningPowerClicked
        {
            get { return m_MachiningPowerClicked; }
            set
            {
                if (m_MachiningPowerClicked != value)
                {
                    m_MachiningPowerClicked = value;
                    RaisePropertyChanged(() => _MachiningPowerClicked);
                }
            }
        }

        public ICommand _MachiningCutCmd { get; set; }
        public ICommand _MachiningHoleCmd { get; set; }
        public ICommand _MachiningCornerCmd { get; set; }
        public ICommand _MachiningStartCmd { get; set; }
        public ICommand _MachiningPowerCmd { get; set; }
        public ICommand _MachiningLibLoadingCmd { get; set; }



        #endregion

        #region ctol
        public MachiningViewModel(Fanuc fanuc, MachiningLibService mchiningSrv, IMapper mapper)
        {
            _fanuc = fanuc;
            _mapper = mapper;
            m_mchiningSrv = mchiningSrv;

            _UploadEnable = true;
            _SearchEnable = true;

            LoadPageCommand = new RelayCommand(ON_LoadPageCommand);
            UnLoadPageCommand = new RelayCommand(ON_UnLoadPageCommand);
            AddMatrialCommand = new RelayCommand(OnAddMatrialCommand);
            DelMatrialCommand = new RelayCommand(OnDelMatrialCommand);


            //初始化分页viewmodel
            SimpleIoc.Default.GetInstance<MachiningLibCutDataGridViewModel>();
            SimpleIoc.Default.GetInstance<MachiningLibEdgeCuttingDataGridViewModel>();
            SimpleIoc.Default.GetInstance<MachiningLibPiercingDataGridViewModel>();
            SimpleIoc.Default.GetInstance<MachiningLibSlopeControlDataGridViewModel>();

            _MachiningCutCmd = new RelayCommand(OnMachiningCutClick);
            _MachiningHoleCmd = new RelayCommand(OnMachiningHoleClick);
            _MachiningCornerCmd = new RelayCommand(OnMachiningCornerClick);
            _MachiningStartCmd = new RelayCommand(OnMachiningStartClick);
            _MachiningPowerCmd = new RelayCommand(OnMachiningPowerClick);
            _MachiningLibLoadingCmd = new RelayCommand(OnMachiningLibLoadingClick);
            _SendToCncCmd = new RelayCommand(OnMachiningLibSendToCncClick);
            _Material_Changed_Command = new RelayCommand(OnMaterialChangedCmd);
            

            _MachiningLib_Content = new MachiningLibCutDataGrid();
            ChangeMachiningLibMenuButtonCheckedStatus(btn1: true);

            var config = new ConfigHelper();
            config.GetMachiningConfigurationInfo(out laserType, out cutterType, out opticalType);

            //TODO:加载材料、厚度的选项 
            //TODO:根据系统宏变量查找当前选中的材料和厚度
            ReloadMaterialAndThickness();

            //TODO:读取NC的库至PC显示
            GetDataAndMessageToShow();

            Messenger.Default.Register<MachiningLib_CuttingDto>(this, "MachiningLibCutDataSave", msg =>
            {
                var cut = cuttingDtos.Where(x => x.Id == msg.Id).FirstOrDefault();
                if (cut != null)
                {
                    cut = msg;
                }

                var cutting = _mapper.Map<MachiningLib_CuttingDto, MachiningLib_Cutting>(msg);
                var ret = m_mchiningSrv.UpdateMachiningLibCuttingRecord(cutting);
                if (ret == false)
                {
                    Messenger.Default.Send<string>("保存至数据库失败", "OperateNotice");
                }
                else
                {
                    Messenger.Default.Send<string>("保存至数据库成功", "OperateNotice");
                }
            });

            Messenger.Default.Register<MachiningLib_CuttingDto>(this, "MachiningLibCutDataApplicate", msg =>
            {
                var cut = cuttingDtos.Where(x => x.Id == msg.Id).FirstOrDefault();
                if(cut!=null)
                {
                    cut = msg;
                }
            });            

            Messenger.Default.Register<MachiningLib_EdgeCuttingDto>(this, "MachiningLibEdgeCuttingDataSave", msg =>
            {
                var ecut = edgeCuttingDtos.Where(x => x.Id == msg.Id).FirstOrDefault();
                if (ecut != null)
                {
                    ecut = msg;
                }

                var edgeCutting = _mapper.Map<MachiningLib_EdgeCuttingDto, MachiningLib_EdgeCutting>(msg);
                var ret = m_mchiningSrv.UpdateMachiningLibEdgeCuttingRecord(edgeCutting);
                if (ret == false)
                {
                    Messenger.Default.Send<string>("保存至数据库失败", "OperateNotice");
                }
                else
                {
                    Messenger.Default.Send<string>("保存至数据库成功", "OperateNotice");
                }
            });

            Messenger.Default.Register<MachiningLib_EdgeCuttingDto>(this, "MachiningLibEdgeCuttingDataApplicate", msg =>
            {
                var ecut = edgeCuttingDtos.Where(x => x.Id == msg.Id).FirstOrDefault();
                if (ecut != null)
                {
                    ecut = msg;
                }
            });

            Messenger.Default.Register<MachiningLib_PiercingDto>(this, "MachiningLibPiercingDataSave", msg =>
            {
                var pcut = piercingDtos.Where(x => x.Id == msg.Id).FirstOrDefault();
                if (pcut != null)
                {
                    pcut = msg;
                }

                var piercing = _mapper.Map<MachiningLib_PiercingDto, MachiningLib_Piercing>(msg);
                var ret = m_mchiningSrv.UpdateMachiningLibPiercingRecord(piercing);
                if (ret == false)
                {
                    Messenger.Default.Send<string>("保存至数据库失败", "OperateNotice");
                }
                else
                {
                    Messenger.Default.Send<string>("保存至数据库成功", "OperateNotice");
                }
            });

            Messenger.Default.Register<MachiningLib_PiercingDto>(this, "MachiningLibPiercingDataApplicate", msg =>
            {
                var pcut = piercingDtos.Where(x => x.Id == msg.Id).FirstOrDefault();
                if (pcut != null)
                {
                    pcut = msg;
                }
            });

            Messenger.Default.Register<MachiningLib_SlopeControlDto>(this, "MachiningLibSlopeControlDataSave", msg =>
            {
                var sc = slopeControlDtos.Where(x => x.Id == msg.Id).FirstOrDefault();
                if (sc != null)
                {
                    sc = msg;
                }

                var slopeControl = _mapper.Map<MachiningLib_SlopeControlDto, MachiningLib_SlopeControl>(msg);
                var ret = m_mchiningSrv.UpdateMachiningLibSlopeControlRecord(slopeControl);
                if (ret == false)
                {
                    Messenger.Default.Send<string>("保存至数据库失败", "OperateNotice");
                }
                else
                {
                    Messenger.Default.Send<string>("保存至数据库成功", "OperateNotice");
                }
            });

            Messenger.Default.Register<MachiningLib_SlopeControlDto>(this, "MachiningLibSlopeControlDataApplicate", msg =>
            {
                var sc = slopeControlDtos.Where(x => x.Id == msg.Id).FirstOrDefault();
                if (sc != null)
                {
                    sc = msg;
                }
            });

        }

        #endregion

        private void ON_LoadPageCommand()
        {
            //string material_id = "1";//TEST
            //_MaterialNames = m_mchiningSrv.GetMachiningLib_Materials();//加载材料名称
            //var cur_material = m_mchiningSrv.GetMachiningLib_Material_ById(material_id);

            //if (cur_material != null)
            //{
            //    _SelectedMaterialName = cur_material.Name;
            //    _MaterialDtos = m_mchiningSrv.GetMachiningLib_MaterialThicknesss(_SelectedMaterialName);//加载材料厚度
            //    _SelectedMaterial = _MaterialDtos.Where(x => x.Thickness == cur_material.Thickness).FirstOrDefault();
            //}
            //else
            //{

            //}

            ////TODO:读取NC的库至PC显示
            //GetDataAndMessageToShow();
        }

        private void ON_UnLoadPageCommand()
        {
            
        }

        private void OnAddMatrialCommand()
        {
            var dialog = new AddMatrialWindow();
            dialog.ShowDialog();

            ReloadMaterialAndThickness();
            

            GetDataAndMessageToShow();
        }

        private void OnDelMatrialCommand()
        {
            var dialog = new DelMatrialWindow();
            dialog.ShowDialog();

            ReloadMaterialAndThickness();


            GetDataAndMessageToShow();
        }

        #region private func
        private void ChangeMachiningLibMenuButtonCheckedStatus(bool btn1 = false, bool btn2 = false, bool btn3 = false,
            bool btn4 = false, bool btn5 = false)
        {
            _MachiningCutClicked = btn1;
            _MachiningHoleClicked = btn2;
            _MachiningCornerClicked = btn3;
            _MachiningStartClicked = btn4;
            _MachiningPowerClicked = btn5;
        }

        private void GetDataAndMessageToShow()
        {
            _SearchEnable = false;

            cuttingDtos.Clear();
            piercingDtos.Clear();
            edgeCuttingDtos.Clear();
            slopeControlDtos.Clear();

            if (_SelectedMaterialName == null)
            {
                return;
            };

            //short cutting_num = 10;//切割
            var cutting = m_mchiningSrv.GetMachiningLibCuttingRecords(_SelectedMaterialName, _SelectedMaterial.Thickness, _CutterDiameter, _G_Kind);
            cutting.ForEach(x => cuttingDtos.Add(_mapper.Map<MachiningLib_Cutting, MachiningLib_CuttingDto>(x)));
            Messenger.Default.Send<ObservableCollection<MachiningLib_CuttingDto>>(cuttingDtos, "MachiningLibCutDataShow");

            //short piercing_num = 10;//穿孔
            var piercing = m_mchiningSrv.GetMachiningLibPiercingRecords(_SelectedMaterialName, _SelectedMaterial.Thickness, _CutterDiameter, _G_Kind);
            piercing.ForEach(x => piercingDtos.Add(_mapper.Map<MachiningLib_Piercing, MachiningLib_PiercingDto>(x)));
            Messenger.Default.Send<ObservableCollection<MachiningLib_PiercingDto>>(piercingDtos, "MachiningLibPiercingDataShow");

            //short edgeCutting_num = 10;//尖角
            var edgeCutting = m_mchiningSrv.GetMachiningLibEdgeCuttingRecords(_SelectedMaterialName, _SelectedMaterial.Thickness, _CutterDiameter, _G_Kind);
            edgeCutting.ForEach(x => edgeCuttingDtos.Add(_mapper.Map<MachiningLib_EdgeCutting, MachiningLib_EdgeCuttingDto>(x)));
            Messenger.Default.Send<ObservableCollection<MachiningLib_EdgeCuttingDto>>(edgeCuttingDtos, "MachiningLibEdgeCuttingDataShow");

            //short slopeControl_num = 10;//功率
            var slopeControl = m_mchiningSrv.GetMachiningLibSlopeControlRecords(_SelectedMaterialName, _SelectedMaterial.Thickness, _CutterDiameter, _G_Kind);
            slopeControl.ForEach(x => slopeControlDtos.Add(_mapper.Map<MachiningLib_SlopeControl, MachiningLib_SlopeControlDto>(x)));
            //_fanuc.ReadMachiningLibCuttingData(ref cuttingDtos, ref edgeCutting_num);//TEST
            Messenger.Default.Send<ObservableCollection<MachiningLib_SlopeControlDto>>(slopeControlDtos, "MachiningLibSlopeControlDataShow");

            _SearchEnable = true;

        }

        private void OnMachiningLibLoadingClick()
        {
            GetDataAndMessageToShow();
        }

        public void OnMachiningLibSendToCncClick()
        {

            Task.Factory.StartNew(() =>
            {

                lock(oUpload)
                {
                    _UploadEnable = false;

                    var cuttings = _mapper.Map<List<MachiningLib_CuttingDto>, List<MachiningLib_Cutting>>(cuttingDtos.ToList());
                    var edgecuttings = _mapper.Map<List<MachiningLib_EdgeCuttingDto>, List<MachiningLib_EdgeCutting>>(edgeCuttingDtos.ToList());
                    var piercings = _mapper.Map<List<MachiningLib_PiercingDto>, List<MachiningLib_Piercing>>(piercingDtos.ToList());
                    var slopeControls = _mapper.Map<List<MachiningLib_SlopeControlDto>, List<MachiningLib_SlopeControl>>(slopeControlDtos.ToList());

                    var ret_send = _fanuc.SendMachiningLibToCnc(cuttings, edgecuttings, piercings, slopeControls);
                    if (ret_send != null)
                    {
                        Messenger.Default.Send<string>(ret_send, "OperateNotice");
                    }
                    else
                    {
                        Messenger.Default.Send<string>("工艺参数写入成功", "OperateNotice");
                    }
                    
                    _UploadEnable = true;
                }
            });

           
        }

        private void OnMaterialChangedCmd()
        {
            var materials = m_mchiningSrv.GetMachiningLib_MaterialThicknesss(_SelectedMaterialName);//加载材料厚度
            _MaterialDtos.Clear();
            materials.ForEach(x => _MaterialDtos.Add(_mapper.Map<MachiningLib_Material, MachiningLib_MaterialDto>(x)));
            if (_MaterialDtos.Count() != 0) _SelectedMaterial = _MaterialDtos.FirstOrDefault();
        }

        private void ReloadMaterialAndThickness()
        {
            _MaterialNames = m_mchiningSrv.GetMachiningLib_Materials();//加载材料名称
            var material = m_mchiningSrv.GetMachiningLibFirstMaterial();
            var cur_material = _mapper.Map<MachiningLib_Material, MachiningLib_MaterialDto>(material);

            if (cur_material != null)
            {
                _SelectedMaterialName = cur_material.Name;
                var materials = m_mchiningSrv.GetMachiningLib_MaterialThicknesss(_SelectedMaterialName);//加载材料厚度

                _MaterialDtos.Clear();
                materials.ForEach(x => _MaterialDtos.Add(_mapper.Map<MachiningLib_Material, MachiningLib_MaterialDto>(x)));
                _SelectedMaterial = _MaterialDtos.Where(x => x.Thickness == cur_material.Thickness).FirstOrDefault();
            }
          
        }
        #endregion

        #region menu func
        private void OnMachiningCutClick()
        {
            _MachiningLib_Content = new MachiningLibCutDataGrid();
            ChangeMachiningLibMenuButtonCheckedStatus(btn1: true);
        }

        private void OnMachiningHoleClick()
        {
            _MachiningLib_Content = new MachiningLibPiercingDataGrid();
            ChangeMachiningLibMenuButtonCheckedStatus(btn2: true);
        }

        private void OnMachiningCornerClick()
        {
            _MachiningLib_Content = new MachiningLibEdgeCuttingDataGrid();
            ChangeMachiningLibMenuButtonCheckedStatus(btn3: true);
        }

        private void OnMachiningStartClick()
        {
            _MachiningLib_Content = new MachiningLibEdgeCuttingDataGrid();
            ChangeMachiningLibMenuButtonCheckedStatus(btn4: true);
        }

        private void OnMachiningPowerClick()
        {
            _MachiningLib_Content = new MachiningLibSlopeControlDataGrid();
            ChangeMachiningLibMenuButtonCheckedStatus(btn5: true);
        }


    

        #endregion
    }
}
