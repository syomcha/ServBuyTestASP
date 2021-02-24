using System.Collections;
using System.Collections.Generic;
using ServBuy.Models;

namespace ServBuy.Interfaces
{
    public interface IAllUsers
    {
        IEnumerable<User> AllUsers { get; }
    }
}