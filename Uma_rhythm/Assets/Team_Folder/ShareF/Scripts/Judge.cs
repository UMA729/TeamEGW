using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Judge : MonoBehaviour
{
    [SerializeField] private GameObject[] MessageObj;
    [SerializeField] NotesManager notesManager;
    public string resultScene;

    int cnt = 0;

    float end_time = 0.0f;

    void Start()
    {
        end_time = notesManager.NotesTime[notesManager.NotesTime.Count-1];
        cnt = 0;
    }

    void Update()
    {
        if (GManager.instance.Start)
        {
            //if(end_time+GManager.instance.StartTime-Time.time > 0)
            //Debug.Log("残り秒数" + (end_time + GManager.instance.StartTime - Time.time));

            if (Time.time > end_time + GManager.instance.StartTime + 0.3f)
            {
                Debug.Log("aiueo");
                Invoke("Result", 2f);//ノーツの終わり2秒後にリザルト関数へ
                return;
            }
            else if (Input.GetKey(KeyCode.Space))
            {
               
                if (notesManager.NoteType[0] == 5)
                {
                    {
                        if (Input.GetKeyDown("up"))
                            Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                    }
                }
                if (notesManager.NoteType[0] == 6)
                {
                    {
                        if (Input.GetKeyDown("left"))
                            Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                    }
                }
                if (notesManager.NoteType[0] == 7)
                {
                    {
                        if (Input.GetKeyDown("down"))
                            Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));

                    }
                }
                if (notesManager.NoteType[0] == 8)
                {
                    {
                        if (Input.GetKeyDown("right"))
                            Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));

                    }
                }
            }
            else
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

            }

            if (Time.time > notesManager.NotesTime[0] + 0.2f + GManager.instance.StartTime)//本来ノーツをたたくべき時間から0.2秒たっても入力がなかった場合
            {
                GManager.instance.combo = 0;
                GManager.instance.miss++;
                message(3);
                deleteData();
                //Debug.Log("Miss");
                //ミス
            }

          }

        //Debug.Log("現在時間T" + Time.time);

    }
    void Judgement(float timeLag)
    {
        if (timeLag <= 0.1f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.05秒以下だったら
        {
            //Debug.Log("Perfect");
            GManager.instance.perfect++;
            GManager.instance.combo++;
            message(0);
            deleteData();
        }
        else if (timeLag <= 0.2f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.3秒以下だったら
        {
            //Debug.Log("Good");
            GManager.instance.good++;
            GManager.instance.combo++;
            message(1);
            deleteData();
        }
        else if (timeLag <= 0.5f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.5秒以下だったら
        {
            //Debug.Log("Bad");
            GManager.instance.bad++;
            GManager.instance.combo = 0;
            message(2);
            deleteData();
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
        Debug.Log(notesManager.NoteType[0]);
        if (notesManager.NoteType[0] < 5)
        {
            Destroy(notesManager.NotesObj[cnt]);
        }
        notesManager.NotesTime.RemoveAt(0);
        notesManager.LaneNum.RemoveAt(0);
        notesManager.NoteType.RemoveAt(0);
        cnt++;
    }

    void message(int judge)//判定を表示する
    {
        GameObject Message= Instantiate(MessageObj[judge],
        new Vector3(0.5f, 1.5f, 1.0f), Quaternion.Euler(0, 0, 0));

        Destroy(Message,0.5f);
    }

    void Result()
    {
        SceneManager.LoadScene(resultScene);//リザルトシーンへ移動
    }
}