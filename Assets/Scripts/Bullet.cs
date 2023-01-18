using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
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

    
}
