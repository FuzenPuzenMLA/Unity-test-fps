using UnityEngine;

public class KeyboardMoveInput : MoveInput
{
    private const string XMovement = "Horizontal"; // Дефолтные названия ввода Юнити
    private const string ZMovement = "Vertical";

    private float xMovement;
    private float zMovement;

    private Vector3 direction;
    public override Vector3 GetVectorDir()
    {
        xMovement = Input.GetAxis(XMovement) * Time.deltaTime;
        zMovement = Input.GetAxis(ZMovement) * Time.deltaTime;
        direction = transform.right * xMovement + transform.forward * zMovement;
        return direction;
    }

}
