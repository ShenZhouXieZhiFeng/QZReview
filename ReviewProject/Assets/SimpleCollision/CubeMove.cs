using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float moveSpeed = 1;

    Vector3 moveVec = Vector3.zero;

    void Update()
    {
        var deltaTime = Time.deltaTime;
        moveVec = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
        {
            moveVec.x -= moveSpeed * deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveVec.x += moveSpeed * deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveVec.z += moveSpeed * deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveVec.z -= moveSpeed * deltaTime;
        }
        if (moveVec != Vector3.zero)
        {
            transform.position += moveVec;
        }
    }
}
