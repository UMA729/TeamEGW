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
        if (Hol == false)
            RunSpeed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (GManager.instance.Start)
        {
            transform.position += Vector3.right * RunSpeed * Time.deltaTime;

        }
    }

    public void UmaSpeed(float judge)
    {
        if (judge == 0)
        {
            if (Hol == false)
                esc(5f/SpeedNum);
            else if(Hol == true)
                holder(5f / SpeedNum);
        }
        else if (judge == 1)
        {
            if (Hol == false)
                esc(3f / SpeedNum);
            else if(Hol==true)
                holder(3f / SpeedNum);
        }
        else if (judge == 2)
        {
            if (Hol == true)
                holder(-3f/SpeedNum);
        }
        else if (judge == 3)
        {
            if (Hol == true)
                holder(-4f/SpeedNum);
        }
    }

    void esc(float speed)
    {
        sumspeed += speed;

        if (notes.noteNum * 0.6 < notes.allNum[0])
        {
            Debug.Log("‚ ");
            RunSpeed = -sumspeed;
        }

    }

    void holder(float speed)
    {
        Debug.Log(notes.allNum[0]);
        if (notes.noteNum * 0.5 < notes.allNum[0])
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
