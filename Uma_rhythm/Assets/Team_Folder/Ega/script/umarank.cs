using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class umarank : MonoBehaviour
{

    public float Speed = 5; //Playerのスピード

    public umarank(float speed)
    {
        Speed = speed;
    }

    public Vector3 Originalpos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Originalpos;
    }


    void Judgement(float timeLag)
    {
        if (timeLag <= 0.1f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.05秒以下だったら
        {
            Debug.Log("Aキーが押されています");
            transform.position += Vector3.left * Speed;

        }
        else if (timeLag <= 0.2f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.3秒以下だったら
        {

        }
        else if (timeLag <= 0.5f)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.5秒以下だったら
        {
            Debug.Log("Dキーが押されています");
            transform.position += Vector3.right * Speed;

        }

    }

}
