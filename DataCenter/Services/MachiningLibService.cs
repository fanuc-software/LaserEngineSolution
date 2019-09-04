using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCenter.Entities;
using DataCenter.Model;
using System.Collections.ObjectModel;
using AutoMapper;
using DataCenter.Enum;
using GalaSoft.MvvmLight.Ioc;

namespace DataCenter.Services
{
    public class MachiningLibService
    {
        //private readonly IMapper _mapper;
        private DataCenterEnum _datacenter;
        private static MachiningLibService _instance = null;

        public static MachiningLibService CreateInstance()
        {
            if (_instance == null)

            {
                _instance = new MachiningLibService();
            }
            return _instance;
        }

        public MachiningLibService()
        {

            //this._mapper = SimpleIoc.Default.GetInstance<IMapper>();
            _datacenter = DataCenterEnum.User;
            //this._mapper = mapper;
        }

        public void SetDataCenterEnum(DataCenterEnum data)
        {
            _datacenter = data;
        }

        public bool AddMachiningLib_Material(string name, double thickness, double cutterDiameter, short gKind)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    if (_datacenter == DataCenterEnum.Boot) return false;

                    var cuttings = scope.MachiningLib_Cutting.Where(c => c.MaterialType == name && c.MaterialThickness == thickness && c.CutterDiameter == cutterDiameter && c.Cutting_G_Kind == gKind).FirstOrDefault();
                    if (cuttings != null) return false;

                    var ecuttings = scope.MachiningLib_EdgeCutting.Where(c => c.MaterialType == name && c.MaterialThickness == thickness && c.CutterDiameter == cutterDiameter && c.EdgeCutting_G_Kind == gKind).FirstOrDefault();
                    if (ecuttings != null) return false;

                    var piercings = scope.MachiningLib_Piercing.Where(c => c.MaterialType == name && c.MaterialThickness == thickness && c.CutterDiameter == cutterDiameter && c.Piercing_G_Kind == gKind).FirstOrDefault();
                    if (piercings != null) return false;

                    var scontrols = scope.MachiningLib_SlopeControl.Where(c => c.MaterialType == name && c.MaterialThickness == thickness && c.CutterDiameter == cutterDiameter && c.SlopeControl_Reserve_2 == gKind).FirstOrDefault();
                    if (scontrols != null) return false;


                    var materials = scope.MachiningLib_Material.Where(c => c.Name == name && c.Thickness == thickness).FirstOrDefault();
                    if (materials == null)
                    {
                        scope.MachiningLib_Material.Add(new MachiningLib_Material()
                        {
                            Id = BaseIdGenerator.Instance.GetId(),
                            Name = name,
                            Thickness = thickness,
                        });
                    }

                    for (short i = 1; i <= 10; i++)
                    {
                        scope.MachiningLib_Cutting.Add(new MachiningLib_Cutting()
                        {

                            Id = BaseIdGenerator.Instance.GetId(),
                            ENO = i,
                            MachiningType = "加工类型A",
                            MaterialType = name,
                            MaterialThickness = thickness,
                            FocalDistance = 0,
                            FocalPosition = 0,
                            CutterType = "割嘴A",
                            CutterDiameter = cutterDiameter,
                            Cutting_Feed = 0,
                            Cutting_Power = 0,
                            Cutting_Freq = 5,
                            Cutting_Duty = 0,
                            Cutting_G_Press = 0,
                            Cutting_G_Kind = gKind,
                            Cutting_G_Ready_T = 0,
                            Cutting_Displace = 0,
                            Cutting_Supple = 0,
                            Cutting_Edge_Slt = 0,
                            Cutting_Appr_Slt = 0,
                            Cutting_Pwr_Ctrl = 0,
                            Cutting_Displace_2 = 0,
                        });
                    }

                    for (short i = 201; i <= 205; i++)
                    {
                        scope.MachiningLib_EdgeCutting.Add(new MachiningLib_EdgeCutting()
                        {

                            Id = BaseIdGenerator.Instance.GetId(),
                            NO = i,
                            MachiningType = "加工类型A",
                            MaterialType = name,
                            MaterialThickness = thickness,
                            FocalDistance = 0,
                            FocalPosition = 0,
                            CutterType = "割嘴A",
                            CutterDiameter = cutterDiameter,
                            EdgeCutting_Angle = 0,
                            EdgeCutting_Power = 0,
                            EdgeCutting_Freq = 5,
                            EdgeCutting_Duty = 0,
                            EdgeCutting_Pier_T = 0,
                            EdgeCutting_G_Press = 0,
                            EdgeCutting_G_Kind = gKind,
                            EdgeCutting_R_Len = 0,
                            EdgeCutting_R_Feed = 0,
                            EdgeCutting_R_Freq = 5,
                            EdgeCutting_R_Duty = 0,
                            EdgeCutting_Gap = 0,
                        });
                    }

