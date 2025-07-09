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

    public void UmaRankP()
    {
        transform.position += Vector3.left * Speed;
        transform.position += Vector3.right * Speed;
    }
    public void UmaRankG()
    {
        transform.position += Vector3.left * Speed;
        transform.position += Vector3.right * Speed;
    }
    public void UmaRankB()
    {
        transform.position += Vector3.left * Speed;
        transform.position += Vector3.right * Speed;
    }
    public void UmaRankM()
    {
        transform.position += Vector3.left * Speed;
        transform.position += Vector3.right * Speed;
    }
}
