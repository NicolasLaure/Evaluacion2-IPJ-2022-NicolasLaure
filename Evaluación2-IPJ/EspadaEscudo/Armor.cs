using System;
using System.Collections.Generic;
using System.Text;

class Armor
{
    private string name;
    private float defense;
    private float weight;

    public Armor(string name, float defense, float weight)
    {
        this.name = name;
        this.defense = defense;
        this.weight = weight;
    }
    float mitigatedDmg;
    public float MitigateDamage(float damage)
    {
        mitigatedDmg = damage * (defense / 100);
        if (damage - mitigatedDmg > 0)
            return damage - mitigatedDmg;
        else
            return 0f;
    }

    public float GetMitigatedDmg()
    {
        return mitigatedDmg;
    }
}
