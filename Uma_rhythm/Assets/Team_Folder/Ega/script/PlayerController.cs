using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5; //Playerのスピード
    public float y = 3;

    private Vector3 Originalpos;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Originalpos;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Wキーが押されています");
            transform.position += Vector3.up / y;

        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Dキーが押されています");
            transform.position += Vector3.right * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Aキーが押されています");
            transform.position += Vector3.left * speed;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("スペースキーが押された");
            transform.position += Vector3.up / y;

        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("スペースキーが離された！");
        }
    }
}
