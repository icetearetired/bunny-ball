using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBox : MonoBehaviour
{
    public GameObject deathUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(HandleDeath());
        }
    }

    private IEnumerator HandleDeath()
    {
        deathUI.SetActive(true);
        yield return new WaitForSeconds(4f);
        deathUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
