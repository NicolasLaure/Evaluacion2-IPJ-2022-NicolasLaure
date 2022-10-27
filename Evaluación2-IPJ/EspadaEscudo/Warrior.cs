using System;
using System.Collections.Generic;
using System.Text;

class Warrior
{
    private string name;
    private Weapon weapon;
    private Armor armor;
    private float maxHealth;
    private float currentHealth;

    public Warrior(string name, float maxHealth)
    {
        this.name = name;
        this.maxHealth = maxHealth;
        currentHealth = maxHealth;
    }

    public void SetWeapon(Weapon weapon)
    {
        this.weapon = weapon;
    }
    public void SetArmor(Armor armor)
    {
        this.armor = armor;
    }
    public string GetName()
    {
        return name;
    }
    public float ReceiveDamage(float damage)
    {
        currentHealth -= damage;
        return currentHealth;
    }
    public float GetCurrentHealth()
    {
        return currentHealth;
    }
    public float Attack(Warrior warrior, AttackType attackType, ref bool isCrit)
    {
        return warrior.ReceiveDamage(warrior.weapon.GetAttackDamage(attackType, ref isCrit));
    }
    public bool isAlive()
    {
        if (currentHealth <= 0)
            return false;
        else
            return true;
    }
}
