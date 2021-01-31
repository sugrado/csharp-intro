using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationService : IUserValidationManager
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2222
                && gamer.FirstName == "USERFNAME"
                && gamer.LastName == "USERLNAME"
                && gamer.IdentityNumber == 12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
