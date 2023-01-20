using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitStomp : Enemy
{
    public float bounce;
    public Rigidbody2D myRigidbody;
    public Text ScoreText;

    void Update()
    {
        ScoreText.text = GameData.Score.ToString();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            //This will happen when step on zombie
            Destroy(other.gameObject);

            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, bounce);
            GameData.Score++;
            Debug.Log("Stoped on zombie: " + GameData.Score);
            ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        }
    }
}
