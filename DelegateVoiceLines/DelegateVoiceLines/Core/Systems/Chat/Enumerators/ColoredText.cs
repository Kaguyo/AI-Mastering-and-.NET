using DelegateTurnGame.Core.Characters.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTurnGame.Core.Systems.Chat.Enumerators
{
    public static class ColoredText
    {
        public static string GetColoredText(Character character)
        {

            return character.ToString();
        }
    }
}
