using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        private int _CurrentFrame;
        private bool _IsFirstThrow;
        private Scorer _Scorer;

        public Game()
        {
            _CurrentFrame = 0;
            _IsFirstThrow = true;
            _Scorer = new Scorer();
        }

        public void ThrowBall(int pins)
        {
            _Scorer.AddThrow(pins);
            AdjustCurrentFrame(pins);
        }

        public object GetScoreForFrame(int frameNumber)
        {
            return _Scorer.GetScoreForFrame(frameNumber);
        }

        public int GetTotalScore()
        {
            return _Scorer.GetScoreForFrame(10);
        }

        private void AdjustCurrentFrame(int pins)
        {
            if (LastBallInFrame(pins))
                AdvanceFrame();
            else
                _IsFirstThrow = false;
        }

        private bool LastBallInFrame(int pins)
        {
            return Strike(pins) || (!_IsFirstThrow);
        }

        private bool Strike(int pins)
        {
            return (_IsFirstThrow && pins == 10);
        }

        private void AdvanceFrame()
        {
            _CurrentFrame++;
            if (_CurrentFrame > 10)
                _CurrentFrame = 10;
        }
    }
}
