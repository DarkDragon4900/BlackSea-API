namespace BlackSea.World.Blocks
{
    public enum BlockType { SimpleBlock, BackgroundBlock, ValuedBlock, RotatableBlock, PortalBlock };

    public interface IBlock
    {
        int Layer { get; }
        int ID { get; }
        Position Position { get; }
        BlockType Type { get; }
        bool IsSameAs(IBlock Block);
    }
}
