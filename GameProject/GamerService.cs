using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerService : IGamerManager
    {
        IUserValidationManager _userValidationManager;

        public GamerService(IUserValidationManager userValidationManager)
        {
            _userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer) == true)
            {
                Console.WriteLine("User registered.");
            }
            else
            {
                Console.WriteLine("User not registered. Mission Failed.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("User deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("User updated.");
        }
    }
}
