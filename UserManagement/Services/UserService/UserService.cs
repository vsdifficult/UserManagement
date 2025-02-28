using Microsoft.EntityFrameworkCore; 
using System.ComponentModel.Design.Serialization;
using Microsoft.AspNetCore.Mvc; 
using UsrManagemt.Models; 
using System.Text.Json.Serialization; 
using System.Text.Json;

namespace UsrManagemt.Services
{ 
    public class UserRepository: IUserService 
    { 
        public UserRepository()
        { 

        } 
        public Task<IActionResult> CreateUser(User user)
        { 
            try
            {
                var user_ = new User
                { 
                    ID = new Random().Next(1, 100000), 
                    Email = user.Email,
                    Name = user.Name
                }; 

                return new JsonResult(new {message = "User has created"}); 
            } 
            catch (Exception e)
            { 
                return new JsonResult(new {erorr = e}); 
            }
        } 
        public Task<IActionResult> DelUser(int id)
        { 
            
        } 
        public Task<IActionResult> ChechUser(int id) 
        { 
            
        }
    }
}