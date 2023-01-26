using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalcUser : MonoBehaviour
{
    void Start()
    {
        Functions.Inject(new Calc());
    }

    void Update()
    {
        
    }

    private void Attack()
    {
        Functions.CalcDamage(new Character(), new Character());
    }
}
