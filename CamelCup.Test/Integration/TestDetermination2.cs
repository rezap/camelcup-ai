using Microsoft.VisualStudio.TestTools.UnitTesting;
using Delver.CamelCup.MartinBots;
using System.Linq;
using System;

namespace Delver.CamelCup.Web.Services.Test
{
    [TestClass]
    public class TestDetermination2
    {
        [TestMethod]
        public void Integration_Determination_1()
        {
            var runner = new CamelRunner(seed: -639947146);
            runner.AddPlayer(new RandomBot());
            runner.AddPlayer(new SmartMartinPlayer());
            runner.AddPlayer(new DiceThrower());
            var game = runner.ComputeSeededGame(startPosSeed: 1159066037, playerOrderSeed: 1561971233, gameSeed: 778305510);    
            var players = runner.GetPlayers().ToList();

            Assert.AreEqual("97089d38-319b-5841-5671-da55998a82d2", game.GameId.ToString(), "game id");

            var gameState = game.GameState;

            Assert.AreEqual(34, gameState.Money[0], "player 0 money");
            Assert.AreEqual(3, gameState.Money[1], "player 1 money");
            Assert.AreEqual(17, gameState.Money[2], "player 2 money");

            Assert.AreEqual("18,4 11,0 11,1 18,3 18,2", gameState.CamelPositionToString(), "camel positions");
        }
    }
}