
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
            //�m�[�c���ړ�������
            transform.position -= transform.right * Time.deltaTime * NoteSpeed;
        }
    }
}