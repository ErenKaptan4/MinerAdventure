using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreCollection : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();

        if (collision.gameObject.CompareTag("Diamond"))
        {
            //if collided with "Diamond" destroy it and add score
            Destroy(collision.gameObject);
            GameData.Score = GameData.Score + 1;
            Debug.Log("Diamond collected: " + GameData.Score);
            scoreText.text = "Score: " + GameData.Score;
        }
    }
}
