using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpForce;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            Move(horizontalInput * movementSpeed);
        }
    }

    private void Move(float moveSpeed)
    {
        rb.AddForce(new Vector2(movementSpeed, 0));
    }
}
