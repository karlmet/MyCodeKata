using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingGame;
using NUnit.Framework;
using NSubstitute;

namespace BowlingGameKata.Tests
{
    [TestFixture]
    public class GameXimaTests
    {

        private GameXima game;
        private IXima ximaMock;

        [SetUp]
        public void Setup()
        {
            ximaMock = Substitute.For<IXima>();
            game = new BowlingGame.GameXima(ximaMock);
        }

        [Test]
        public void GetTotalScore_1stFrame2Balls1and4_Score5()
        {
            //--Arrange
            ximaMock.GetNextThrow().Returns(1, 4);
            game.GetScoreFromSource(2);
            //game.ThrowBall(1);
            //game.ThrowBall(4);

            //--Act
            var score = game.GetTotalScore();

            //--Assert
            Assert.AreEqual(5, score);
        }

        //[Test]
        //public void GetTotalScore_2ndFrame2Balls4and5_Score14()
        //{
        //    //--Arrange
        //    game.ThrowBall(1);
        //    game.ThrowBall(4);
        //    game.ThrowBall(4);
        //    game.ThrowBall(5);

        //    //--Act
        //    var score = game.GetTotalScore();

        //    //--Assert
        //    Assert.AreEqual(14, score);
        //}

        //[Test]
        //public void GetScoreForFrame_3BallsSimpleSpare_Score22()
        //{
        //    //--Arrange
        //    game.ThrowBall(3);
        //    game.ThrowBall(7);
        //    game.ThrowBall(6);

        //    //--Act
        //    var frame1Score = game.GetScoreForFrame(1);
        //    var totalScore = game.GetTotalScore();

        //    //--Assert
        //    Assert.AreEqual(16, frame1Score);
        //    Assert.AreEqual(22, totalScore);
        //}


        //[Test]
        //public void GetScoreForFrame_3BallsSimpleStrike_Score20()
        //{
        //    //--Arrange
        //    game.ThrowBall(10);
        //    game.ThrowBall(3);
        //    game.ThrowBall(2);

        //    //--Act
        //    var frame1Score = game.GetScoreForFrame(1);
        //    var totalScore = game.GetTotalScore();

        //    //--Assert
        //    Assert.AreEqual(15, frame1Score);
        //    Assert.AreEqual(20, totalScore);
        //}

        //[Test]
        //public void GetTotalScore_PerfectGame_Score300()
        //{
        //    //--Arrange
        //    for (int i = 0; i < 12; i++)
        //    {
        //        game.ThrowBall(10);
        //    }

        //    //--Act
        //    var totalScore = game.GetTotalScore();

        //    //--Assert
        //    Assert.AreEqual(300, totalScore);
        //}


        //[Test]
        //public void GetTotalScore_EndOfArray_Score20()
        //{
        //    //--Arrange
        //    for (int i = 0; i < 9; i++)
        //    {
        //        game.ThrowBall(0);
        //        game.ThrowBall(0);
        //    }
        //    game.ThrowBall(2);
        //    game.ThrowBall(8); //10th frame spare
        //    game.ThrowBall(10); //strike in last position of array

        //    //--Act
        //    var totalScore = game.GetTotalScore();

        //    //--Assert
        //    Assert.AreEqual(20, totalScore);
        //}

        //[Test]
        //public void GetTotalScore_SampleGame_Score133()
        //{
        //    //--Arrange
        //    game.ThrowBall(1);
        //    game.ThrowBall(4);

        //    game.ThrowBall(4);
        //    game.ThrowBall(5);

        //    game.ThrowBall(6);
        //    game.ThrowBall(4);

        //    game.ThrowBall(5);
        //    game.ThrowBall(5);

        //    game.ThrowBall(10);

        //    game.ThrowBall(0);
        //    game.ThrowBall(1);

        //    game.ThrowBall(7);
        //    game.ThrowBall(3);

        //    game.ThrowBall(6);
        //    game.ThrowBall(4);

        //    game.ThrowBall(10);

        //    game.ThrowBall(2);
        //    game.ThrowBall(8);

        //    game.ThrowBall(6);

        //    //--Act
        //    var score = game.GetTotalScore();

        //    //--Assert
        //    Assert.AreEqual(133, score);
        //}

    }

}
