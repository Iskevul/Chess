using System;

namespace ChessMain
{
    class ChessMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Figure
    {
        public int x;
        public int y;

        public virtual void Move(int x1, int y1)
        {

        }
    }
}
