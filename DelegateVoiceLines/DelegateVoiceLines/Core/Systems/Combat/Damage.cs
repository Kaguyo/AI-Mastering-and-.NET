using DelegateTurnGame.Core.Characters;
using DelegateTurnGame.Core.Characters.MovesetFactory.Interface;
using System;

namespace DelegateTurnGame.Core.Systems.Combat
{
    public class Damage
    {
        public static int DamageCalculator(Character self, Character target)
        {
            float damage = 0f;

            foreach (var hit in self.Moveset.Moves)
            {
                float baseDamage = 0f;
                baseDamage += Math.Max(self.Atk - target.Def, 0f);
                
                damage += baseDamage;
            }

            return (int)Math.Floor(damage);
        }
    }
}