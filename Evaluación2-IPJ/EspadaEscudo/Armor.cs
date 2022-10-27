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

    float MitigateDamage(float damage)
    {
        float mitigatedDmg = 0.0f;
        return mitigatedDmg;
    }
}
