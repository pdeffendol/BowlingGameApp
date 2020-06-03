using System;
using Xunit;

namespace BowlingGameApp.Tests
{
    public class Scoring
    {
        private readonly BowlingGame game;

        public Scoring()
        {
            game = new BowlingGame();
        }
        
        [Fact]
        public void ZeroGame()
        {
            RollMany(20, 0);

            Assert.Equal(0, game.Score());
        }

        [Fact]
        public void AllOnes()
        {
            RollMany(20, 1);

            Assert.Equal(20, game.Score());
        }

        [Fact]
        public void OneSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            RollMany(17, 0);

            Assert.Equal(16, game.Score());
        }

        private void RollMany(int rolls, int pins)
        {
            for (int r = 0; r < rolls; r++)
            {
                game.Roll(pins);
            }
        }
    }
}
