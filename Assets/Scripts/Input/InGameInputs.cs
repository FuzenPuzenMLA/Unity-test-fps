using UnityEngine;

public abstract class InGameInputs : MonoBehaviour
{
    internal abstract void ChangeWeapon(int weaponNumber);
    /* так же сюда добавится в последствии взаимодействие с окружением(поднятие предметов или открытие дверей)
     и персональные возможности игрока (перезарядка, взять в руки гранату, кинуть фаербол и т.д.)*/
}
