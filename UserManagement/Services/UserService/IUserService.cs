using UsrManagemt.Models;
namespace UsrManagemt.Services
{ 
    public interface IUserService
    { 
        Task CreateUser(User user); 
        Task DelUser(int id); 
        Task ChechUser(int id); 
    }
}