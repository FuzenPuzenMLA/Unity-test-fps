using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Weapon
{
    void Start()
    {
        
    }

    public override void Shoot()
    {
        base.Shoot();  
    }

    public override void Reload()
    {
        throw new System.NotImplementedException();
    }
}
