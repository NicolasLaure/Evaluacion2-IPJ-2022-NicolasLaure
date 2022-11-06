using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Jugador 1, cree su personaje: ");
        Warrior player1 = WarriorGenerator.CreateWarrior();
        Console.Clear();
        Console.WriteLine("Jugador 2, cree su personaje: ");
        Warrior player2 = WarriorGenerator.CreateWarrior();

        GameLogic game = new GameLogic(player1, player2);

        game.Battle();
    }
}
