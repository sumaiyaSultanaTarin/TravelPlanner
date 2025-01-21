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
    public class TripService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Trip, TripDTO>();
                cfg.CreateMap<TripDTO, Trip>();
            });
            var mapper = new Mapper(config);
            return mapper;
        }

        public static List<TripDTO> GetAll()
        {
            var trepo = DataAccessFactory.TripData();
            var data = trepo.Get();
            return GetMapper().Map<List<TripDTO>>(data);
        }

        public static TripDTO Get(int id)
        {
            var trepo = DataAccessFactory.TripData();
            var data = trepo.Get(id);
            return GetMapper().Map<TripDTO>(data);
        }

        public static bool Create(TripDTO t)
        {
            var trip = GetMapper().Map<Trip>(t);
            var trepo = DataAccessFactory.TripData();
            return trepo.Create(trip);
        }

        public static bool Update( TripDTO t)
        {
            var trip = GetMapper().Map<Trip>(t);
            var trepo = DataAccessFactory.TripData();
            return trepo.Update(trip);
        }

        public static void Delete(int id)
        {
            var trepo = DataAccessFactory.TripData();
            trepo.Delete(id);
        }

        public static TripDTO GetTripDetails(int id)
        {
            var trepo = DataAccessFactory.TripData();
            var data = trepo.Get(id);
           
            return GetMapper().Map<TripDTO>(data);
        }
    }

}
