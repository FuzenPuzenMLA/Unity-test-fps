using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private protected Transform BulletSpawnPoint;
    [SerializeField] private protected GameObject BulletPB;

    [SerializeField] private protected int Damage;
    [SerializeField] private protected float FireRate;
    [SerializeField] private protected float MaxShootDistance;
    [SerializeField] private protected float Spread;
    [SerializeField] private protected float ReloadTime;
    [SerializeField] private protected int Clip;

    private GameObject bullet;
    public virtual void Shoot()
    {
        bullet = Instantiate(BulletPB, BulletSpawnPoint.position, Quaternion.identity);
        SetValueToBullet();
    }

    private void SetValueToBullet()
    {
        bullet.GetComponent<Bullet>().InitValues(MaxShootDistance, Damage);
    }


    public abstract void Reload();
}
