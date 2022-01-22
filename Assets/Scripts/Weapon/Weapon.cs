using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private protected List<Transform> BulletSpawnPointList;
    [SerializeField] private protected GameObject BulletPB;

    [SerializeField] private protected int Damage;
    [SerializeField] private protected float FireRate;
    [SerializeField] private protected float MaxShootDistance;
    [SerializeField] private protected float Spread;
    [SerializeField] private protected float ReloadTime;
    [SerializeField] private protected int Clip;

    [SerializeField] private protected int bulletsInClip;
    private Vector3 bulletDirection;
    [SerializeField] private protected bool canFire;

    private GameObject bullet;

    private void Awake()
    {
        bulletsInClip = Clip;
        canFire = true;
    }

    public virtual void Shoot()
    {
        if (canFire)
        {
            for (int i = 0; i < BulletSpawnPointList.Count; i++)
            {
                bullet = Instantiate(BulletPB, BulletSpawnPointList[i].position, Quaternion.identity);
                SetValueToBullet(BulletSpawnPointList[i]);
                bulletsInClip--;
            }
            if (bulletsInClip <= 0)
            {
                Reload();
            }
            else
            {
                StartCoroutine(WaitCanShoot());
            }
            canFire = false;
        }
    }


    internal virtual void SetValueToBullet(Transform BulletSpawnPoint)
    {
        float xSpread = Random.Range(-Spread, Spread);
        float ySpread = Random.Range(-Spread, Spread);
        bulletDirection = BulletSpawnPoint.forward + new Vector3(xSpread, ySpread, 0);
        bullet.GetComponent<Bullet>().InitValues(MaxShootDistance, Damage, bulletDirection);
    }


    internal virtual void Reload()
    {
        StartCoroutine(WaitReload());
    }


    private IEnumerator WaitCanShoot()
    {
        yield return new WaitForSecondsRealtime(FireRate);
        canFire = true;
    }

    private IEnumerator WaitReload()
    {
        yield return new WaitForSecondsRealtime(ReloadTime);
        canFire = true;
        bulletsInClip = Clip;
    }
}
