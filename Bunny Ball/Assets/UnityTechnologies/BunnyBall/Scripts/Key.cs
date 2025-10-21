using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // This is a variable for the shockwave Prefab
    [SerializeField] GameObject shockwavePrefab;
    // This is a variable for the game Manager
    [SerializeField] GameManager gameManager;

    // This function runs once at the beginning of the game
    private void Start()
    {
        // Finds the gameManager
        gameManager = FindObjectOfType<GameManager>();
    }

    // This function runs when we collide with the trigger
    private void OnTriggerEnter(Collider other)
    {
        // check if we collide with the player
        if (other.CompareTag("Player")) {
            // If we do collide with something tagged as player

            // sets game over to true
            gameManager.gameOver = true;
            //creates a shockwave
            Instantiate(shockwavePrefab, transform.position, Quaternion.identity);
            // destroys key
            Destroy(gameObject, 0.1f);
        }
    }
}
