using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_horserun : MonoBehaviour
{
    float RunSpeed = 0;
    float sumspeed = 0;
    float SpeedNum = 0;
    public bool Hol = false;
    NotesManager notes;

    // Start is called before the first frame update
    void Start()
    {
        notes = FindObjectOfType<NotesManager>();
        SpeedNum += notes.noteNum;
    }

    // Update is called once per frame
    void Update()
    {
        if (GManager.instance.Start)
        {
            transform.position += Vector3.right * RunSpeed * Time.deltaTime;

            if (Hol == false)
            {
                esc(0);
            }
        }
    }

    public void UmaSpeed(float judge)
    {
        if (judge == 0)
        {
            esc(5f/SpeedNum);
            holder(5f/SpeedNum);
        }
        else if (judge == 1)
        {
            esc(3f / SpeedNum);
            holder(3f / SpeedNum);
        }
        else if (judge == 2)
        {
            holder(-3f/SpeedNum);
        }
        else if (judge == 3)
        {
            holder(-4f/SpeedNum);
        }
    }

    void esc(float speed)
    {
        RunSpeed = 3;
        sumspeed += speed;

        if (notes.noteNum * 0.6 < notes.allNum[0])
        {
            RunSpeed = -sumspeed;
        }

    }

    void holder(float speed)
    {
        if (notes.noteNum * 0.7 < notes.allNum[0])
        {
            Debug.Log(RunSpeed);

            RunSpeed += sumspeed;
        }
        if(notes.noteNum *0.8 > notes.allNum[0])
        {
            sumspeed += speed;
        }
    }
}
