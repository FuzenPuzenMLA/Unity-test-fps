using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponList : WeaponList
{
    [SerializeField] private List<MeshRenderer> weaponListMesh;

    internal override void SetCurrentWeapon(int weaponNumber)
    {
        HideWeapons();
        currentWeapon = weaponList[weaponNumber];
        weaponListMesh[weaponNumber].enabled = true;
    }

    private void HideWeapons()
    {
        foreach (MeshRenderer weapon in weaponListMesh)
        {
            weapon.enabled = false;
        }
    }
}
