﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingGameApp
{
    public class BowlingGame
    {
        private int[] _rolls = new int[21];
        private int _currentRollIndex = 0;

        public void Roll(int pins)
        {
            _rolls[_currentRollIndex++] = pins;
        }

        public int Score()
        {
            var score = 0;
            var rollIndex = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (IsStrike(rollIndex))
                {
                    score += 10 + _rolls[rollIndex + 1] + _rolls[rollIndex + 2];
                    rollIndex += 1;
                }
                else if (IsSpare(rollIndex))
                {
                    score += 10 + _rolls[rollIndex + 2];
                    rollIndex += 2;
                }
                else
                {
                    score += _rolls[rollIndex] + _rolls[rollIndex + 1];
                    rollIndex += 2;
                }
            }

            return score;
        }

        private bool IsStrike(int firstRollOfFrameIndex)
        {
            return _rolls[firstRollOfFrameIndex] == 10;
        }

        private bool IsSpare(int firstRollOfFrameIndex)
        {
            return _rolls[firstRollOfFrameIndex] 
                + _rolls[firstRollOfFrameIndex + 1] == 10;
        }
    }
}
