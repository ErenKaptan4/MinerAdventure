using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Bullet : MonoBehaviour
{
    public int amount = 0;
    public TextMeshProUGUI scoreText;

    [SerializeField] protected float speed = 0;

    Vector3 mousePoint3D;
    // Start is called before the first frame update
    protected virtual void Start()
    {

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
            amount++;
            GameData.Score += amount;
            Debug.Log("Stoped on zombie1: " + amount);
            scoreText.text = "Score: " + GameData.Score;
        }
    }

}
