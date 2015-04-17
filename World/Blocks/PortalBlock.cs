namespace BlackSea.World.Blocks
{
    public class PortalBlock : IBlock
    {
        public int Layer { get { return 0; } }
        public int ID { get; private set; }
        public Position Position { get; private set; }
        public BlockType Type { get { return BlockType.PortalBlock; } }
        public enum RotationType { Down = 0, Left = 1, Up = 2, Right = 3 }
        public readonly RotationType Rotation;
        public readonly int Identificator;
        public readonly int Target;

        public PortalBlock(Position Position, int BlockID, RotationType Rotation, int Identificator, int Target)
        {
            this.Position = Position;
            this.ID = BlockID;
            this.Rotation = Rotation;
            this.Identificator = Identificator;
            this.Target = Target;
        }

        public bool IsSameAs(IBlock Block)
        {
            if (this.Type == Block.Type)
            {
                PortalBlock PBlock = Block as PortalBlock;
                if (PBlock == this)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator ==(PortalBlock Block1, PortalBlock Block2)
        {
            return Block1.ID == Block2.ID && Block1.Position == Block2.Position && Block1.Identificator == Block2.Identificator && Block1.Target == Block2.Target;
        }

        public static bool operator !=(PortalBlock Block1, PortalBlock Block2)
        {
            return !(Block1 == Block2);
        }

        public override int GetHashCode()
        {
            return ID ^ Position.GetHashCode() ^ Rotation.GetHashCode() ^ Identificator ^ Target;
        }

        public override bool Equals(System.Object Obj)
        {
            if (Obj == null)
                return false;
            PortalBlock p = Obj as PortalBlock;
            if ((System.Object)p == null)
                return false;

            return (this == p);
        }
    }
}
