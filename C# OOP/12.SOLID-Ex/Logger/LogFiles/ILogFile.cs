namespace Logger
{
    public interface ILogFile
    {
        int Size { get; }

        void Write(string content);
    }
}