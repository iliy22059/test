using BLL.DTO;
using BLL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<OperationDetails> Create(UserDTO userDto);             //Создание пользователей
        Task<ClaimsIdentity> Authenticate(UserDTO userDto);         //Аутентификация пользователей
        Task SetInitialData(UserDTO adminDto, List<string> roles);  //Установка начальных данных о БД администратора и списке ролей
    }
}
