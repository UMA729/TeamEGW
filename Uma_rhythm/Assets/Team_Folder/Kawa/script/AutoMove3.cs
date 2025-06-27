using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove3 : MonoBehaviour
{
    private float MoveSpeed = 6.0f;
    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * MoveSpeed, -2, 0);
    }
}
