using UnityEngine;

public class MouseLookInput : LookInput
{
    private const string MouseX = "Mouse X"; // Дефолтные названия ввода Юнити
    private const string MouseY = "Mouse Y";

    [SerializeField] private float mouseSenitivity; // чувствительность мыши
    // если будет использован другой способ ввода(например геймпад/джойстик/VR контроллер) то у него должна быть своя чувствительность

    private float mouseX;
    private float mouseY;

    public override Vector2 GetVectorLook()
    {
        mouseX = Input.GetAxis(MouseX) * mouseSenitivity * Time.deltaTime;  // Time.deltaTime для исключения пробелов при потере FPS
        mouseY = -Input.GetAxis(MouseY) * mouseSenitivity * Time.deltaTime; // минус здесь для отключения инверсии мыши   
        return new Vector2(mouseX, mouseY);
    }
}
