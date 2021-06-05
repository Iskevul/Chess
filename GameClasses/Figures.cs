using System;

namespace GameClasses
{
    public class Figures
    {

    }

    public class PieceMaker
    {
        static public Piece Make(string pieceCode, int x, int y)
        {
            Piece piece = null;

            switch (pieceCode)
            {
                case "kingWhite":
                case "kingBlack":
                
                    piece = new King(x, y);
                    break;

                case "queenWhite":
                case "queenBlack":
                    piece = new Queen(x, y);
                    break;

                case "bishopWhite":
                case "bishopBlack":
                    piece = new Bishop(x, y);
                    break;

                case "knightWhite":
                case "knightBlack":
                    piece = new Knight(x, y);
                    break;

                case "rookWhite":
                case "rookBlack":
                    piece = new Rook(x, y);
                    break;

                case "pawnWhite":
                    piece = new whitePawn(x, y);
                    break;

                case "pawnBlack":
                    piece = new blackPawn(x, y);
                    break;

                    //default: throw (new Exception("Unknown piece code."));
            }

            return piece;
        }

        static public Piece Make(int pieceCode, int x, int y)
        {
            return Make(pieceCode.ToString(), x, y);
        }
    }

    // -------------------------------------------------------
    // Piece classes 

    public abstract class Piece
    {
        public int x;
        protected int y;

        public Piece(int newX, int newY)
        {
            x = newX;
            y = newY;
        }
        public abstract bool TestMove(int newX, int newY);

        public bool Move(int newX, int newY)
        {
            if (TestMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }
    }

    class King : Piece
    {
        public King(int newX, int newY) : base(newX, newY)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return (Math.Abs(x - newX) <= 1 && Math.Abs(y - newY) <= 1);
        }

        public bool Move(int newX, int newY)
        {
            if (TestMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }

    }

    class Queen : Piece
    {
        public Queen(int newX, int newY) : base(newX, newY)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return (x == newX || y == newY || Math.Abs(x - newX) == Math.Abs(y - newY));
        }

        public bool Move(int newX, int newY)
        {
            if (TestMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }
    }

    class Bishop : Piece
    {
        public Bishop(int newX, int newY) : base(newX, newY)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return (Math.Abs(x - newX) == Math.Abs(y - newY));
        }

        public bool Move(int newX, int newY)
        {
            if (TestMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }
    }

    class Knight : Piece
    {
        public Knight(int newX, int newY) : base(newX, newY)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return ((Math.Abs(x - newX) == 2 && Math.Abs(y - newY) == 1) ||
                    (Math.Abs(x - newX) == 1 && Math.Abs(y - newY) == 2));
        }

        public bool Move(int newX, int newY)
        {
            if (TestMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }
    }

    class Rook : Piece
    {
        public Rook(int newX, int newY) : base(newX, newY)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return (x == newX || y == newY);
        }

        public bool Move(int newX, int newY)
        {
            if (TestMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }

    }

    class blackPawn : Piece
    {
        public blackPawn(int newX, int newY) : base(newX, newY)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return ((x == newX && y == 2 && y + 2 >= newY) ||
                    (x == newX && y + 1 == newY));
        }

        public bool Move(int newX, int newY)
        {
            if (TestMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }

    }

    class whitePawn : Piece
    {
        public whitePawn(int newX, int newY) : base(newX, newY)
        { }

        public override bool TestMove(int newX, int newY)
        {
            return ((x == newX && y == 2 && y - 2 >= newY) ||
                    (x == newX && y - 1 == newY));
        }

        public bool Move(int newX, int newY)
        {
            if (TestMove(newX, newY))
            {
                x = newX;
                y = newY;
                return true;
            }
            return false;
        }

    }


}
