public class PrintCommand : Command
{
    private readonly IRepository repository;
    private IWriter writer;

    public PrintCommand(string[] data)
        : base(data)
    {
    }

    public override void Execute()
    {
        string result = this.repository.PrintWeapon(this.Data[0]);

        writer.WriteLine(result);
    }
}