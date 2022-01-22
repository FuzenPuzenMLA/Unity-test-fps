using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private PlayerWeaponList playerWeaponList;
    [SerializeField] private ShootInput shootInput;

    private void Awake()
    {
        shootInput.Init(Shooting);
    }
    private void Shooting()
    {
        playerWeaponList.currentWeapon.Shoot();
    }
}
