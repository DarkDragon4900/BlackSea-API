namespace BlackSea.World.Blocks
{
    public class RotatableBlock : IBlock
    {
        public int Layer { get { return 0; } }
        public int ID { get; private set; }
        public Position Position { get; private set; }
        public BlockType Type { get { return BlockType.RotatableBlock; } }
        public enum RotationType { Down = 1, Left = 2, Up = 3, Right = 0 }
        public readonly RotationType Rotation;

        public RotatableBlock(Position Position, int BlockID, RotationType Rotation)
        {
            this.Position = Position;
            this.ID = BlockID;
            this.Rotation = Rotation;
        }

        public bool IsSameAs(IBlock Block)
        {
            if (this.Type == Block.Type)
            {
                RotatableBlock RBlock = Block as RotatableBlock;
                if (RBlock == this)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator ==(RotatableBlock Block1, RotatableBlock Block2)
        {
            return Block1.ID == Block2.ID && Block1.Position == Block2.Position && Block1.Rotation == Block2.Rotation;
        }

        public static bool operator !=(RotatableBlock Block1, RotatableBlock Block2)
        {
            return !(Block1 == Block2);
        }

        public override int GetHashCode()
        {
            return ID ^ Position.GetHashCode() ^ Rotation.GetHashCode();
        }

        public override bool Equals(System.Object Obj)
        {
            if (Obj == null)
                return false;

            RotatableBlock Block = Obj as RotatableBlock;
            if ((System.Object)Block == null)
                return false;

            return (this == Block);
        }
    }
}
