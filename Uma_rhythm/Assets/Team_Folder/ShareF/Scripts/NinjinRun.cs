using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjinRun : MonoBehaviour
{
    public float speed = -30; // Start is called before the first frame update
    float NoteSpeed;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        NoteSpeed = GManager.instance.noteSpeed;

        transform.position -= transform.right * Time.deltaTime * NoteSpeed;

        if (transform.position.x < -9.2)
        {
            transform.position = new Vector3(9.2f, transform.position.y, 0);
        }

    }
}
