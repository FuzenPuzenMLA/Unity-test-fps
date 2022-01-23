using System.Collections;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] private EnemyWeaponList enemyWeaponList;
    private float maxShootingDelay;
    private float shootingDelay;
    private void Start()
    {
        enemyWeaponList.SetCurrentWeapon(Random.Range(0, enemyWeaponList.GetWeponsCount()));
        maxShootingDelay = enemyWeaponList.GetCurrentWeapon().FireRate; // в условии задачи было сказано не чаще чем может позволить себе оружие
        shootingDelay = Random.Range(maxShootingDelay, maxShootingDelay * 2); // хотя сколько не пытайся всё равно не выстрелит раньше чем может "физически"
        Shoot();
    }


    private void Shoot()
    {
        StartCoroutine(ShootingDelay());
    }

    private IEnumerator ShootingDelay()
    {
        yield return new WaitForSecondsRealtime(shootingDelay);
        enemyWeaponList.currentWeapon.Shoot();
        Shoot();

    }

}
