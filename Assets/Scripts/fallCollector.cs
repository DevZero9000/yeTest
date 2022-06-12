using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallCollector : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Player")
        {
            Die();
        }
    }
    public void Die()
    {
        SceneManager.LoadScene("GameOver");
    }
}
