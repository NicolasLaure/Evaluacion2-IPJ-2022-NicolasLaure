using System;
using System.Collections.Generic;
using System.Text;

class Sword : Weapon
{
    public Sword(string name, float attack) : base(name, attack)
    {

    }

    public override float GetAttackDamage(AttackType attackType, ref bool isCrit)
    {
        float dmg = 0.0f;
        return dmg;
    }
}
