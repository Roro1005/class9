using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public float AttackPoint { get; set; }
    public float DefencePoint { get; set; }
}

public interface IDamageCalclator
{
    float CalcDamage(Character attacker, Character target);
}

public class Functions
{
    private static IDamageCalclator damageCalcInstance { get; set; }

    //Dependency Injection
    public static void Inject(IDamageCalclator calclator)
    {
        damageCalcInstance = calclator;
    }

    public static float CalcDamage(Character attacker, Character target)
    {
        return damageCalcInstance.CalcDamage(attacker, target);
    }
}

public class Calc : IDamageCalclator
{
    public float CalcDamage(Character attacker, Character target)
    {
        //ダメージ計算
        float damage = attacker.AttackPoint = target.DefencePoint;
        if (damage < 1) damage = 1;
        return damage;
    }
}

