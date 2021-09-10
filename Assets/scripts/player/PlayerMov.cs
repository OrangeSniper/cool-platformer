using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMov : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;
    private PlayerInputActions inputActions;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        inputActions = new PlayerInputActions();
        inputActions.Movment.Enable();

    }

    private void FixedUpdate()
    {
        Vector2 inputVector = new Vector2(inputActions.Movment.Movment.ReadValue<float>() * speed, 0f);
        rb.velocity = new Vector2(inputVector.x * speed, rb.velocity.y);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        Debug.Log("jump");
        if(context.performed)
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }
}
