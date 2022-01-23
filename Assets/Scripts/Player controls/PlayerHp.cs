using System.Collections;
using UnityEngine;

public class PlayerHp : HpHolders
{
    [SerializeField] private float regenHPDelay;

    private IEnumerator WaitRegenHPDelay()
    {
        yield return new WaitForSecondsRealtime(regenHPDelay);
        RegenHp();
    }

    // так же можно резать входящий урон бронёй здесь
    internal override void TakeDamage(int _damage)
    {
        CurrentHp -= _damage;
        CheckHpStatus();
        RegenHp();
    }

    // добавим немного регенерации Hp игроку
    public void RegenHp()
    {
        if (CurrentHp < maxHp)
        {
            StartCoroutine(WaitRegenHPDelay());
            CurrentHp++;
        }
    }
}
