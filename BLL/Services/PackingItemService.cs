using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PackingItemService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PackingItem, PackingItemDTO>();
                cfg.CreateMap<PackingItemDTO,PackingItem>();
            });
            return new Mapper(config);
        }

        public static List<PackingItemDTO> GetByTripId(int id)
        {
            var prepo = DataAccessFactory.PackingItemData();
            var data = prepo.GetByTripId(id);
            return GetMapper().Map<List<PackingItemDTO>>(data);
        }

        
    }
}
