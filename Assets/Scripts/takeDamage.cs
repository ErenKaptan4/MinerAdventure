using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeDamage : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private Animator animate;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if collided w trap
        if (collision.gameObject.CompareTag("trap"))
        {
            GameData.Lifes = 0;
            if (GameData.Lifes <= 0)
            {
                playerDie();
                GameManager.Instance.GameOver();
            }
            Debug.Log(GameData.Lifes);
        }
        //if collided w zombie
        if (collision.gameObject.CompareTag("Zombie"))
        {
            GameData.Lifes = GameData.Lifes - 1;
            if (GameData.Lifes <= 0)
            {
                playerDie();
                GameManager.Instance.GameOver();
            }
            Debug.Log(GameData.Lifes);
        }
    }

    private void playerDie()
    { 
        myRigidbody.bodyType = RigidbodyType2D.Static;
        animate.SetTrigger("death");
    }
}
