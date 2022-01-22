using UnityEngine;

public class MouseLookInput : LookInput
{
    private const string MouseX = "Mouse X"; // ��������� �������� ����� �����
    private const string MouseY = "Mouse Y";

    [SerializeField] private float mouseSenitivity; // ���������������� ����
    // ���� ����� ����������� ������ ������ �����(�������� �������/��������/VR ����������) �� � ���� ������ ���� ���� ����������������

    private float mouseX;
    private float mouseY;

    public override Vector2 GetVectorLook()
    {
        mouseX = Input.GetAxis(MouseX) * mouseSenitivity * Time.deltaTime;  // Time.deltaTime ��� ���������� �������� ��� ������ FPS
        mouseY = -Input.GetAxis(MouseY) * mouseSenitivity * Time.deltaTime; // ����� ����� ��� ���������� �������� ����   
        return new Vector2(mouseX, mouseY);
    }
}
