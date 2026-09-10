using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody rb;
    public Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void Update()
    {

        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            Debug.Log("rest");
        }
        Vector3 movement = new Vector3(moveInput.x, 0.0f, moveInput.y);
        rb.MovePosition(transform.position + movement * speed * Time.deltaTime);
    }
}