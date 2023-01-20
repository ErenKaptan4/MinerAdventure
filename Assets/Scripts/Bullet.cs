using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Bullet : MonoBehaviour
{
    public Text ScoreText;

    [SerializeField] protected float speed;
    void Update()
    {
        ScoreText.text = GameData.Score.ToString();
    }

    protected virtual void OnEnable()
    {
        Vector2 direction = new Vector2(3f, 0);
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            //This will happen when bullet hit zombie
            Destroy(other.gameObject);
            GameData.Score++;
            Debug.Log("Hit Zombie: " + GameData.Score);
            ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        }
    }

}
