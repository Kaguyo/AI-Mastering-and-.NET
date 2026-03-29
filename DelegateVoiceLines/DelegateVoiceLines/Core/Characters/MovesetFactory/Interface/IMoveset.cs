using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTurnGame.Core.Characters.MovesetFactory.Interface
{
    public struct Hit
    {
        public float Multiplier;
    }
    public class Move
    { 
        public string Name;
        public string Description;
        public Hit[] Hits;
        public int? SpCost;
        public Func<Character, Character> SelfModifying;
        public Action<Character, Character> TargetModifying;
    }
    public struct Moveset
    {
        public Move[] Moves;
    }

    public interface IMoveset
    {
        abstract static Moveset GetMoveset();
    }
}
