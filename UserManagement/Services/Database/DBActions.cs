using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UsrManagemt.Database; 
using UsrManagemt.Models; 

namespace UsrManagemt.Database
{ 
    public class DBActions 
    { 
        private readonly DataBaseContext _context; 

        public DBActions(DataBaseContext context) 
        { 
            _context = context; 
        }

        public async Task<List<User>> GetAllUsers()
        { 
            return await _context.Users.ToListAsync();
        } 

        public async Task AddUser(User user)
        { 
            await _context.Users.AddAsync(user);
        } 

        public async Task DeleteUser(int id)
        { 
            var user_ = await _context.Users.FindAsync(id);
            if (user_ != null)
            {
                _context.Users.Remove(user_);
                await _context.SaveChangesAsync(); 
            }
        } 

        public async Task<IActionResult> CheckUserD(int id)
        { 
            var user_ = await _context.Users.FindAsync(id); 
            return new JsonResult(new { message = user_ }); 
        }
    }
}
