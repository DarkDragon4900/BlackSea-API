namespace BlackSea.World.Blocks
{
    public class BackgroundBlock : IBlock
    {
        public int Layer { get { return 1; } }
        public int ID { get; private set; }
        public Position Position { get; private set; }
        public BlockType Type { get { return BlockType.BackgroundBlock; } }

        public BackgroundBlock(Position Position, int BlockID)
        {
            this.Position = Position;
            this.ID = BlockID;
        }

        public bool IsSameAs(IBlock Block)
        {
            if (this.Type == Block.Type)
            {
                BackgroundBlock BBlock = Block as BackgroundBlock;
                if (BBlock == this)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator ==(BackgroundBlock Block1, BackgroundBlock Block2)
        {
            return Block1.ID == Block2.ID && Block1.Position == Block2.Position;
        }

        public static bool operator !=(BackgroundBlock Block1, BackgroundBlock Block2)
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

            BackgroundBlock Block = Obj as BackgroundBlock;
            if ((System.Object)Block == null)
                return false;

            return (this == Block);
        }
    }
}
