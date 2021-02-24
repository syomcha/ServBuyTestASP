using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ServBuy.Interfaces;

namespace ServBuy.Controllers
{
    public class UsersController : Controller
    {
        private readonly IAllUsers _allUsers;

        public UsersController(IAllUsers allUsers)
        {
            _allUsers = allUsers;
        }

        public ViewResult List()
        {
            var users = _allUsers.AllUsers;
            return View(users);
        }
        
        public ViewResult User(long id)
        {
            var users = _allUsers.AllUsers;
            return View(users.FirstOrDefault(u => u.id == id));
        }
    }
}