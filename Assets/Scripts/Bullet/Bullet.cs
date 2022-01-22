using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] private protected float speed;
    internal int Damage { get; set; }
    internal float MaxShootDistance { get; set; }
    private float timeToDestroy;

    internal void InitValues(float MaxShootDistance, int Damage)
    {
        this.MaxShootDistance = MaxShootDistance;
        this.Damage = Damage;
    }

    private protected virtual void MoveForvard()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // ����������
    }

    private protected virtual void DestroyBulletOnMaxDistance()
    {
        timeToDestroy = MaxShootDistance / (speed * Time.deltaTime); // t = s/u;
        Destroy(gameObject, timeToDestroy);
        // ����� ������ ����������� � ����� ������������������ ��� ������� ������ ���� Vector3.Distance()
    }

    private protected virtual void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
