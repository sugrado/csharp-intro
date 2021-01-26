using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            //List<string> fruits0 = new List<string>();
            //fruits0.Add("Orange");
            //Console.WriteLine(fruits0[0]);

            MyList<string, int> fruits = new MyList<string, int>();

            fruits.Add("Apple", 12);
            fruits.Add("Orange", 6);
            fruits.Add("Birne", 6);
            fruits.Add("Banana", 12);
            fruits.Add("Melon", 3);

            for (int i = 0; i < fruits.FruitCount.Length; i++)
            {
                sum += fruits.FruitPiece[i];
            }

            for (int i = 0; i < fruits.FruitCount.Length; i++)
            {
                Console.WriteLine("Fruit Name: " + fruits.FruitCount[i] + " --" + " Piece: " + fruits.FruitPiece[i]);
            }

            Console.WriteLine("Total amount of fruit: " + sum);
        }
    }
}
