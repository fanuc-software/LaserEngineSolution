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
    public class DelMatrialWindowViewModel : ViewModelBase
    {
        private MachiningLibService m_mchiningSrv;
        private Fanuc _fanuc;
        private IMapper _mapper;

        public ICommand LoadPageCommand { get; set; }
        public ICommand UnLoadPageCommand { get; set; }

        public ICommand _DelMatrialCmd { get; set; }
        public ICommand _DelThicknessCmd { get; set; }

        public ICommand _Material_Changed_Command { get; set; }



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

        public DelMatrialWindowViewModel(Fanuc fanuc, MachiningLibService mchiningSrv, IMapper mapper)
        {
            _fanuc = fanuc;
            _mapper = mapper;
            m_mchiningSrv = mchiningSrv;


            LoadPageCommand = new RelayCommand(ON_LoadPageCommand);
            UnLoadPageCommand = new RelayCommand(ON_UnLoadPageCommand);

            _DelMatrialCmd = new RelayCommand(OnDelMatrialCommand);
            _DelThicknessCmd = new RelayCommand(OnDelThicknessCommand);
            _Material_Changed_Command = new RelayCommand(OnMaterialChangedCmd);
        }


        private void ON_LoadPageCommand()
        {
            _MaterialNames = m_mchiningSrv.GetMachiningLib_Materials();//加载材料名称

            var material = m_mchiningSrv.GetMachiningLibFirstMaterial();
            var cur_material = _mapper.Map<MachiningLib_Material, MachiningLib_MaterialDto>(material);

            if (cur_material != null)
            {
                _SelectedMaterialName = cur_material.Name;
                var materials = m_mchiningSrv.GetMachiningLib_MaterialThicknesss(_SelectedMaterialName);//加载材料厚度
                materials.ForEach(x => _MaterialDtos.Add(_mapper.Map<MachiningLib_Material, MachiningLib_MaterialDto>(x)));
                _SelectedMaterial = _MaterialDtos.Where(x => x.Thickness == cur_material.Thickness).FirstOrDefault();
            }
        }

        private void ON_UnLoadPageCommand()
        {

        }

        private void OnDelMatrialCommand()
        {
            var res = m_mchiningSrv.DeleteMatrial(_SelectedMaterialName);
            
            Messenger.Default.Send<string>("", "DelMachiningLib_MaterialWindowClose");
        }

        private void OnDelThicknessCommand()
        {
            var res = m_mchiningSrv.DeleteMatrialThickness(_SelectedMaterialName, _SelectedMaterial.Thickness);

            Messenger.Default.Send<string>("", "DelMachiningLib_MaterialWindowClose");
        }

        private void OnMaterialChangedCmd()
        {
            var materials = m_mchiningSrv.GetMachiningLib_MaterialThicknesss(_SelectedMaterialName);//加载材料厚度
            materials.ForEach(x => _MaterialDtos.Add(_mapper.Map<MachiningLib_Material, MachiningLib_MaterialDto>(x)));
            if (_MaterialDtos.Count() != 0) _SelectedMaterial = _MaterialDtos.FirstOrDefault();
        }

    }
        
}
