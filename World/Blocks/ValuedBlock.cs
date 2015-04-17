namespace BlackSea.World.Blocks
{
    public class ValuedBlock : IBlock
    {
        public int Layer { get { return 0; } }
        public int ID { get; private set; }
        public Position Position { get; private set; }
        public BlockType Type { get { return BlockType.ValuedBlock; } }
        public readonly object Value;

        public ValuedBlock(Position Position, int BlockID, object Value)
        {
            this.Position = Position;
            this.ID = BlockID;
            this.Value = Value;
        }

        public bool IsSameAs(IBlock Block)
        {
            if (this.Type == Block.Type)
            {
                ValuedBlock VBlock = Block as ValuedBlock;
                if (VBlock == this)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator ==(ValuedBlock Block1, ValuedBlock Block2)
        {
            return Block1.ID == Block2.ID && Block1.Position == Block2.Position && Block1.Value == Block2.Value;
        }

        public static bool operator !=(ValuedBlock Block1, ValuedBlock Block2)
        {
            return !(Block1 == Block2);
        }

        public override int GetHashCode()
        {
            return ID ^ Position.GetHashCode() ^ Value.GetHashCode();
        }

        public override bool Equals(System.Object Obj)
        {
            if (Obj == null)
                return false;

            ValuedBlock Block = Obj as ValuedBlock;
            if ((System.Object)Block == null)
                return false;

            return (this == Block);
        }
    }
}
