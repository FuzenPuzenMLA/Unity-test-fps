using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private MoveInput moveInput;
    [SerializeField] private float speed;
    [SerializeField] private CharacterController characterController;

    void Start()
    {
        if (characterController == null)
        {
            characterController = transform.GetComponent<CharacterController>();
        }
    }

    internal void PlayerMove(Vector3 _direction)
    {
        characterController.Move(_direction * speed);
    }


    private void Update()
    {
        PlayerMove(moveInput.GetVectorDir());
    }
}
