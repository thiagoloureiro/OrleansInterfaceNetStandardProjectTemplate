using Orleans;
using System.Threading.Tasks;

namespace OrleansGrainInterface
{
    public interface IHello : IGrainWithIntegerKey
    {
        Task<string> SayHello(string greeting);
    }
}