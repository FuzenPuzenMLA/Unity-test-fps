using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private LookInput lookInput;
    [SerializeField] private Transform cameraTransform; 
    [SerializeField] private Transform playerTransform;
    [Space(20)]
    [SerializeField] private float minViewAngleY; // крайние углы поворота камеры
    [SerializeField] private float maxViewAngleY;

    private float xRotation; // закешированные переменные для угла поворота
    private float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        PlayerSetEulerRotation(lookInput.GetVectorLook());
    }

    public void PlayerSetEulerRotation(Vector2 _lookDirection)
    {
        xRotation += _lookDirection.x;
        yRotation += _lookDirection.y;
        yRotation = Mathf.Clamp(yRotation, minViewAngleY, maxViewAngleY); // ограничение для поворота камеры
        PlayerCameraRotate(xRotation, yRotation);
    }

    public void PlayerCameraRotate(float _xRotation, float _yRotation)
    {            
        cameraTransform.localRotation = Quaternion.Euler(_yRotation, 0, 0);
        playerTransform.localRotation = Quaternion.Euler(0, _xRotation, 0);
    }
}
