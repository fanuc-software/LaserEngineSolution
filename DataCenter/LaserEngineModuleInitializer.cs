using AutoMapper;
using DataCenter.Entities;
using DataCenter.Model;

namespace DataCenter
{
    public class LaserEngineModuleInitializer : ModuleInitializer
    {
        /// <summary>
        /// 加载AutoMapper配置
        /// </summary>
        public override void LoadMapper(IMapperConfigurationExpression config)
        {

            config.CreateMap<MachiningLib_Material, MachiningLib_MaterialDto>().ReverseMap();
            config.CreateMap<MachiningLib_Cutting, MachiningLib_CuttingDto>().ReverseMap();
            config.CreateMap<MachiningLib_Piercing, MachiningLib_PiercingDto>().ForMember(d => d.Piercing_Reserve, opt => opt.Ignore());
            config.CreateMap<MachiningLib_EdgeCutting, MachiningLib_EdgeCuttingDto>().ReverseMap();
            config.CreateMap<MachiningLib_SlopeControl, MachiningLib_SlopeControlDto>().ReverseMap();

            config.CreateMap<ManualInfo, ManualDto>().ReverseMap();
            config.CreateMap<SparePart, SparePartDto>().ReverseMap();

            config.CreateMap<RootMachiningLib_Material, MachiningLib_MaterialDto>().ReverseMap();
            config.CreateMap<RootMachiningLib_Cutting, MachiningLib_CuttingDto>().ReverseMap() ;
            config.CreateMap<RootMachiningLib_Piercing, MachiningLib_PiercingDto>().ReverseMap();
            config.CreateMap<RootMachiningLib_EdgeCutting, MachiningLib_EdgeCuttingDto>().ReverseMap();
            config.CreateMap<RootMachiningLib_SlopeControl, MachiningLib_SlopeControlDto>().ReverseMap();
        }

    }
}
