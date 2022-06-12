using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class playerScore : MonoBehaviour
{
    private TextMeshProUGUI coinAmount;
    public static int score = 0;
    void Start()
    {
        coinAmount = GameObject.Find("coinAmount").GetComponent<TextMeshProUGUI>();
        coinAmount.text = "0";
        score = 0;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag == "Coin")
        {
            target.gameObject.SetActive(false);
            score = score + 10;
            coinAmount.text = score.ToString();
        }
    }
}
