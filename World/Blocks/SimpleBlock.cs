namespace BlackSea.World.Blocks
{
    public class SimpleBlock : IBlock
    {
        public int Layer { get { return 0; } }
        public int ID { get; private set; }
        public Position Position { get; private set; }
        public BlockType Type { get { return BlockType.SimpleBlock; } }

        public SimpleBlock(Position Position, int BlockID)
        {
            this.Position = Position;
            this.ID = BlockID;
        }

        public bool IsSameAs(IBlock Block)
        {
            if (this.Type == Block.Type)
            {
                SimpleBlock SBlock = Block as SimpleBlock;
                if (SBlock == this)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator ==(SimpleBlock Block1, SimpleBlock Block2)
        {
            return Block1.ID == Block2.ID && Block1.Position == Block2.Position;
        }

        public static bool operator !=(SimpleBlock Block1, SimpleBlock Block2)
        {
            return !(Block1 == Block2);
        }

        public override int GetHashCode()
        {
            return ID ^ Position.GetHashCode();
        }

        public override bool Equals(System.Object Obj)
        {
            if (Obj == null)
                return false;

            SimpleBlock Block = Obj as SimpleBlock;
            if ((System.Object)Block == null)
                return false;

            return (this == Block);
        }
    }
}
