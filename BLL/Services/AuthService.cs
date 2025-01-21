using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<Token, TokenDTO>();
            });
            return new Mapper(config);

        }
        public static TokenDTO Authenticate(string uname, string pass)
        {
            var auth = DataAccessFactory.Auth();
            var user = auth.Authenticate(uname, pass);
            if (user != null)
            {
                var token = new Token();
                token.CreatedAt = DateTime.Now;
                token.UserId = user.Id;
                token.Key = Guid.NewGuid().ToString();
                var repo = DataAccessFactory.TokenData();
                var tk = repo.Create(token);
                return GetMapper().Map<TokenDTO>(tk);
            }
            return null;
        }
        public static bool IsTokenValid(string token)
        {
            var repo = DataAccessFactory.TokenData();
            var tk = repo.Get(token);
            if (tk != null && tk.ExpiredAt == null)
            {
                return true;
                //return GetMapper().Map<TokenDTO>(tk);
            }
            return false;
        }
        public static bool Logout(string tk)
        {
            var tokn = DataAccessFactory.TokenData().Get(tk);
            tokn.ExpiredAt = DateTime.Now;
            return DataAccessFactory.TokenData().Update(tokn) != null;


        }
        public static bool IsUserAdmin(string token)
        {
            var repo = DataAccessFactory.TokenData();
            var tk = repo.Get(token);
            if (tk != null && tk.ExpiredAt == null && tk.User.Role.Equals("admin"))
            {
                return true;

            }
            return false;

        }

    }
}
