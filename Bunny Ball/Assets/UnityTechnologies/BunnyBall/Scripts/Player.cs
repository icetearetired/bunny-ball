using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Transform cameraTransform;
    public GameManager gameManager;
    public int speed = 10;
    public int jumpForce = 400;
    public float accelerationMultiplier = 0.3f;
    private int x = 0;
    private bool isGrounded = false;
    private bool doubleJump = false;

    void Update()
    {
        x = x + 1;
        // Debug.Log(message: "Hello from " + x);

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;
        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();
        Vector3 direction = forward * moveVertical + right * moveHorizontal;
        rb.AddForce(direction * speed * accelerationMultiplier);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            Debug.Log("pressed space");
            rb.AddForce(Vector3.up * jumpForce);
            doubleJump = true;
        }

        if (isGrounded == false && doubleJump == true && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("double jump");
            rb.AddForce(Vector3.up * jumpForce);
            doubleJump = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
