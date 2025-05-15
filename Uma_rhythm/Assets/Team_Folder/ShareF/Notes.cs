
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
    int NoteSpeed = 5;
    bool start;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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