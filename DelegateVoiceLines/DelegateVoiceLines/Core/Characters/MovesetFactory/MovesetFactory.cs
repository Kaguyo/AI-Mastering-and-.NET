using DelegateTurnGame.Core.Characters.MovesetFactory.FactoryMethods;
using DelegateTurnGame.Core.Characters.MovesetFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTurnGame.Core.Characters.MovesetFactory
{
    
    public class MovesetFactory
    {
        public static Moveset Create(Enumerators.Character character)
        {
            return ResolveMoveset(character);
        }

        private static Moveset ResolveMoveset(Enumerators.Character character)
        {
            var movesetMap = new Dictionary<Enumerators.Character, Func<Moveset>>()
            {
                { Enumerators.Character.Mordred, () => MordredMoveset.GetMoveset()},
                { Enumerators.Character.Guts, () => GutsMoveset.GetMoveset()},
                { Enumerators.Character.Saber, () => SaberMoveset.GetMoveset()},
                { Enumerators.Character.JeanneDarc, () => JeanneDarcMoveset.GetMoveset()},
            };

            return movesetMap[character]();
        }


    }
}
