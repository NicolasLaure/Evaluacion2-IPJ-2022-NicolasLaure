using System;
using System.Collections.Generic;
using System.Text;

class WarriorGenerator
{
    void CreateWarrior()
    {
        string name;
        Weapon weapon = null;
        Armor armor;
        string weaponName;
        float weaponDmg;

        Console.WriteLine("Elija el nombre que quiere ponerle al nuevo guerrero: ");
        name = Console.ReadLine();
        Console.WriteLine("Elegí que arma llevará el guerrero, 'Espada', 'Lanza', 'Hacha' : ");
        bool validResponse = false;
        while (!validResponse)
        {
            string response = Console.ReadLine();
            switch (response)
            {
                case "Espada":
                case "espada":
                    Console.WriteLine("Introduzca el nombre del arma: ");
                    weaponName = Console.ReadLine();
                    Console.WriteLine("Ingrese los puntos de daño del arma");
                    weaponDmg = Single.Parse(Console.ReadLine());
                    weapon = new Sword(weaponName, weaponDmg);
                    validResponse = true;
                    break;
                case "Lanza":
                case "lanza":
                    Console.WriteLine("Introduzca el nombre del arma: ");
                    weaponName = Console.ReadLine();
                    Console.WriteLine("Ingrese los puntos de daño del arma");
                    weaponDmg = Single.Parse(Console.ReadLine());
                    weapon = new Spear(weaponName, weaponDmg);
                    validResponse = true;
                    break;
                case "Hacha":
                case "hacha":
                    Console.WriteLine("Introduzca el nombre del arma: ");
                    weaponName = Console.ReadLine();
                    Console.WriteLine("Ingrese los puntos de daño del arma");
                    weaponDmg = Single.Parse(Console.ReadLine());
                    weapon = new Axe(weaponName, weaponDmg);
                    validResponse = true;
                    break;
                default:
                    Console.WriteLine("Ingrese Una Respuesta Valida ('Espada', 'Lanza', 'Hacha') ");
                    break;
            }
        }
        Console.WriteLine("Ingrese el nombre de la armadura: ");
        string armorName = Console.ReadLine();
        Console.WriteLine("Ingrese la cantidad de defensa de la armadura");
        float armorDefense = Single.Parse(Console.ReadLine());
        float armorWeight = armorDefense * 0.35f;
        armor = new Armor(armorName, armorDefense, armorWeight);

        Warrior warrior = new Warrior(name, 100);
        warrior.SetWeapon(weapon);
        warrior.SetArmor(armor);

    }
}
