using CommandsService.Models;

namespace CommandsService.Data
{

    public interface ICommandRepo
    {
        // Platforms
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform Plat);
        bool PlatformExists(int platformId);

        bool ExternalPlatformExists(int externalPlatformId);

        // Commands
        IEnumerable<Command> GetCommandForPlatform(int platformId);
        Command GetCommand(int platformId, int commandId);
        void CreateCommand(int platformId, Command command); 
    }
}