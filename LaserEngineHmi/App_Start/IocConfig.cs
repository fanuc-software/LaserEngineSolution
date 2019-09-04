using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Ioc;
using DataCenter;
using AutoMapper;
using DataCenter.Services;
using Microsoft.Practices.ServiceLocation;
using LaserEngineHmi.ViewModel;
using LaserEngineHmi.View.Controls;
using FanucCnc;
using UserCenter;

namespace LaserEngineHmi.App_Start
{
    public class IocConfig
    {
        public static void Register()
        {
            //ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            //automapper
            SimpleIoc.Default.Register<IMapper>(()=>AutoMapperConfig.GetMapperConfiguration().CreateMapper());

            //fanuc
            SimpleIoc.Default.Register<Fanuc>(() => Fanuc.CreateInstance());

            //datacenter
            SimpleIoc.Default.Register<MachiningLibService>(() => MachiningLibService.CreateInstance());
            SimpleIoc.Default.Register<LibInfoService>();
            SimpleIoc.Default.Register<ManualService>();
            SimpleIoc.Default.Register<SparePartService>();
            SimpleIoc.Default.Register<UserService>();

            //usercenter
            SimpleIoc.Default.Register<User>(() => User.CreateInstance());

            //viewmodel
            SimpleIoc.Default.Register<LoadingWaitViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<MachiningViewModel>();
            SimpleIoc.Default.Register<MachiningLibCutDataGridViewModel>();
            SimpleIoc.Default.Register<MachiningLibEdgeCuttingDataGridViewModel>();
            SimpleIoc.Default.Register<MachiningLibPiercingDataGridViewModel>();
            SimpleIoc.Default.Register<MachiningLibSlopeControlDataGridViewModel>();
            SimpleIoc.Default.Register<MOPViewModel>();
            SimpleIoc.Default.Register<DiagnoseViewModel>();
            SimpleIoc.Default.Register<SimulationViewModel>();
            SimpleIoc.Default.Register<ProgramTransViewModel>();
            SimpleIoc.Default.Register<MachineOffsetViewModel>();
            SimpleIoc.Default.Register<SoftwareOffsetViewModel>();
            SimpleIoc.Default.Register<ManualViewModel>();
            SimpleIoc.Default.Register<ManualAddViewModel>();
            SimpleIoc.Default.Register<SparePartViewModel>();
            SimpleIoc.Default.Register<SparePartAddViewModel>();
            SimpleIoc.Default.Register<SimpleCornerMachiningViewModel>();
            SimpleIoc.Default.Register<AutoFindSideViewModel>();
            SimpleIoc.Default.Register<AutoCutterCleanViewModel>();
            SimpleIoc.Default.Register<CutterResetCheckViewModel>();
            SimpleIoc.Default.Register<CutCenterViewModel>();
            SimpleIoc.Default.Register<UserPopViewModel>();
            SimpleIoc.Default.Register<RemainCutViewModel>();
            SimpleIoc.Default.Register<ManuelChangeWorkStationViewModel>();
            SimpleIoc.Default.Register<SimpleNestViewModel>();
            SimpleIoc.Default.Register<AuxGasCheckViewModel>();
            SimpleIoc.Default.Register<AutoFocalPointViewModel>();
            SimpleIoc.Default.Register<AddMatrialWindowViewModel>();
            SimpleIoc.Default.Register<DelMatrialWindowViewModel>();
            SimpleIoc.Default.Register<AlarmListViewModel>();
            SimpleIoc.Default.Register<OpMessageViewModel>();
            SimpleIoc.Default.Register<NcFolderSelectionViewModel>();
            SimpleIoc.Default.Register<ManualFindSideViewModel>();
        }
    }
}
