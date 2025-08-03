using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float scrollSpeed = 2f;       // �����̴� �ӵ�
    public float resetPositionX = 20f;   // �� ��ġ�� ������ �ǵ���
    public float startPositionX = -20f;  // �ǵ��� ��ġ

    void Update()
    {
        transform.position += Vector3.right * scrollSpeed * Time.deltaTime;

        if (transform.position.x >= resetPositionX)
        {
            transform.position = new Vector3(startPositionX, transform.position.y, transform.position.z);
        }
    }
}

