namespace ConsoleApp1
{
    public interface IBowlingBallScore
    {
        void RegisterThrows(params int[] throws);
        void CalculateBowlingScore();
    }
}
