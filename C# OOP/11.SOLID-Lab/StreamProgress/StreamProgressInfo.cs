namespace StreamProgress
{
    public class StreamProgressInfo
    {
        private readonly IStreamable streamable;

        public StreamProgressInfo(IStreamable streamResult)
        {
            this.streamable = streamResult;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamable.BytesSent * 100) / this.streamable.Length;
        }
    }
}