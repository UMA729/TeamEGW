
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    [SerializeField] Esc Esc;
    //ノーツのスピードを設定
    float NoteSpeed = 8;
    bool start;

    void Start()
    {
        NoteSpeed = GManager.instance.noteSpeed;   
    }
    void Update()
    {
        if (Esc.time == false)
        {
            return;
        }
        if (Time.timeSinceLevelLoad > 4f)
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