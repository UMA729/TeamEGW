using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    private float MoveSpeed = 3.0f;
    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * MoveSpeed, 0, 0);
    }
}
