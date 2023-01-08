using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCollection : MonoBehaviour
{
    public int totalScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Diamond"))
        {
            //if collided with "Diamond" destroy it and add score
            Destroy(collision.gameObject);
            totalScore++;
            GameData.Score += totalScore;
            Debug.Log("Diamond collected: " + totalScore);
        }
    }
}
