using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpHolders : MonoBehaviour
{
    [SerializeField] private protected int maxHp;
    [SerializeField] private protected int CurrentHp;

    private void Awake()
    {
        CurrentHp = maxHp;
    }

    internal virtual void TakeDamage(int _damage)
    {
        CurrentHp -= _damage;
        CheckHpStatus();
    }

    private protected void CheckHpStatus()
    {
        if (CurrentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
