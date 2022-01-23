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
        maxShootingDelay = enemyWeaponList.GetCurrentWeapon().FireRate; // � ������� ������ ���� ������� �� ���� ��� ����� ��������� ���� ������
        shootingDelay = Random.Range(maxShootingDelay, maxShootingDelay * 2); // ���� ������� �� ������� �� ����� �� ��������� ������ ��� ����� "���������"
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
