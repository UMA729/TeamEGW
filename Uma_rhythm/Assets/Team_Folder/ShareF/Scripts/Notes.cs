
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    
    //ノーツのスピードを設定
    float NoteSpeed = 8;
    bool start;

    void Start()
    {
        NoteSpeed = GManager.instance.noteSpeed;   
    }
    void Update()
    {
        if (Time.time > Time.time+1.5f)
        {
            start = true;
        }
        if (start)
        {
            //ノーツを移動させる
            transform.position -= transform.right * Time.deltaTime * NoteSpeed;
        }
    }
}