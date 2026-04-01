using DelegateTurnGame.Core.Characters.MovesetFactory.Interface;
using DelegateTurnGame.Core.Systems.Combat;
using System;
using System.Xml.Linq;

namespace DelegateTurnGame.Core.Characters.MovesetFactory.FactoryMethods
{
    public class GutsMoveset : IMoveset
    {
        public static Moveset Create()
        {
            Move basicAtk = Move.Create(
                "Dragon Slayer",
                "Swings the sword blablalbal",
                 new List<Hit> 
                 {
                     new Hit { Multiplier = 120.0f }
                 },
                 spCost: 0,


                 
                 );
            return new Moveset();
        }
    }
}