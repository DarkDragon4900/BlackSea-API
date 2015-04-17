using System.Windows.Forms;

namespace BlackSea.Link
{
    public abstract class LegoPiece : ILegoPiece
    {
        public abstract string Name { get; }
        public abstract UserControl GUI { get; }
        public Connection Connection { get; set; }
        public virtual bool IsSizable { get { return false; } }
        public virtual void Initialization() { }
        public virtual void Open() { }
        public virtual void Close() { }
    }
}
