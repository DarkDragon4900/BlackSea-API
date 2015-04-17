namespace BlackSea.World
{
    public class Position
    {
        public readonly int X, Y;

        public Position(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static bool operator ==(Position a, Position b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(Position a, Position b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
                return false;
            Position p = obj as Position;
            if ((System.Object)p == null)
                return false;

            return (this == p);
        }
    }
}
