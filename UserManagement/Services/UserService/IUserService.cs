using UsrManagemt.Models;
using Microsoft.AspNetCore.Mvc; 

namespace UsrManagemt.Services
{ 
    public interface IUserService
    { 
        Task<IActionResult> CreateUser(User user); 
        Task<IActionResult> DelUser(int id); 
        Task<IActionResult> CheckUser(int id); 
    }
}