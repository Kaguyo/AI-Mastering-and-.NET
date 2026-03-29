using DelegateTurnGame.Core.Characters.MovesetFactory.Interface;
using DelegateTurnGame.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTurnGame.Core.Characters
{
    public class Character
    {
        #region Public fields
        public Color SymbolicColor { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Hp { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Spd { get; set; }
        public float CritRate { get; set; }
        public float CritDmg { get; set; }
        private int Sp { get; set; }
        public int SpMax { get; set; } = 100;
        public Moveset Moveset { get; set; }
        #endregion

        #region Public Methods
        public static Character Create(Enumerators.Character character)
        {
            return new Character
            {

                Name = character.ToString(),
                SymbolicColor = ResolveColor(character),
                Hp = ResolveHp(character),
                Atk = ResolveAtk(character),
                Def = ResolveDef(character),
                Spd = ResolveSpd(character),
                CritDmg = 100f,
                CritRate = 10f,
                Sp = 0
            };
        }

        public int GetSp()
        { 
            if (Sp > SpMax) Sp = SpMax;
            return Sp;
        }

        public void SumSp(int value)
        {
            Sp += value;
        }

        #endregion

        #region Private methods
        private static int ResolveAtk(Enumerators.Character character)
        {
            var mapAtk = new Dictionary<Enumerators.Character, int>()
            {
                { Enumerators.Character.Mordred, 1200 },
                { Enumerators.Character.Guts, 1200 },
                { Enumerators.Character.Saber, 1200 },
                { Enumerators.Character.JeanneDarc, 1000 },
            };

            return mapAtk[character];
        }
        private static int ResolveDef(Enumerators.Character character)
        {
            var mapAtk = new Dictionary<Enumerators.Character, int>()
            {
                { Enumerators.Character.Mordred, 500 },
                { Enumerators.Character.Guts, 700 },
                { Enumerators.Character.Saber, 500 },
                { Enumerators.Character.JeanneDarc, 800 },
            };

            return mapAtk[character];
        }
        private static int ResolveSpd(Enumerators.Character character)
        {
            var mapAtk = new Dictionary<Enumerators.Character, int>()
            {
                { Enumerators.Character.Mordred, 110 },
                { Enumerators.Character.Guts, 120 },
                { Enumerators.Character.Saber, 120 },
                { Enumerators.Character.JeanneDarc, 100 },
            };

            return mapAtk[character];
        }
        private static Color ResolveColor(Enumerators.Character character)
        {
            var mapAtk = new Dictionary<Enumerators.Character, Color>()
            {
                { Enumerators.Character.Mordred, Color.Orange },
                { Enumerators.Character.Guts, Color.Red },
                { Enumerators.Character.Saber, Color.Yellow},
                { Enumerators.Character.JeanneDarc, Color.Yellow },
            };

            return mapAtk[character];
        }
        private static int ResolveHp(Enumerators.Character character)
        {
            var mapAtk = new Dictionary<Enumerators.Character, int>()
            {
                { Enumerators.Character.Mordred, 10000 },
                { Enumerators.Character.Guts, 17000 },
                { Enumerators.Character.Saber, 12000 },
                { Enumerators.Character.JeanneDarc, 22000 },
            };

            return mapAtk[character];
        }
        #endregion
    }
}
