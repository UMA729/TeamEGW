using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    [SerializeField] private GameObject[] MessageObj;
    [SerializeField] NotesManager notesManager;

    int cnt = 0;

    void Update()
    {
        if (GManager.instance.Start)
        {

            if (notesManager.NoteType[0] == 1)
            {
                if (Input.GetKeyDown("up"))
                {
                    Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                }
            }
            if (notesManager.NoteType[0] == 2)
            {
                if (Input.GetKeyDown("left"))
                {
                    Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                }
            }
            if (notesManager.NoteType[0] == 3)
            {
                if (Input.GetKeyDown("down"))
                {
                    Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                }
            }
            if (notesManager.NoteType[0] == 4)
            {
                if (Input.GetKeyDown("right"))
                {
                    Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                }
            }
            if (Time.time > notesManager.NotesTime[0] + 0.3f + GManager.instance.StartTime)//�{���m�[�c���������ׂ����Ԃ���0.2�b�����Ă����͂��Ȃ������ꍇ
            {
                message(3);
                deleteData();
                Debug.Log("Miss");
                //�~�X
            }

        }
    }
    void Judgement(float timeLag)
    {
        if (timeLag <= 0.05f)//�{���m�[�c���������ׂ����ԂƎ��ۂɃm�[�c�������������Ԃ̌덷��0.1�b�ȉ���������
        {
            Debug.Log("Perfect");
            message(0);
            deleteData();
        }
        else
        {
            if (timeLag <= 0.15f)//�{���m�[�c���������ׂ����ԂƎ��ۂɃm�[�c�������������Ԃ̌덷��0.15�b�ȉ���������
            {
                Debug.Log("Great");
                message(1);
                deleteData();
            }
            else
            {
                if (timeLag <= 0.30f)//�{���m�[�c���������ׂ����ԂƎ��ۂɃm�[�c�������������Ԃ̌덷��0.2�b�ȉ���������
                {
                    Debug.Log("Good");
                    message(2);
                    deleteData();
                }
            }
        }
    }
    float GetABS(float num)//�����̐�Βl��Ԃ��֐�
    {
        if (num >= 0)
        {
            return num;
        }
        else
        {
            return -num;
        }
    }
    void deleteData()//���łɂ��������m�[�c���폜����֐�
    {
        notesManager.NotesTime.RemoveAt(0);
        notesManager.LaneNum.RemoveAt(0);
        notesManager.NoteType.RemoveAt(0);
        Destroy(notesManager.NotesObj[cnt]);
        cnt++;
    }

    void message(int judge)//�����\������
    {
        GameObject Message= Instantiate(MessageObj[judge],
        new Vector3(0.5f, 1.5f, 1.0f), Quaternion.Euler(0, 0, 0));

        Destroy(Message,1.0f);
    }
}