using System.Collections.Generic;
using UnityEngine;

public class WeaponList : MonoBehaviour
{
    [SerializeField] internal List<Weapon> weaponList;
    [SerializeField] internal Weapon currentWeapon;

    internal virtual void SetCurrentWeapon(int weaponNumber)
    {
        currentWeapon = weaponList[weaponNumber];
    }

    internal virtual Weapon GetCurrentWeapon()
    {
        return currentWeapon;
    }

    internal int GetWeponsCount()
    {
        return weaponList.Count;
    }
}
