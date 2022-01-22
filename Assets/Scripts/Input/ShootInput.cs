using UnityEngine;

public abstract class ShootInput : MonoBehaviour
{
    public delegate void shootInput();
    internal abstract void Shooting();
    internal abstract void Init(shootInput _shootInput);
}
