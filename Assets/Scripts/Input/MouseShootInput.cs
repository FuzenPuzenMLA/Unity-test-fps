using UnityEngine;

public class MouseShootInput : ShootInput
{
    shootInput ShootInput;

    void Start()
    {
        
    }

    internal override void Init(shootInput ShootInput)
    {
        this.ShootInput = ShootInput;
    }


    internal override void Shooting()
    {
        ShootInput?.Invoke();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shooting();
        }
    }

}
