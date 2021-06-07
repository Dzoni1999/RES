using Replicator.Data.Models;

namespace ReplicatorReceiver.Interfaces
{
    public interface IReplicatorReceiver
    {
        bool CheckDataset(int i);
        void InitiateSendingData(Reader.Reader reader, DeltaCD deltaCD);
        void ForwardDataToReaders(Reader.Reader reader, DeltaCD deltaCD);
        void StoreData(Reader.Reader reader, CollectionDescription cd, DeltaCD dcd, int dataset);
    }
}
