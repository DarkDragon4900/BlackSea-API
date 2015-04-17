namespace BlackSea.Movement
{
    public class PrecisePosition
    {
        public double X, Y;

        public PrecisePosition(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static bool operator ==(PrecisePosition a, PrecisePosition b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool operator !=(PrecisePosition a, PrecisePosition b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
                return false;
            PrecisePosition p = obj as PrecisePosition;
            if ((System.Object)p == null)
                return false;

            return (this == p);
        }
    }
}
