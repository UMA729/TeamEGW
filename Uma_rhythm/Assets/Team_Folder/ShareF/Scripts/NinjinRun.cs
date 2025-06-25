using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjinRun : MonoBehaviour
{
    public float speed = -30; // Start is called before the first frame update
    float NoteSpeed;
    public GameObject ninjinman;
    public GameObject ninjinman_pos;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        NoteSpeed = GManager.instance.noteSpeed;

        transform.position -= transform.right * Time.deltaTime * NoteSpeed;



        if (Input.GetKeyDown("up") ||
            Input.GetKeyDown("down") ||
            Input.GetKeyDown("left") ||
            Input.GetKeyDown("right") ||
            Input.GetKeyDown(KeyCode.W) ||
            Input.GetKeyDown(KeyCode.A) ||
            Input.GetKeyDown(KeyCode.S) ||
            Input.GetKeyDown(KeyCode.D) ||
            Input.GetKeyDown(KeyCode.Space))
        {
            GameObject cloneman;

            cloneman = Instantiate(ninjinman, ninjinman_pos.transform.position,Quaternion.identity);

            Destroy(cloneman, 0.3f);

        }

        if (transform.position.x < -9.2)
        {
            transform.position = new Vector3(9.2f, transform.position.y, 0);
        }

    }
}
