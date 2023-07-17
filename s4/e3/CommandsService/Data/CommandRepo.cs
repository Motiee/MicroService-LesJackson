using CommandsService.Models;

namespace CommandsService.Data
{
    public class CommandRepo : ICommandRepo
    {
        private readonly AppDbContext _context;

        public CommandRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateCommand(int platformId, Command command)
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(Command));
            }

            command.PlatformId = platformId;
            _context.Commands.Add(command);

        }


        public void CreatePlatform(Platform Plat)
        {
            if (Plat == null)
            {
                throw new ArgumentNullException(nameof(Plat));
            }
            _context.Platforms.Add(Plat);
        }

        public Command GetCommand(int platformId, int commandId)
        {
            return _context.Commands
                    .Where(c => c.Id == commandId && c.PlatformId == platformId).FirstOrDefault();
        }

        public IEnumerable<Command> GetCommandForPlatform(int platformId)
        {
            return _context.Commands
                     .Where(c => c.PlatformId == platformId)
                     .OrderBy(c => c.Platform.Name);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public bool PlatformExists(int platformId)
        {
            return _context.Platforms.Any(p => p.Id == platformId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}


