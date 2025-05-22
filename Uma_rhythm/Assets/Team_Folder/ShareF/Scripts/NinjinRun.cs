using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjinRun : MonoBehaviour
{
    public float speed = -30;
    Rigidbody2D rigidbody;    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector2(-speed, rigidbody.velocity.y);

        if (transform.position.x < -9.2)
        {
            transform.position = new Vector3(9.2f, transform.position.y, 0);
        }

    }
}
