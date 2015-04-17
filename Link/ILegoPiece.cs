using System.Windows.Forms;

namespace BlackSea.Link
{
    public interface ILegoPiece
    {
        string Name { get; }
        UserControl GUI { get; }
        Connection Connection { get; set; }
        bool IsSizable { get; }
        void Initialization();
        void Open();
        void Close();
    }
}
