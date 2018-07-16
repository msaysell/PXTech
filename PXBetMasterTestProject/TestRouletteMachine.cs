using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PXBetMaster;
using PXBetMasterTestProject.MockClasses;


namespace PXBetMasterTestProject
{
    [TestClass]
    public class TestRouletteMachine
    {
        private TestRouletteRoller DefaultTestRoller;
        public TestRouletteMachine()
        {
            DefaultTestRoller = new TestRouletteRoller
            {
                BlackSlots = 30,
                WhiteSlots = 2,
                RedSlots = 30
            };
        }


        [TestMethod]
        public void TestRedWins()
        {
            var roulette = new RouletteMachine();
            DefaultTestRoller.PreDeterminedSpin = 0;
            roulette.Roller = DefaultTestRoller;

            var wager = new RouletteWager
            {
                Stake = 1.0f,
                Choice = RouletteOption.Red
            };
            var result = roulette.Play(wager);

            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual(2.0f, result.Returns, 0.01f);
        }

        [TestMethod]
        public void TestBlackWins()
        {
            var roulette = new RouletteMachine();
            var wheel = DefaultTestRoller;
            wheel.PreDeterminedSpin = wheel.RedSlots + 1;
            roulette.Roller = wheel;

            var wager = new RouletteWager
            {
                Stake = 1.0f,
                Choice = RouletteOption.Black
            };
            var result = roulette.Play(wager);

            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual(2.0f, result.Returns, 0.01f);
        }

        [TestMethod]
        public void TestWhiteWins()
        {
            var roulette = new RouletteMachine();
            var wheel = DefaultTestRoller;
            wheel.PreDeterminedSpin = wheel.RedSlots + wheel.BlackSlots + 1;
            roulette.Roller = wheel;

            var wager = new RouletteWager
            {
                Stake = 1.0f,
                Choice = RouletteOption.Black
            };
            var result = roulette.Play(wager);

            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual(0.1f, result.Returns, 0.01f);
        }
    }
}
