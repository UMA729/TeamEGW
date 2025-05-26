using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5; //Playerのスピード


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Wキーが押されています");

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("スペースキーが押された！（1回だけ）");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("スペースキーが離された！");
        }
    }
}
