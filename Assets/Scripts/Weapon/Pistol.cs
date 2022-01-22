using UnityEngine;

public class Pistol : Weapon
{
    
    void Start()
    {
        Shoot();
    }

    public override void Reload()
    {
        throw new System.NotImplementedException();
    }

 
}
