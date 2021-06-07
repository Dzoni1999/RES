using Replicator.Data.Models;

namespace ReplicatorSender.Interfaces
{
    public interface IReplicatorSender
    {
        void ForwardDataToReceiver(ReplicatorSender sender, ReplicatorReceiver.ReplicatorReceiver replicatorReceiver);

        void StartForwardingData(ReplicatorSender sender, ReplicatorReceiver.ReplicatorReceiver replicatorReceiver);

        void StopForwardingData();

        CollectionDescription ConvertToCD(HistoricalCollection collection);
    }
}
