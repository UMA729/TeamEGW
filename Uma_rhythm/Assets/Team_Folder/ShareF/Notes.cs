
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
    int NoteSpeed = 10;
    void Update()
    {
        //�m�[�c���ړ�������
        transform.position -= transform.right * Time.deltaTime * NoteSpeed;
    }
}