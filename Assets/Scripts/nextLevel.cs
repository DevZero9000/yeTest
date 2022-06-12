using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        int score = playerScore.score;
        if (target.tag == "Player" && score >= 50)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //score = 0;
    }
}
