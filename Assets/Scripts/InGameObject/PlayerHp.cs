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

    internal override void TakeDamage(int _damage)
    {
        CurrentHp -= _damage;
        CheckHpStatus();
        RegenHp();
    }

    public void RegenHp()
    {
        if (CurrentHp < maxHp)
        {
            StartCoroutine(WaitRegenHPDelay());
            CurrentHp++;
        }
    }
}
