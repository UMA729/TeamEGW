using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Judge : MonoBehaviour
{
    [SerializeField] private GameObject[] MessageObj;
    [SerializeField] NotesManager notesManager;
    umarank umarank;
    public string resultScene;
    public Text ScoreText;

    public float Speed = 5; //Playerのスピード
    public Vector3 Originalpos;


    int cnt = 0;

    float end_time = 0.0f;

    public static int GetScore()
    {
        return GManager.instance.score;
    }

    public static int GetPerfect()
    {
        return GManager.instance.perfect;
    }
    public static int GetGood()
    {
        return GManager.instance.good;
    }
    public static int GetBad()
    {
        return GManager.instance.bad;
    }
    public static int GetMiss()
    {
        return GManager.instance.miss;
    }
    public static int GetCombo()
    {
        return GManager.instance.combo;
    }
    public static int GetMaxCombo()
    {
        return GManager.instance.maxcombo;
    }
    void Start()
    {
        end_time = notesManager.NotesTime[notesManager.NotesTime.Count-1];
        cnt = 0;
    }

    void Update()
    {
        if (Esc.pause) return;

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
            else
            {
                if (notesManager.NoteType[0] == 1)
                {
                    if (Input.GetKeyDown("up") || Input.GetKeyDown(KeyCode.W))
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                    }
                }
                if (notesManager.NoteType[0] == 2)
                {
                    if (Input.GetKeyDown("left") || Input.GetKeyDown(KeyCode.A))
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                    }
                }
                if (notesManager.NoteType[0] == 3)
                {
                    if (Input.GetKeyDown("down") || Input.GetKeyDown(KeyCode.S))
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                    }
                }
                if (notesManager.NoteType[0] == 4)
                {
                    if (Input.GetKeyDown("right") || Input.GetKeyDown(KeyCode.D))
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)));
                    }
                }
                if(notesManager.NoteType[0] == 5)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
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
                //umarank.UmaRankM();
                //ミス
            }

        }

        //ScoreText.text = string.Format("{0}", GManager.instance.score);

        //Debug.Log("現在時間T" + Time.time);

    }
    void Judgement(float timeLag)
    {
        if (timeLag <= 0.1f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.05秒以下だったら
        {
            //Debug.Log("Perfect");
            transform.position += Vector3.left * Speed;

            GManager.instance.perfect++;
            GManager.instance.combo++;
            if (GManager.instance.combo >= GManager.instance.maxcombo)
            {
                GManager.instance.maxcombo = GManager.instance.combo;
            }
            GManager.instance.score += 1000;
            message(0);
            deleteData();
            //umarank.UmaRankP();
        }
        else if (timeLag <= 0.2f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.3秒以下だったら
        {
            //Debug.Log("Good");
            GManager.instance.good++;
            GManager.instance.combo++;
            if (GManager.instance.combo >= GManager.instance.maxcombo)
            {
                GManager.instance.maxcombo = GManager.instance.combo;
            }
            GManager.instance.score += 500;
            message(1);
            deleteData();
            //umarank.UmaRankG();
        }
        else if (timeLag <= 0.5f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.5秒以下だったら
        {
            //Debug.Log("Bad");
            transform.position += Vector3.right * Speed;


            GManager.instance.bad++;
            GManager.instance.combo = 0;
            GManager.instance.score += 100;
            message(2);
            deleteData();
            //umarank.UmaRankB();
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

        Destroy(notesManager.NotesObj[cnt]);
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