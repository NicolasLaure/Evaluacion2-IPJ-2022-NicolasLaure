using System;
using System.Collections.Generic;
using System.Text;

class GameLogic
{
    Warrior p1;
    Warrior p2;

    int roundNumber = 0;
    public GameLogic(Warrior p1, Warrior p2)
    {
        this.p1 = p1;
        this.p2 = p2;
    }

    public void Battle()
    {
        bool turn = true;
        while (p1.isAlive() && p2.isAlive())
        {
            Console.WriteLine(p1.GetCurrentHealth());
            Console.WriteLine(p2.GetCurrentHealth());
            Attack(turn);
            turn = false;
            Attack(turn);
            turn = true;
            roundNumber++;
        }

        if (p1.isAlive())
            Console.WriteLine("Felicidades Jugador 1: Ganaste el combate!");
        else
            Console.WriteLine("Felicidades Jugador 2: Ganaste el combate!");
    }
    public void Attack(bool attackTurn)
    {
        AttackType attackType = AttackType.AtaqueNormal;
        Random rnd = new Random();
        bool isCrit = false;
        int playerMove;
        if (attackTurn)
            playerMove = 1;
        else
            playerMove = 2;

        bool validResponse = false;
        while (!validResponse)
        {
            Console.WriteLine($"Jugador {playerMove}, Elija el tipo de ataque que quiere realizar (opciones: rapido, normal, cargado): ");
            string response = Console.ReadLine();
            switch (response)
            {
                case "Rapido":
                case "rapido":
                    attackType = AttackType.AtaqueRapido;
                    validResponse = true;
                    break;

                case "Normal":
                case "normal":
                    attackType = AttackType.AtaqueNormal;
                    validResponse = true;
                    break;

                case "Cargado":
                case "cargado":
                    attackType = AttackType.AtaqueCargado;
                    validResponse = true;
                    break;
            }
        }

        switch (attackType)
        {
            case AttackType.AtaqueRapido:
                if (playerMove == 1)
                {
                    if (rnd.Next(0, 100) < (p1.GetWeapon().GetCritRate() + 5))
                        isCrit = true;
                }
                else
                {
                    if (rnd.Next(0, 100) < (p2.GetWeapon().GetCritRate() + 5))
                        isCrit = true;
                }
                break;

            case AttackType.AtaqueNormal:
                if (playerMove == 1)
                {
                    if (rnd.Next(0, 100) < p1.GetWeapon().GetCritRate())
                        isCrit = true;
                }
                else
                {
                    if (rnd.Next(0, 100) < (p2.GetWeapon().GetCritRate()))
                        isCrit = true;
                }
                break;

            case AttackType.AtaqueCargado:
                if (playerMove == 1)
                {
                    if (rnd.Next(0, 100) < (p1.GetWeapon().GetCritRate() - 5))
                        isCrit = true;
                }
                else
                {
                    if (rnd.Next(0, 100) < (p2.GetWeapon().GetCritRate() - 5))
                        isCrit = true;
                }
                break;
        }
        if (playerMove == 1)
        {
            p2.ReceiveDamage(p2.GetArmor().MitigateDamage(p1.Attack(p2, attackType, ref isCrit)));
            Console.WriteLine($"El jugador 1 atacó al enemigo: {p2.GetName()} y le infligió " +
                $"{p2.GetArmor().MitigateDamage(p1.Attack(p2, attackType, ref isCrit))}" +
                $", dejandolo a {p2.GetCurrentHealth()} puntos de vida, la armadura de el player 2 mitigó: " +
                $"{p2.GetArmor().GetMitigatedDmg()} puntos de daño");
        }
        else
        {
            p1.ReceiveDamage(p1.GetArmor().MitigateDamage(p2.Attack(p1, attackType, ref isCrit)));
            Console.WriteLine($"El jugador 2 atacó al enemigo: {p1.GetName()} y le infligió " +
                $"{p1.GetArmor().MitigateDamage(p2.Attack(p1, attackType, ref isCrit))}" +
                $", dejandolo a {p1.GetCurrentHealth()} puntos de vida, la armadura de el player 2 mitigó: " +
                $"{p1.GetArmor().GetMitigatedDmg()} puntos de daño");
        }
    }
}

