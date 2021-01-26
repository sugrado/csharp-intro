using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<T, H>
    {
        T[] items;
        T[] tempItems;

        H[] piece;
        H[] tempPiece;
        int sum = 0;

        // When class is called, CONSTRUCTOR runs first.

        public MyList()
        {
            items = new T[0];
            piece = new H[0];
        }

        public void Add(T item, H stock)
        {
            tempItems = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }
            items[items.Length - 1] = item;

            tempPiece = piece;
            piece = new H[piece.Length+1];
            for (int i = 0; i < tempPiece.Length; i++)
            {
                piece[i] = tempPiece[i];
            }
            piece[piece.Length - 1] = stock;
            
        }


        public T[] FruitCount
        {
            get { return items; }
        }

        public H[] FruitPiece
        {
            get { return piece; }
        }
    }
}
