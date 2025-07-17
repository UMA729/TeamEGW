using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class umarank : MonoBehaviour
{
    
    public float Speed = 5; //Playerのスピード
    [SerializeField]Transform PtoG;
    public umarank(float speed)
    {
        Speed = speed;
    }

   

    // Start is called before the first frame update
    void Start()
    {
    }

    public void UmaRankP()
    {
        transform.position = Vector3.MoveTowards(transform.position,PtoG.position,-Speed*Time.deltaTime);

        Debug.Log("wwwww");
    }
    public void UmaRankG()
    {
        transform.position = Vector3.MoveTowards(transform.position, PtoG.position, -Speed * Time.deltaTime);

    }
    public void UmaRankB()
    {
        transform.position = Vector3.MoveTowards(transform.position, PtoG.position, Speed * Time.deltaTime);

    }
    public void UmaRankM()
    {
        transform.position = Vector3.MoveTowards(transform.position, PtoG.position, Speed * Time.deltaTime);

    }
}
