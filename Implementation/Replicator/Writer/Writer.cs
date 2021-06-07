using Writer.Services;

namespace Writer
{
    public class Writer
    {
        private readonly WriterSvc service;
        public int ID { get; set; }

        public Writer()
        {
            ID = 0;
            service = new WriterSvc();
        }

        public Writer(int iD)
        {
            service = new WriterSvc();
            ID = iD;
        }

        public void StartSendingData(ReplicatorSender.ReplicatorSender sender)
        {
            service.StartSendingData(sender);
        }

        public void StopSendingData()
        {
            service.StopSendingData();
        }
    }
}
