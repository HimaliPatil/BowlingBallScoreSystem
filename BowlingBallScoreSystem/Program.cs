using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            BowlingBallScore bowlingBallScore = new BowlingBallScore();
            bowlingBallScore.CalculateBowlingScore();
            Console.WriteLine("Bowling Ball Score : " + bowlingBallScore.Score); // 0
            bowlingBallScore.RegisterThrows(10, 10); // second will be ignored
            bowlingBallScore.RegisterThrows(10, 10); // 3rd will be ignored
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10, 10, 10);
            bowlingBallScore.CalculateBowlingScore();
            Console.WriteLine("Bowling Ball Score : "+ bowlingBallScore.Score); // Final Score
            Console.ReadLine();

        }
    }
}