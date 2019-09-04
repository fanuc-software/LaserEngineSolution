using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataCenter.Entities;
using DataCenter.Model;
using System.Collections.ObjectModel;
using AutoMapper;

namespace DataCenter.Services
{
    public class ManualService
    {
        private readonly IMapper _mapper;

        public ManualService(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public ObservableCollection<ManualDto> GetManuals()
        {
            ObservableCollection<ManualDto> manuals = new ObservableCollection<ManualDto>();

            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list = scope.ManualInfo.ToList();

                    list.ForEach(x => manuals.Add(_mapper.Map<ManualInfo, ManualDto>(x)));
                    

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return manuals;

        }

        public void Add(ManualDto dto)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list = scope.ManualInfo.Add(new ManualInfo()
                    {
                        Id = BaseIdGenerator.Instance.GetId(),
                        Path = dto.Path,
                        Name = dto.Name,
                        Specification = dto.Specification,
                        Version = dto.Version
                    });


                    scope.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(ManualDto dto)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list = scope.ManualInfo.Where(x=>x.Id==dto.Id).ToList();
                    scope.ManualInfo.RemoveRange(list);


                    scope.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
