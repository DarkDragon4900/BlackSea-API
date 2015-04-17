namespace BlackSea.Link
{
    public partial class Connection
    {
        private IHost myHost;

        public Connection(IHost Host)
        {
            myHost = Host;
            BlockPlacer.WorkerSupportsCancellation = true;
            BlockPlacer.DoWork += BlockSender_DoWork;
        }
    }
}
