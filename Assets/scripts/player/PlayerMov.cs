using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMov : MonoBehaviour
{
    //base movment
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;
    private PlayerInputActions inputActions;
    public int curJumps;
    public int jumps = 2;
    public GameObject GCheckPoint;

    public bool facingRight = true;

    private void Awake()
    {
        //movement
        rb = GetComponent<Rigidbody2D>();

        inputActions = new PlayerInputActions();
        inputActions.Movment.Enable();

        //inventory
        inventory = new Inventory();

        uiInventory.SetInventory(inventory);
        uiInventory.SetPlayer(this);

    }
    private void Start()
    {
        curJumps = jumps;
    }

    private void FixedUpdate()
    {
        Vector2 inputVector = new Vector2(inputActions.Movment.Movment.ReadValue<float>() * speed, 0f);
        rb.velocity = new Vector2(inputVector.x * speed, rb.velocity.y);
        //Debug.Log(GCheck());
        if(GCheck())
        {
            curJumps = jumps;
        }

        if(inputVector.x >= 0)
        {
            facingRight = true;
        }else
        {
            facingRight = false;
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        //Debug.Log("jump");
        if(context.performed && curJumps > 1)
        {
            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            curJumps--;
        }
    }

    public bool GCheck()
    {
        RaycastHit2D cast = Physics2D.Raycast(GCheckPoint.transform.position, Vector2.down);
        if(cast.distance <= .01f)
        {
            return true;
        }else
        {
            return false;
        }
    }

    //inventory
    private Inventory inventory;

    [SerializeField] private UI_Inventory uiInventory;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        ItemWorld itemWorld = collision.GetComponent<ItemWorld>();
        if (itemWorld != null)
        {
            //touching item
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
    }
}
