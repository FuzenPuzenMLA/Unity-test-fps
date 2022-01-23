using UnityEngine;

public class KeyboardInput : InGameInputs
{
    [SerializeField] private WeaponList weaponList;

    internal override void ChangeWeapon(int weaponNumber)
    {
        // небольшая проверка на вылет из списка оружия
        if(weaponNumber < weaponList.GetWeponsCount()) weaponList.SetCurrentWeapon(weaponNumber);
    }

    private void Start()
    {
        ChangeWeapon(0);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            ChangeWeapon(0);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            ChangeWeapon(1);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            ChangeWeapon(2);
        }
    }
}
