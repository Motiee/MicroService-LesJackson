using System.Threading.Tasks;
using PlatformService.Dtos;

namespace PlatformService.syncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCammand(PlatformReadDto plat);
    }
}