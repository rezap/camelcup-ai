﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Delver.CamelCup.External
{
    public class GameState 
    {
        public int CurrentPlayer { get; set; }

        public int BoardSize { get; set; }

        public List<Camel> Camels { get; set; } = new List<Camel>();

        public Dictionary<int, Trap> Traps { get; set; } = new Dictionary<int, Trap>();

        public Dictionary<int, int> Money { get; set; } = new Dictionary<int, int>();

        public List<BettingCard> BettingCards = new List<BettingCard>();

        public List<GameEndBet> WinnerBets = new List<GameEndBet>();

        public List<GameEndBet> LoserBets = new List<GameEndBet>();

        public List<CamelColor> RemainingDice = new List<CamelColor>();

        public GameState Clone()
        {
           return new GameState() 
            {
                CurrentPlayer = CurrentPlayer,
                BoardSize = BoardSize,
                Camels = Camels.Select(x => x.Clone()).ToList(),
                Traps = Traps,
                Money = Money.ToDictionary(x => x.Key, x => x.Value),
                RemainingDice = RemainingDice.ToList()
            };
        }
    }
}
