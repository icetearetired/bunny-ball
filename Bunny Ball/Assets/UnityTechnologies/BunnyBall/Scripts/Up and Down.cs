using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    public Vector3 moveDistance = new Vector3(1f, 0f, 0f); // how far it moves
    public float speed = 1f; // how fast it moves
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // sin() makes it go back and forth smoothly
        transform.position = startPos + moveDistance * Mathf.Sin(Time.time * speed);
    }
}
