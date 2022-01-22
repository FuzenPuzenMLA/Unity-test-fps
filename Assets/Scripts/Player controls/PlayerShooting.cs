using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private PlayerWeaponList weaponList;
    [SerializeField] private ShootInput shootInput;
    [SerializeField] private Weapon currentWeapon;

    private void Awake()
    {
        SetCurrentWeapon(); // Инициализация оружия со старка
        shootInput.Init(Shooting);
        weaponList.Init(SetCurrentWeapon);
    }

    internal void SetCurrentWeapon()
    {
        this.currentWeapon = weaponList.GetCurrentWeapon();
    }

    private void Shooting()
    {
        currentWeapon.Shoot();
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
