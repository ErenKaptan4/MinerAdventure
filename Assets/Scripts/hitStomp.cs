using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HitStomp : Enemy
{
    private int amount;
    public float bounce;
    public Rigidbody2D myRigidbody;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            //This will happen when step on zombie
            Destroy(other.gameObject);

            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, bounce);
            amount++;
            GameData.Score += amount;
            Debug.Log("Stoped on zombie1: " + amount);
            scoreText.text = "Score: " + GameData.Score;
        }
    }
}
