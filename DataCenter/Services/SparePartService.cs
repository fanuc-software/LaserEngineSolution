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
    public class SparePartService
    {
        private readonly IMapper _mapper;

        //public SparePartService()
        //{
        //}

        public SparePartService(IMapper mapper)
        {
            this._mapper = mapper;
        }

        public ObservableCollection<SparePartDto> GetSpareParts()
        {
            ObservableCollection<SparePartDto> sps = new ObservableCollection<SparePartDto>();

            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list = scope.SparePart.ToList();

                    list.ForEach(x => sps.Add(_mapper.Map<SparePart, SparePartDto>(x)));

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return sps;

        }

        public void Add(SparePartDto dto)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list = scope.SparePart.Add(new SparePart()
                    {
                        Id = BaseIdGenerator.Instance.GetId(),
                        Position = dto.Position,
                        Name = dto.Name,
                        Specification = dto.Specification,
                        Remark = dto.Remark
                    });


                    scope.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(SparePartDto dto)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var list = scope.SparePart.Where(x => x.Id == dto.Id).ToList();
                    scope.SparePart.RemoveRange(list);


                    scope.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Edit(SparePartDto dto)
        {
            try
            {
                using (var scope = new LaserEngineDBEntities())
                {
                    var item = scope.SparePart.Where(x => x.Id == dto.Id).FirstOrDefault();

                    if (item != null)
                    {
                        item.Position = dto.Position;
                        item.Name = dto.Name;
                        item.Specification = dto.Specification;
                        item.Remark = dto.Remark;

                        scope.SaveChanges();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
