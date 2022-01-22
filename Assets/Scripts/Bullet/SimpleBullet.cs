using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : Bullet
{
    private void Start()
    {
        DestroyBulletOnMaxDistance();
    }

    private void Update()
    {
        MoveForvard();
    }
}
