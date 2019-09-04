using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using AutoMapper;
using LaserEngineHmi.View;
using LaserEngineHmi.Enum;
using UserCenter;
using FanucCnc;
using LaserEngineHmi.Model;

namespace LaserEngineHmi.ViewModel
{
    public class NcFolderSelectionViewModel : ViewModelBase
    {
        private Fanuc _fanuc;
        private IMapper _mapper;

        private ObservableCollection<NcFolderDto> m_ncFolders = new ObservableCollection<NcFolderDto>();
        public ObservableCollection<NcFolderDto> NcFolders
        {
            get { return m_ncFolders; }
            set
            {
                if (m_ncFolders != value)
                {
                    m_ncFolders = value;
                    RaisePropertyChanged(() => NcFolders);
                }
            }
        }

        private NcFolderDto m_selNcFolder= new NcFolderDto();
        public NcFolderDto SelNcFolder
        {
            get { return m_selNcFolder; }
            set
            {
                if (m_selNcFolder != value)
                {
                    m_selNcFolder = value;
                    RaisePropertyChanged(() => SelNcFolder);

                    GalaSoft.MvvmLight.Messaging.Messenger.Default.Send<NcFolderDto>(m_selNcFolder, "NcProgramFolderMsg");
                }
            }
        }


        #region ctor
        public NcFolderSelectionViewModel(IMapper mapper, Fanuc fanuc)
        {
            this._fanuc = fanuc;
            this._mapper = mapper;

            ObservableCollection<NcFolder> folders = new ObservableCollection<NcFolder>();
            _fanuc.GetProgramFolders(ref folders);

            NcFolders = _mapper.Map<ObservableCollection<NcFolder>, ObservableCollection<NcFolderDto>>(folders);
            if(NcFolders.Count!=0)
            {
                SelNcFolder = NcFolders.FirstOrDefault();
            }
        }

        #endregion
    }
}
