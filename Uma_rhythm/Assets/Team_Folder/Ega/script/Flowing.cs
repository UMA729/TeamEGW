using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Flowing : MonoBehaviour
{
    
    public float speed;      //�X�s�[�h
    public float resetPosX = 10.0f; //�ǂ̈ʒu�Ŗ߂邩

    private Vector3 OriginalPos;

    // Start is called before the first frame update
    void Start()
    {
        OriginalPos = transform.position; //�����ʒu��ۑ�
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
