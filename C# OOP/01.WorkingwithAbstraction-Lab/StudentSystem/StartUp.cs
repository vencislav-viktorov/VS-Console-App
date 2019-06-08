namespace StudentSystem
{
    public class Startup
    {
        public static void Main()
        {
            var commandParser = new CommandParser();
            var studentSystem = new StudentSystem();
            var dataReader = new ConsoleDataReader();
            var dataWriter = new ConsoleDataWriter();

            var engine = new Engine(
                commandParser,
                studentSystem,
                dataReader,
                dataWriter);

            engine.Run();
        }
    }
}
