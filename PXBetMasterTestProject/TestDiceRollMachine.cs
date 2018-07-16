using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PXBetMaster;

namespace PXBetMasterTestProject
{
    [TestClass]
    public class DiceRollUnitTest
    {
        [TestMethod]
        public void TestPaysOutNinePoundOnDoubleSix()
        {
            var wager = new Wager() { Stake = 1.0f };
            var diceRoll = new DiceRollMachine();
            var testRoller = new TestDiceRollProvider();
            diceRoll.DiceRoller = testRoller;
            testRoller.PreDeterminedRolls = new[] { 6, 6 };
            var result = diceRoll.Play(wager);
            Assert.AreEqual(9.0f, result.Returns, 0.01f);
        }

        [TestMethod]
        public void TestUserLosesIfNotDouble()
        {
            var wager = new Wager() { Stake = 1.0f };
            var diceRoll = new DiceRollMachine();
            var testRoller = new TestDiceRollProvider();
            diceRoll.DiceRoller = testRoller;
            testRoller.PreDeterminedRolls = new[] { 6, 1 };
            var result = diceRoll.Play(wager);
            Assert.IsFalse(result.IsSuccess);
        }
    }
}
