using DelegateTurnGame.Core.Characters.MovesetFactory.Interface;
using System;
using System.Collections.Generic;

namespace DelegateTurnGame.Core.Characters.MovesetFactory.FactoryMethods
{
    public class GutsMoveset : IMoveset
    {
        public static Moveset Create()
        {
            // 1. Ataque Básico (Dragon Slayer)
            Move dragonSlayer = Move.Create(
                "Dragon Slayer",
                "Um balanço massivo que esmaga o oponente.",
                new Hit[] { new Hit { Multiplier = 1.5f } },
                spCost: 0,
                selfModifyingFunc: (self) => self,
                targetModifyingFunc: (self, target) => {
                    Console.WriteLine($"{target.Name} foi impactado pelo peso da lâmina!");
                }
            );

            // 2. Habilidade de Buff (Berserker Rage)
            Move berserkerRage = Move.Create(
                "Berserker Rage",
                "Consome HP para aumentar drasticamente o ataque.",
                new Hit[] { },
                spCost: 10,
                selfModifyingFunc: (self) => {
                    float atk = self.Atk;
                    atk *= 1.5f;
                    self.Atk = (int)atk;
                    self.Hp -= (self.Hp / 5);
                    return self;
                },
                targetModifyingFunc: (self, target) => { }
            );

            // 3. Multi-hit (Cannon Arm)
            Move cannonArm = Move.Create(
                "Cannon Arm",
                "Um disparo explosivo seguido de um tiro de besta.",
                new Hit[] {
                    new Hit { Multiplier = 2.0f },
                    new Hit { Multiplier = 0.5f }
                },
                spCost: 30,
                selfModifyingFunc: (self) => self,
                targetModifyingFunc: (self, target) => {
                    Console.WriteLine("Explosão causada pelo canhão!");
                }
            );

            // 4. Ultimate (Eclipse Slayer)
            Move eclipseSlayer = Move.Create(
                "Eclipse Slayer",
                "Uma sequência frenética de golpes.",
                new Hit[] {
                    new Hit { Multiplier = 1.5f },
                    new Hit { Multiplier = 1.5f },
                    new Hit { Multiplier = 3.0f }
                },
                spCost: 100,
                selfModifyingFunc: (self) => self,
                targetModifyingFunc: (self, target) => {
                    
                }
            );

            // Retorna o Moveset contendo a lista de moves criados
            return new Moveset(new List<Move> {
                dragonSlayer,
                berserkerRage,
                cannonArm,
                eclipseSlayer
            });
        }
    }
}