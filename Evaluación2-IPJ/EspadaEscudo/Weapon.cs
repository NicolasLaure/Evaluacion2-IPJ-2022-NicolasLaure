using System;
using System.Collections.Generic;
using System.Text;

abstract class Weapon
{
    private string name;
    private float attack;

    public Weapon(string name, float attack)
    {
        this.name = name;
        this.attack = attack;
    }
    public abstract float GetAttackDamage(AttackType attackType, ref bool isCrit);

    public abstract float GetCritRate();
}

