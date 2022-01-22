using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponList : WeaponList
{
    public delegate void WeaponChange();
    public WeaponChange weaponChange;
    [SerializeField] internal List<MeshRenderer> weaponListMesh;


    internal void Init (WeaponChange weaponChange)
    {
        this.weaponChange = weaponChange;
    }

    internal override void SetCurrentWeapon(int weaponNumber)
    {
        HideWeapons();
        currentWeapon = weaponList[weaponNumber];
        weaponListMesh[weaponNumber].enabled = true;
        weaponChange?.Invoke();
    }

    private void HideWeapons()
    {
        foreach (MeshRenderer weapon in weaponListMesh)
        {
            weapon.enabled = false;
        }
    }
}
