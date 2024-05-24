using System.Text.RegularExpressions;

namespace NullObjExperiment
{
    
    [GenerateNullObject]
    public interface INetwork
    {
        List<IConnection> CurrentConns { get; }
        IConnection[] ConnectionSet { get; }
        int Id { get; }

        void Disconnect();
        IConnection CreateConnection(int count, Regex r);
    }

}