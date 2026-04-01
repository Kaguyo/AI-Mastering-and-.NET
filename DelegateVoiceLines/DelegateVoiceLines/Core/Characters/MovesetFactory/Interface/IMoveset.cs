using System;
using System.Collections.Generic;

namespace DelegateTurnGame.Core.Characters.MovesetFactory.Interface
{
    public struct Hit
    {
        public float Multiplier;
    }

    public class MoveDetails
    {
        public string Description;
        public Hit[] Hits;
        public int SpCost = 0;
        public Func<Character, Character> SelfModifying;
        public Action<Character, Character> TargetModifying;
    }

    /// <summary>
    /// A named move backed by a dictionary for O(1) lookup by name.
    /// </summary>
    public class Move
    {
        public Dictionary<string, MoveDetails> Instance { get; private set; }

        private Move() { }

        public static Move Create(
            string moveName,
            string description,
            Hit[] hits,
            int spCost,
            Func<Character, Character> selfModifyingFunc,
            Action<Character, Character> targetModifyingFunc)
        {
            return new Move
            {
                Instance = new Dictionary<string, MoveDetails>
                {
                    [moveName] = new MoveDetails
                    {
                        Description = description,
                        Hits = hits,
                        SpCost = spCost,
                        SelfModifying = selfModifyingFunc,
                        TargetModifying = targetModifyingFunc
                    }
                }
            };
        }

        public MoveDetails this[string name] => Instance[name];
        public string Name => Instance.Keys.First();
    }

    public class Moveset
    {
        public Dictionary<string, MoveDetails> Moves { get; private set; }

        public Moveset(IEnumerable<Move> moves)
        {
            Moves = new Dictionary<string, MoveDetails>();
            foreach (var move in moves)
                foreach (var kvp in move.Instance)
                    Moves[kvp.Key] = kvp.Value;
        }

        /// <summary>Lookup: moveset["Cannon Arm"]</summary>
        public MoveDetails this[string name] => Moves[name];
    }

    public interface IMoveset
    {
        abstract static Moveset Create();
    }
}