using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemySO enemy;

    public Transform[] PatrolPoints;
    public float speed;
    public int destination;

    void Start()
    {
        speed = enemy.speed;
    }

    private void Update()
    {
        if (destination == 0)
        {
            //move towards gets 3 variables 1current possition, 2where that needs to go, 3speed
            transform.position = Vector2.MoveTowards(transform.position, PatrolPoints[0].position, speed * Time.deltaTime);
            //Distance calculates the distance between objects (between zombie and object)
            //2f is to check if they are close
            if (Vector2.Distance(transform.position, PatrolPoints[0].position) < .2f)
            {
                transform.localScale = new Vector3(-1, 1, 1);
                //what will happen when zombie close to destination
                destination = 1;
            }
        }
        if (destination == 1)
        {
            //move towards gets 3 variables 1current possition, 2where that needs to go, 3speed
            transform.position = Vector2.MoveTowards(transform.position, PatrolPoints[1].position, speed * Time.deltaTime);
            //Distance calculates the distance between objects (between zombie and object)
            //2f is to check if they are close
            if (Vector2.Distance(transform.position, PatrolPoints[1].position) < .2f)
            {
                transform.localScale = new Vector3(1, 1, 1);
                //what will happen when zombie close to destination
                destination = 0;
            }
        }
    }
}
