
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
    int NoteSpeed = 10;
    bool start;
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