using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove2 : MonoBehaviour
{
    private float MoveSpeed = 4.0f;
    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Sin(Time.time) * MoveSpeed, -1, 0);
    }
}
