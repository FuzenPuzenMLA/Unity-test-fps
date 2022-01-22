using System.Collections;
using UnityEngine;

public class Pistol : Weapon
{

    void Start()
    {
        
    }

    internal override void Reload()
    {
        StartCoroutine(WaitReloadTime());
    }

    private IEnumerator WaitReloadTime()
    {
        yield return new WaitForSeconds(ReloadTime);
        bulletsInClip++;
        if (bulletsInClip != Clip) { Reload(); } else { canFire = true; }
    }
}
