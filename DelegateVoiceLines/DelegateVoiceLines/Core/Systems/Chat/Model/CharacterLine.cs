using DelegateTurnGame.Core.Characters.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTurnGame.Core.Systems.Chat.Model
{
    public class CharacterLine
    {
        public static string CreateLine(Character character, string message)
        {

            string characterLine = string.Empty;
            var parts = GenerateLimitBoundedMessage(character, message);
            foreach (var part in parts)
            {
                characterLine += $"{part}\n";
            }

            return characterLine;
        }



        static string[] GenerateLimitBoundedMessage(Character character, string message)
        {
            string[] parts = [];
            var raw = $"[{character}]: {message}";
            while (raw.Length > 50)
            {
                parts.Append(raw.Substring(0, 50));
                raw = raw.Substring(50);
            }
            var remainingText = raw;
            parts.Append(remainingText);

            return parts;
        }
    }
}
