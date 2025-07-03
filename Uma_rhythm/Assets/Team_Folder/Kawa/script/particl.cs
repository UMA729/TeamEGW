using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particl : MonoBehaviour
{
    private Vector3 objPosition;
    [SerializeField] GameObject particle;

    void Update()
    {
        if (Input.GetKeyDown("up") ||
            Input.GetKeyDown("down") ||
            Input.GetKeyDown("left") ||
            Input.GetKeyDown("right") ||
            Input.GetKeyDown(KeyCode.W) ||
            Input.GetKeyDown(KeyCode.A) ||
            Input.GetKeyDown(KeyCode.S) ||
            Input.GetKeyDown(KeyCode.D) ||
            Input.GetKeyDown(KeyCode.Space)) // 左クリックを検出
        {
            Instantiate(particle, transform.position, transform.rotation); // パーティクルを生成
        }
    }
}
