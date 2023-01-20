using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollection : MonoBehaviour
{
    public Text ScoreText;

    void Update()
    {
        ScoreText.text = GameData.Score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Diamond"))
        {
            //if collided with "Diamond" destroy it and add score
            Destroy(collision.gameObject);
            GameData.Score++;
            Debug.Log("Diamond collected: " + GameData.Score);
            ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        }
    }
}
