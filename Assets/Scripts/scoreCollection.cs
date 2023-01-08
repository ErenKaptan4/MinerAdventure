using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreCollection : MonoBehaviour
{
    public int totalScore = 0;

    public TextMeshProUGUI scoreText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();

        if (collision.gameObject.CompareTag("Diamond"))
        {
            //if collided with "Diamond" destroy it and add score
            Destroy(collision.gameObject);
            totalScore++;
            GameData.Score += totalScore;
            Debug.Log("Diamond collected: " + totalScore);
            scoreText.text = "Score: " + totalScore;
        }
    }
}
