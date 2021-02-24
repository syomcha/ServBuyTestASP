using System.Collections.Generic;
using ServBuy.Interfaces;
using ServBuy.Models;

namespace ServBuy.Mock
{
    public class MockUsers : IAllUsers
    {
        public IEnumerable<User> AllUsers =>
            new List<User>
            {
                new()
                {
                    id=1, 
                    login="FlamesYT",
                    password="123321"
                },
                new()
                {
                    id=2, 
                    login="Alvar",
                    password="bibus228"
                },
                new()
                {
                    id=3, 
                    login="Unity", 
                    password="c#_gamedev"
                }
            };
    }
}