﻿using System.Collections.Generic;
using System.Linq;
using PokemonGo.Bot.ViewModels;

namespace PokemonGo.Bot.TransferPokemonAlgorithms
{
    public class TransferPokemonAlgorithmCP : ITranferPokemonAlgorithm
    {
        readonly int threshold;

        public TransferPokemonAlgorithmCP(int threshold)
        {
            this.threshold = threshold;
        }
        public IEnumerable<CaughtPokemonViewModel> Apply(IEnumerable<CaughtPokemonViewModel> allPokemon) => allPokemon.Where(p => p.CombatPoints < threshold);
    }
}