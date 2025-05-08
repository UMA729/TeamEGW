using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Flowing : MonoBehaviour
{
    
    public float speed;      //スピード
    public float resetPosX = 10.0f; //どの位置で戻るか

    private Vector3 OriginalPos;

    // Start is called before the first frame update
    void Start()
    {
        OriginalPos = transform.position; //初期位置を保存
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x <= OriginalPos.x + resetPosX)
        {
            transform.position = OriginalPos;
        }
    }
}
