using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float scrollSpeed = 2f;       // 움직이는 속도
    public float resetPositionX = 20f;   // 이 위치를 넘으면 되돌림
    public float startPositionX = -20f;  // 되돌릴 위치

    void Update()
    {
        transform.position += Vector3.right * scrollSpeed * Time.deltaTime;

        if (transform.position.x >= resetPositionX)
        {
            transform.position = new Vector3(startPositionX, transform.position.y, transform.position.z);
        }
    }
}

