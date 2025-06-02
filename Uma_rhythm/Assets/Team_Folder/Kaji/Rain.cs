using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
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
        if (Time.time > 1.5f)
        {
            start = true;
        }
        if (start)
        {
            if (transform.position.y > 0)
            {
                //ノーツを移動させる
                transform.position -= transform.up * Time.deltaTime * NoteSpeed;
            }
            else
            {

            }
        }
    }
}
