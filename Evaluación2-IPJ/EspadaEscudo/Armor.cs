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
        //mitigatedDmg = damage * (defense / 100);
        mitigatedDmg = Math.Clamp(damage * (defense / 100), 0, damage * 80 / 100);
        return damage - mitigatedDmg;
    }

    public float GetMitigatedDmg()
    {
        return mitigatedDmg;
    }
}