                    for (short i = 101; i <= 103; i++)
                    {
                        scope.MachiningLib_Piercing.Add(new MachiningLib_Piercing()
                        {

                            Id = BaseIdGenerator.Instance.GetId(),
                            ENO = i,
                            MachiningType = "加工类型A",
                            MaterialType = name,
                            MaterialThickness = thickness,
                            FocalDistance = 0,
                            FocalPosition = 0,
                            CutterType = "割嘴A",
                            CutterDiameter = cutterDiameter,
                            Piercing_Power = 0,
                            Piercing_Freq = 5,
                            Piercing_Duty = 0,
                            Piercing_I_Freq = 5,
                            Piercing_I_Duty = 0,
                            Piercing_Step_T = 0,
                            Piercing_Step_Sum = 0,
                            Piercing_Pier_T = 1,
                            Piercing_G_Press = 0,
                            Piercing_G_Kind = gKind,
                            Piercing_G_Time = 0,
                            Piercing_Def_Pos = 0,
                            Piercing_Def_Pos2 = 0,
                        });
                    }

                    for (short i = 901; i <= 910; i++)
                    {
                        scope.MachiningLib_SlopeControl.Add(new MachiningLib_SlopeControl()
                        {

                            Id = BaseIdGenerator.Instance.GetId(),
                            NO = i,
                            MachiningType = "加工类型A",
                            MaterialType = name,
                            MaterialThickness = thickness,
                            FocalDistance = 0,
                            FocalPosition = 0,
                            CutterType = "割嘴A",
                            CutterDiameter = cutterDiameter,
                            SlopeControl_PowerMin = 0,
                            SlopeControl_PwrSpZr = 0,
                            SlopeControl_FreqMin = 5,
                            SlopeControl_FreqSpZr = 5,
                            SlopeControl_DutyMin = 0,
                            SlopeControl_DutySpZr = 0,
                            SlopeControl_FeedRDec = 0,
                            SlopeControl_FeedR = 0,
                            SlopeControl_Reserve_1 = 0,
                            SlopeControl_Reserve_2= gKind,
                        });
                    }

