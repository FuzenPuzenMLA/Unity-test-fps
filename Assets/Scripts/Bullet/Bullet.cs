using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] private protected float speed;
    
    private float MaxShootDistance;
    private float timeToDestroy;
    internal int Damage;
    internal Vector3 direction;

    internal void InitValues(float MaxShootDistance, int Damage, Vector3 direction)
    {
        this.MaxShootDistance = MaxShootDistance;
        this.Damage = Damage;
        this.direction = direction;
    }

    private protected virtual void MoveForvard()
    {
        transform.Translate(direction * speed * Time.deltaTime); 
    }

    private protected virtual void DestroyBulletOnMaxDistance()
    {
        timeToDestroy = MaxShootDistance / speed; // t = s/u;
        Destroy(gameObject, timeToDestroy);
        /* Vector3.Distance() довольно "тяжёлая" функция, а такой способ 
           эффективнее в плане производительности чем считать каждый кадр пройденное расстояние */
    }

    private protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyHp>())
        { 
            other.GetComponent<EnemyHp>().TakeDamage(Damage);
        }
        if (other.GetComponent<PlayerHp>())
        {
            other.GetComponent<PlayerHp>().TakeDamage(Damage);
        }
        Destroy(gameObject);
    }
}
