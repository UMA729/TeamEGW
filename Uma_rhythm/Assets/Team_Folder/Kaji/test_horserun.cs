using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_horserun : MonoBehaviour
{
    float RunSpeed = 0;
    float holspeed = 0;
    public bool Hol = false;
    NotesManager notes;

    // Start is called before the first frame update
    void Start()
    {
        RunSpeed = notes.noteNum;
    }

    // Update is called once per frame
    void Update()
    {
        if (Hol == false)
        {
            esc();
        }
        transform.position = Vector3.right * RunSpeed * Time.deltaTime;
    }

    void esc()
    {
        RunSpeed /= 2;
    }

    void holder(float speed)
    {


        if((int)notes.noteNum*0.7 > notes.LaneNum[0])
        holspeed += speed;
        else
        {
            RunSpeed = holspeed;
        }
    }
}
