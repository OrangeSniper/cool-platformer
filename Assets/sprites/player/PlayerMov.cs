using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        Debug.Log("jump");
        rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
    }
}
