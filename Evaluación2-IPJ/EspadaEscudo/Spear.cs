using System;
using System.Collections.Generic;
using System.Text;

class Spear : Weapon
{
    public Spear(string name, float attack) : base(name, attack)
    {

    }

    public override float GetAttackDamage(AttackType attackType, ref bool isCrit)
    {
        throw new NotImplementedException();
    }
}
