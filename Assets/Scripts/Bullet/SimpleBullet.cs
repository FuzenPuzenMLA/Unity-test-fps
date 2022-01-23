
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
