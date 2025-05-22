
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    void Awake()
    {
        Application.targetFrameRate = 60; // ������Ԃ�-1�ɂȂ��Ă���
    }
    //�m�[�c�̃X�s�[�h��ݒ�
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
            //�m�[�c���ړ�������
            transform.position -= transform.right * Time.deltaTime * NoteSpeed;
        }
    }
}