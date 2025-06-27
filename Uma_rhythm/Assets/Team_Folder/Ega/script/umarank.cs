using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class umarank : MonoBehaviour
{
    public float Speed = 5;

    public Vector3 Originalpos;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = Originalpos;

    }

    // Update is called once per frame
    void Update()
    {
        
        //if (Input.GetKey(KeyCode.D))
        //{
        //    Debug.Log("Dキーが押されています");
        //    transform.position += Vector3.right * Speed;
        //}

        //if (GManager.instance.score += 100)
        //{
            //Debug.Log("Aキーが押されています");
            //transform.position += Vector3.left * Speed;
        //}
    }
    //void Judgement(float timeLag)
    //{
    //    if (timeLag <= 0.1f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.05秒以下だったら
    //    {
    //        //Debug.Log("Perfect");
    //        GManager.instance.perfect++;
    //        GManager.instance.combo++;
    //        GManager.instance.score += 1000;
    //        transform.position += Vector3.left * Speed;


    //    }
    //    else if (timeLag <= 0.2f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.3秒以下だったら
    //    {
    //        //Debug.Log("Good");
    //        GManager.instance.good++;
    //        GManager.instance.combo++;
    //        GManager.instance.score += 500;
            
    //    }
    //    else if (timeLag <= 0.5f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.5秒以下だったら
    //    {
    //        //Debug.Log("Bad");
    //        GManager.instance.bad++;
    //        GManager.instance.combo = 0;
    //        GManager.instance.score += 100;
    //        transform.position += Vector3.right * Speed;


    //    }
    //}

}
