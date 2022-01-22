using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponList : WeaponList
{
    public delegate void WeaponChange();
    public WeaponChange weaponChange;
    [SerializeField] internal List<GameObject> weaponListObj;


    internal void Init (WeaponChange weaponChange)
    {
        this.weaponChange = weaponChange;
    }

    internal override void SetCurrentWeapon(int weaponNumber)
    {
        currentWeapon = weaponList[weaponNumber];
        weaponChange?.Invoke();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
