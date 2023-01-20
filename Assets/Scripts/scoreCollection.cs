using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCollection : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();

        if (collision.gameObject.CompareTag("Diamond"))
        {
            //if collided with "Diamond" destroy it and add score
            Destroy(collision.gameObject);
            GameData.Score++;
            Debug.Log("Diamond collected: " + GameData.Score);
            scoreText.text = "Score: " + GameData.Score;

        }
    }
}
