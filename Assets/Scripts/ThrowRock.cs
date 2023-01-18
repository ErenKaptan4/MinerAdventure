using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowRock : MonoBehaviour
{
    public void CannonFire(GameObject mybullet)
    {
        if (mybullet != null)
        {
            mybullet.transform.position = this.transform.position;
            mybullet.SetActive(true);
        }
    }
}
