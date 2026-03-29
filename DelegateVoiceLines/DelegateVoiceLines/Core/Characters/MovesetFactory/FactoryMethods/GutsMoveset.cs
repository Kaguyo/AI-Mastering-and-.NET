using DelegateTurnGame.Core.Characters.MovesetFactory.Interface;
using DelegateTurnGame.Core.Systems.Combat;
using System;

namespace DelegateTurnGame.Core.Characters.MovesetFactory.FactoryMethods
{
    public class GutsMoveset : IMoveset
    {
        public static Moveset GetMoveset()
        {
            var moves = new Move[]
            {
                new Move
                {
                    Name = "Dragonslayer",
                    Description = "A heavy sword strike with overwhelming force.",
                    Hits = [ new Hit { Multiplier = 100.0f }],
                    SpCost = null,
                    SelfModifying = (self) =>
                    {
                        return self;
                    },
                    TargetModifying = (self, target) =>
                    {
                        target.Hp -= Damage.DamageCalculator(self, target);
                        self.SumSp(20);
                    }
                },

                new Move
                {
                    Name = "Cannon Arm",
                    Description = "Fires the prosthetic cannon arm at the target.",
                    Multiplier = 2.0f,
                    SpCost = 40,

                    SelfModifying = (self) =>
                    {
                        return self;
                    },

                    TargetModifying = (target) =>
                    {
                    }
                },

                new Move
                {
                    Name = "Relentless Assault",
                    Description = "A continuous barrage of attacks driven by sheer will.",
                    Multiplier = 1.5f,
                    SpCost = 5,

                    SelfModifying = (self) =>
                    {
                        return self;
                    },

                    TargetModifying = (target) =>
                    {
                    }
                },

                new Move
                {
                    Name = "Beast of Darkness",
                    Description = "Guts taps into the Berserker Armor, sacrificing control for immense power.",
                    Multiplier = 3.5f,
                    SpCost = 20,

                    SelfModifying = (self) =>
                    {
                        return self;
                    },

                    TargetModifying = (target) =>
                    {
                    }
                }
            };

            return new Moveset
            {
                Moves = moves
            };
        }
    }
}