namespace Writer.Interfaces
{
    public interface IWriter
    {
        void GenerateRandomValue();
        void SendData(ReplicatorSender.ReplicatorSender replicatorSender);
        void StartSendingData(ReplicatorSender.ReplicatorSender replicatorSender);
        void StopSendingData();
    }
}
