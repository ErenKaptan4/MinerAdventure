using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]private Transform playerPos;
    private void Update()
    {
        this.transform.position = new Vector3(playerPos.position.x, playerPos.position.y + 1, transform.position.z);
    }
}
