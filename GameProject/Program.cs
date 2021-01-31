using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
        here: Gamer gamer1 = new Gamer();
            Console.WriteLine("Enter your ID: "); gamer1.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your First Name: "); gamer1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: "); gamer1.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Birth Year: "); gamer1.BirthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Identity Number: "); gamer1.IdentityNumber = Convert.ToInt64(Console.ReadLine());
            /*
             * -----LOGIN INFORMATION-----
             *  BirthYear = 2222 
             *  FirstName = USERFNAME
             *  LastName = USERLNAME
             *  IdentityNumber = 12345678910
             */
            UserValidationService validationService = new UserValidationService();
            GamerService gamerService = new GamerService(validationService);

            if (validationService.Validate(gamer1) == false)
            {
                Console.WriteLine("User not verified. Try again...\n");
                goto here;
            }

            Game game1 = new Game { GameName = "Game1", GamePrice = 24 };
            Game game2 = new Game { GameName = "Game2", GamePrice = 56 };
            Game game3 = new Game { GameName = "Game3", GamePrice = 75 };
            Game game4 = new Game { GameName = "Game4", GamePrice = 12 };
            GameService game = new GameService();
            int bgame;

            Console.WriteLine("Select the game you want to buy.\nEnter '1' for GAME1\nEnter '2' for GAME2\nEnter '3' for GAME3\nEnter '4' for GAME4");

            bgame = Convert.ToInt32(Console.ReadLine());
            if (bgame == 1)
            {
                game.Sale(game1, gamer1);
            }
            else if (bgame == 2)
            {
                game.Sale(game2, gamer1);
            }
            else if (bgame == 3)
            {
                game.Sale(game3, gamer1);
            }
            else if (bgame == 4)
            {
                game.Sale(game4, gamer1);
            }
            else
            {
                Console.WriteLine("Incorrect entry");
            }
        }
    }
}
