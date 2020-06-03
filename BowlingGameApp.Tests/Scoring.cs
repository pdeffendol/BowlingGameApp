using System;
using Xunit;

namespace BowlingGameApp.Tests
{
    public class Scoring
    {
        [Fact]
        public void ZeroGame()
        {
            var game = new BowlingGame();

            for (int r = 0; r < 20; r++)
            {
                game.Roll(0);
            }

            Assert.Equal(0, game.Score());
        }

        [Fact]
        public void AllOnes()
        {
            var game = new BowlingGame();

            for (int r = 0; r < 20; r++)
            {
                game.Roll(1);
            }

            Assert.Equal(20, game.Score());
        }

        [Fact]
        public void OneSpare()
        {
            var game = new BowlingGame();

            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            for (int r = 0; r < 17; r++)
            {
                game.Roll(0);
            }

            Assert.Equal(16, game.Score());
        }

        //[Fact]
        //public void PerfectGame()
        //{
        //    var game = new BowlingGame();

        //    for (int r = 0; r < 12; r++)
        //    {
        //        game.Roll(10);
        //    }

        //    Assert.Equal(300, game.Score());
        //}
    }
}
