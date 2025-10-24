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
    private int x = 0;

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
        rb.AddForce(direction * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pressed space");
            rb.AddForce(Vector3.up * jumpForce);
        }
    }

}
