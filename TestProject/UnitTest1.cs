using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Calculating score before 10 Frame
            BowlingBallScore bowlingScore = new BowlingBallScore();
            bowlingScore.CalculateBowlingScore();
            var expected = 0;
            Assert.AreEqual(expected, bowlingScore.Score);           
        }
        [TestMethod]
        public void TestMethod2()
        {
            BowlingBallScore bowlingBallScore = new BowlingBallScore();
            bowlingBallScore.CalculateBowlingScore();
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10);
            bowlingBallScore.RegisterThrows(10, 10, 10);
            bowlingBallScore.CalculateBowlingScore();
            var expected = 300;
            Assert.AreEqual(expected, bowlingBallScore.Score);
        }
    }
}