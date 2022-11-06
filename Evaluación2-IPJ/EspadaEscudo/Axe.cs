using System;
using System.Collections.Generic;
using System.Text;

class Axe : Weapon
{
    private float attack;
    private float critRate = 10;
    private float critDmg = 1.5f;
    public Axe(string name, float attack) : base(name, attack)
    {
        this.attack = attack;
    }

    public override float GetAttackDamage(AttackType attackType, ref bool isCrit)
    {
        float dmg = 0f;
        switch (attackType)
        {
            case AttackType.AtaqueRapido:
                if (isCrit)
                    dmg = attack * 0.75f * critDmg;
                else
                    dmg = attack * 0.75f;

                break;
            case AttackType.AtaqueNormal:
                if (isCrit)
                    dmg = attack * critDmg;
                else
                    dmg = attack;
                break;
            case AttackType.AtaqueCargado:
                if (isCrit)
                    dmg = attack * 1.25f * critDmg;
                else
                    dmg = attack * 1.25f;
                break;
        }
        return dmg;
    }
    public override float GetCritRate()
    {
        return critRate;
    }
}

