namespace BlackSea.Link
{
    public partial class Connection
    {
        private IHost Host;

        public Connection(IHost Host)
        {
            this.Host = Host;
            BlockPlacer.WorkerSupportsCancellation = true;
            BlockPlacer.DoWork += BlockSender_DoWork;
        }
    }
}
