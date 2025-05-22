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
            if (Time.time > notesManager.NotesTime[0] + 0.3f + GManager.instance.StartTime)//本来ノーツをたたくべき時間から0.2秒たっても入力がなかった場合
            {
                message(3);
                deleteData();
                Debug.Log("Miss");
                //ミス
            }

        }
    }
    void Judgement(float timeLag)
    {
        if (timeLag <= 0.05f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.1秒以下だったら
        {
            Debug.Log("Perfect");
            message(0);
            deleteData();
        }
        else
        {
            if (timeLag <= 0.15f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.15秒以下だったら
            {
                Debug.Log("Great");
                message(1);
                deleteData();
            }
            else
            {
                if (timeLag <= 0.30f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.2秒以下だったら
                {
                    Debug.Log("Good");
                    message(2);
                    deleteData();
                }
            }
        }
    }
    float GetABS(float num)//引数の絶対値を返す関数
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
    void deleteData()//すでにたたいたノーツを削除する関数
    {
        notesManager.NotesTime.RemoveAt(0);
        notesManager.LaneNum.RemoveAt(0);
        notesManager.NoteType.RemoveAt(0);
        Destroy(notesManager.NotesObj[cnt]);
        cnt++;
    }

    void message(int judge)//判定を表示する
    {
        GameObject Message= Instantiate(MessageObj[judge],
        new Vector3(0.5f, 1.5f, 1.0f), Quaternion.Euler(0, 0, 0));

        Destroy(Message,1.0f);
    }
}