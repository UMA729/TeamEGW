
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    void Awake()
    {
        Application.targetFrameRate = 60; // 初期状態は-1になっている
    }
    //ノーツのスピードを設定
    float NoteSpeed = 8;
    bool start;

    void Start()
    {
        NoteSpeed = GManager.instance.noteSpeed;   
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
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