using BlackSea.World.Blocks;

namespace BlackSea.World
{
    public interface IMap
    {
        int Width { get; }
        int Height { get; }
        string Owner { get; }
        bool HasAccess { get; }
        double Gravity { get; }
        string Key { get; }
        string Title { get; }
        int Plays { get; }
        int Woots { get; }
        int TotalWoots { get; }
        IBlock GetBlock(int Layer, Position Position);
        IBlock this[int Layer, int X, int Y] { get; }
    }
}
