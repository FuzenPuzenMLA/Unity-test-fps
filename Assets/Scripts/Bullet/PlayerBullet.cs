using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
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
