using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rock : Bullet
{
    protected override void OnEnable()
    {
        speed = 15f;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        GetComponent<Rigidbody2D>().gravityScale = 0f;
        base.OnEnable();
    }

    void OnBecameInvisible()
    {
        // Destroy(this.gameObject);
        this.gameObject.SetActive(false);
    }

}
