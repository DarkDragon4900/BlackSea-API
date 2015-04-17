using BlackSea.Link;

namespace BlackSea.Movement
{
    public enum DirectionType { Left, Right, Up, Down, LeftUp, LeftDown, RightUp, RightDown, Stop};

    public class Move
    {
        private EEMessage m;

        public DirectionType Direction
        {
            get
            {
                if (m.GetInt(7) == 0 && m.GetInt(8) == -1)
                    return DirectionType.Up;
                if (m.GetInt(7) == 0 && m.GetInt(8) == 1)
                    return DirectionType.Down;
                if (m.GetInt(7) == -1 && m.GetInt(8) == 0)
                    return DirectionType.Left;
                if (m.GetInt(7) == -1 && m.GetInt(8) == -1)
                    return DirectionType.LeftUp;
                if (m.GetInt(7) == -1 && m.GetInt(8) == 1)
                    return DirectionType.LeftDown;
                if (m.GetInt(7) == 1 && m.GetInt(8) == 0)
                    return DirectionType.Right;
                if (m.GetInt(7) == 1 && m.GetInt(8) == -1)
                    return DirectionType.RightUp;
                if (m.GetInt(7) == 1 && m.GetInt(8) == 1)
                    return DirectionType.RightDown;
                return DirectionType.Stop;
            }
        }

        public bool Jump
        {
            get { return m.GetBoolean(10); }
        }

        public PrecisePosition PrecisePosition
        {
            get { return new PrecisePosition(m.GetDouble(1), m.GetDouble(2)); }
        }

        public PrecisePosition Speed
        {
            get { return new PrecisePosition(m.GetDouble(3), m.GetDouble(4)); }
        }

        public PrecisePosition Modifier
        {
            get { return new PrecisePosition(m.GetDouble(5), m.GetDouble(6)); }
        }

        public Move(EEMessage m)
        {
            this.m = m;
        }

        public Move(PrecisePosition PrecisePosition, PrecisePosition Speed, PrecisePosition Modifier, DirectionType Direction, bool Jump)
        {
            int Hor=0, Ver=0;
            object[] m = new object[11];
            m[1] = PrecisePosition.X;
            m[2] = PrecisePosition.Y;
            m[3] = Speed.X;
            m[4] = Speed.Y;
            m[5] = Modifier.X;
            m[6] = Modifier.Y;
            switch(Direction)
            {
                case Movement.DirectionType.Up:
                    Ver = -1;
                    break;
                case Movement.DirectionType.Down:
                    Ver = 1;
                    break;
                case Movement.DirectionType.Left:
                    Hor = -1;
                    break;
                case Movement.DirectionType.LeftUp:
                    Hor = -1;
                    Ver = -1;
                    break;
                case Movement.DirectionType.LeftDown:
                    Hor = -1;
                    Ver = 1;
                    break;
                case Movement.DirectionType.Right:
                    Hor = 1;
                    break;
                case Movement.DirectionType.RightUp:
                    Hor = 1;
                    Ver = -1;
                    break;
                case Movement.DirectionType.RightDown:
                    Hor = 1;
                    Ver = 1;
                    break;
            }
            m[7] = Hor;
            m[8] = Ver;
            m[10] = Jump;
            this.m = new EEMessage("m", m);
        }
    }
}