                    return scope.SaveChanges() > 0;
                }
            }
            catch
            {
            }

            return false;
        }

        public ObservableCollection<string> GetMachiningLib_Materials()
        {
            ObservableCollection<string> oc_infos = new ObservableCollection<string>();


            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list2 = scope.MachiningLib_Material.Select(x => x.Name).Distinct().ToList();
                    list2.ForEach(x => oc_infos.Add(x));
                }
            }
            catch
            {
            }


            return oc_infos;
        }

        public List<MachiningLib_Material> GetMachiningLib_MaterialThicknesss(string material)
        {
            var list = new List<MachiningLib_Material>();

            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    list = scope.MachiningLib_Material.Where(x => x.Name == material).OrderBy(x => x.Thickness).ToList();

                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<MachiningLib_Material>();
            }
            

        }
        
        public MachiningLib_Material GetMachiningLibFirstMaterial()
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var data = scope.MachiningLib_Material.FirstOrDefault();
                    return data;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MachiningLib_Cutting> GetMachiningLibCuttingRecords(string materialType, double materialThickness, double cutterdiameter, short g_kind)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list = scope.MachiningLib_Cutting.Where(c => c.MaterialType == materialType && c.MaterialThickness == materialThickness
                        && c.CutterDiameter == cutterdiameter && c.Cutting_G_Kind == g_kind).ToList();

                    return list;

                }
            }
            catch (Exception ex)
            {
                return new List<MachiningLib_Cutting>();
            }

        }

        public bool UpdateMachiningLibCuttingRecord(MachiningLib_Cutting data)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {

                    var item = scope.MachiningLib_Cutting.Where(c => c.Id == data.Id).FirstOrDefault();

                    if (item != null)
                    {
                        item.ENO = data.ENO;
                        item.FocalPosition = data.FocalPosition;
                        item.FocalDistance = data.FocalDistance;
                        item.CutterDiameter = data.CutterDiameter;
                        item.CutterType = data.CutterType;
                        item.Cutting_Feed = data.Cutting_Feed;
                        item.Cutting_Power = data.Cutting_Power;
                        item.Cutting_Freq = data.Cutting_Freq;
                        item.Cutting_Duty = data.Cutting_Duty;
                        item.Cutting_G_Press = data.Cutting_G_Press;
                        item.Cutting_G_Kind = data.Cutting_G_Kind;
                        item.Cutting_G_Ready_T = data.Cutting_G_Ready_T;
                        item.Cutting_Displace = data.Cutting_Displace;
                        item.Cutting_Supple = data.Cutting_Supple;
                        item.Cutting_Edge_Slt = data.Cutting_Edge_Slt;
                        item.Cutting_Appr_Slt = data.Cutting_Appr_Slt;
                        item.Cutting_Pwr_Ctrl = data.Cutting_Pwr_Ctrl;
                        item.Cutting_Displace_2 = data.Cutting_Displace_2;
                        item.Cutting_Gap_Axis = data.Cutting_Gap_Axis;
                        item.Cutting_Feed_Dec = data.Cutting_Feed_Dec;
                        item.Cutting_Supple_Dec = data.Cutting_Supple_Dec;
                        item.Cutting_Dsp2_Dec = data.Cutting_Dsp2_Dec;
                        item.BEAMSPOT = data.BEAMSPOT;
                        item.LIFTDIST = data.LIFTDIST;
                    }
                    else return false;

                    return scope.SaveChanges() > 0;

                }
            }
            catch
            {
            }

            return false;
        }

        public List<MachiningLib_Piercing> GetMachiningLibPiercingRecords(string materialType, double materialThickness, double cutterdiameter, short g_kind)
        {

            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                   
                    var list = scope.MachiningLib_Piercing.Where(c => c.MaterialType == materialType && c.MaterialThickness == materialThickness
                                && c.CutterDiameter == cutterdiameter && c.Piercing_G_Kind == g_kind).ToList();

                    return list;
                            
                }
            }
            catch (Exception ex)
            {
                return new List<MachiningLib_Piercing>();
            }
        }

        public bool UpdateMachiningLibPiercingRecord(MachiningLib_Piercing data)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var item = scope.MachiningLib_Piercing.Where(c => c.Id == data.Id).FirstOrDefault();

                    if (item != null)
                    {
                        item.ENO = data.ENO;
                        item.FocalPosition = data.FocalPosition;
                        item.FocalDistance = data.FocalDistance;
                        item.CutterDiameter = data.CutterDiameter;
                        item.CutterType = data.CutterType;
                        item.Piercing_Power = data.Piercing_Power;
                        item.Piercing_Freq = data.Piercing_Freq;
                        item.Piercing_Duty = data.Piercing_Duty;
                        item.Piercing_I_Freq = data.Piercing_I_Freq;
                        item.Piercing_I_Duty = data.Piercing_I_Duty;
                        item.Piercing_Step_T = data.Piercing_Step_T;
                        item.Piercing_Step_Sum = data.Piercing_Step_Sum;
                        item.Piercing_Pier_T = data.Piercing_Pier_T;
                        item.Piercing_G_Press = data.Piercing_G_Press;
                        item.Piercing_G_Kind = data.Piercing_G_Kind;
                        item.Piercing_G_Time = data.Piercing_G_Time;
                        item.Piercing_Def_Pos = data.Piercing_Def_Pos;
                        item.Piercing_Def_Pos2 = data.Piercing_Def_Pos2;
                        item.Piercing_Power = data.Piercing_Power;
                    }
                    else return false;

                    return scope.SaveChanges() > 0;

                }
            }
            catch
            {
            }

            return false;
        }

        public List<MachiningLib_EdgeCutting> GetMachiningLibEdgeCuttingRecords(string materialType, double materialThickness, double cutterdiameter, short g_kind)
        {

            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list = scope.MachiningLib_EdgeCutting.Where(c => c.MaterialType == materialType && c.MaterialThickness == materialThickness
                                && c.CutterDiameter == cutterdiameter && c.EdgeCutting_G_Kind == g_kind).ToList();

                    return list;

                }
            }
            catch (Exception ex)
            {
                return new List<MachiningLib_EdgeCutting>();
            }

        }

        public bool UpdateMachiningLibEdgeCuttingRecord(MachiningLib_EdgeCutting data)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var item = scope.MachiningLib_EdgeCutting.Where(c => c.Id == data.Id).FirstOrDefault();

                    if (item != null)
                    {
                        item.NO = data.NO;
                        item.FocalPosition = data.FocalPosition;
                        item.FocalDistance = data.FocalDistance;
                        item.CutterDiameter = data.CutterDiameter;
                        item.CutterType = data.CutterType;
                        item.EdgeCutting_Angle = data.EdgeCutting_Angle;
                        item.EdgeCutting_Power = data.EdgeCutting_Power;
                        item.EdgeCutting_Freq = data.EdgeCutting_Freq;
                        item.EdgeCutting_Duty = data.EdgeCutting_Duty;
                        item.EdgeCutting_Pier_T = data.EdgeCutting_Pier_T;
                        item.EdgeCutting_G_Press = data.EdgeCutting_G_Press;
                        item.EdgeCutting_G_Kind = data.EdgeCutting_G_Kind;
                        item.EdgeCutting_R_Len = data.EdgeCutting_R_Len;
                        item.EdgeCutting_R_Feed = data.EdgeCutting_R_Feed;
                        item.EdgeCutting_R_Freq = data.EdgeCutting_R_Freq;
                        item.EdgeCutting_R_Duty = data.EdgeCutting_R_Duty;
                        item.EdgeCutting_Gap = data.EdgeCutting_Gap;
                    }
                    else return false;

                    return scope.SaveChanges() > 0;

                }
            }
            catch
            {
            }

            return false;
        }

        public List<MachiningLib_SlopeControl> GetMachiningLibSlopeControlRecords(string materialType, double materialThickness, double cutterdiameter, short g_kind)
        {

            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list = scope.MachiningLib_SlopeControl.Where(c => c.MaterialType == materialType && c.MaterialThickness == materialThickness
                                && c.CutterDiameter == cutterdiameter && c.SlopeControl_Reserve_2== g_kind).ToList();

                    return list;


                }
            }
            catch (Exception ex)
            {
                return new List<MachiningLib_SlopeControl>();
            }

        }

        public bool UpdateMachiningLibSlopeControlRecord(MachiningLib_SlopeControl data)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {

                    var item = scope.MachiningLib_SlopeControl.Where(c => c.Id == data.Id).FirstOrDefault();

                    if (item != null)
                    {
                        item.NO = data.NO;
                        item.FocalPosition = data.FocalPosition;
                        item.FocalDistance = data.FocalDistance;
                        item.CutterDiameter = data.CutterDiameter;
                        item.CutterType = data.CutterType;
                        item.SlopeControl_PowerMin = data.SlopeControl_PowerMin;
                        item.SlopeControl_PwrSpZr = data.SlopeControl_PwrSpZr;
                        item.SlopeControl_FreqMin = data.SlopeControl_FreqMin;
                        item.SlopeControl_FreqSpZr = data.SlopeControl_FreqSpZr;
                        item.SlopeControl_DutyMin = data.SlopeControl_DutyMin;
                        item.SlopeControl_DutySpZr = data.SlopeControl_DutySpZr;
                        item.SlopeControl_FeedRDec = data.SlopeControl_FeedRDec;
                        item.SlopeControl_FeedR = data.SlopeControl_FeedR;
                        item.SlopeControl_Reserve_2 = data.SlopeControl_Reserve_2;
                    }
                    else return false;

                    return scope.SaveChanges() > 0;

                }
            }
            catch
            {
            }

            return false;
        }

        public bool DeleteMatrial(string materialType)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list1 = scope.MachiningLib_Material.Where(c => c.Name == materialType).ToList();
                    scope.MachiningLib_Material.RemoveRange(list1);

                    var list2 = scope.MachiningLib_Cutting.Where(c => c.MaterialType == materialType).ToList();
                    scope.MachiningLib_Cutting.RemoveRange(list2);

                    var list3 = scope.MachiningLib_EdgeCutting.Where(c => c.MaterialType == materialType).ToList();
                    scope.MachiningLib_EdgeCutting.RemoveRange(list3);

                    var list4 = scope.MachiningLib_Piercing.Where(c => c.MaterialType == materialType).ToList();
                    scope.MachiningLib_Piercing.RemoveRange(list4);

                    var list5 = scope.MachiningLib_SlopeControl.Where(c => c.MaterialType == materialType).ToList();
                    scope.MachiningLib_SlopeControl.RemoveRange(list5);

                    scope.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool DeleteMatrialThickness(string materialType, double materialThickness)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                   var list1 = scope.MachiningLib_Material.Where(c => c.Name == materialType && c.Thickness == materialThickness).ToList();
                   scope.MachiningLib_Material.RemoveRange(list1);

                    var list2 = scope.MachiningLib_Cutting.Where(c => c.MaterialType == materialType && c.MaterialThickness == materialThickness).ToList();
                    scope.MachiningLib_Cutting.RemoveRange(list2);

                    var list3 = scope.MachiningLib_EdgeCutting.Where(c => c.MaterialType == materialType && c.MaterialThickness == materialThickness).ToList();
                    scope.MachiningLib_EdgeCutting.RemoveRange(list3);

                    var list4 = scope.MachiningLib_Piercing.Where(c => c.MaterialType == materialType && c.MaterialThickness == materialThickness).ToList();
                    scope.MachiningLib_Piercing.RemoveRange(list4);

                    var list5 = scope.MachiningLib_SlopeControl.Where(c => c.MaterialType == materialType && c.MaterialThickness == materialThickness).ToList();
                    scope.MachiningLib_SlopeControl.RemoveRange(list5);

                    scope.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            
        }

    }
}
