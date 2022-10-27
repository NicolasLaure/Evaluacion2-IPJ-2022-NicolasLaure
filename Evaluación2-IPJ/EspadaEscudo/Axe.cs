using System;
using System.Collections.Generic;
using System.Text;

class Axe : Weapon
{

    public Axe(string name, float attack) : base(name, attack)
    {
    }

    public override float GetAttackDamage(AttackType attackType, ref bool isCrit)
    {
        throw new NotImplementedException();
    }
}

