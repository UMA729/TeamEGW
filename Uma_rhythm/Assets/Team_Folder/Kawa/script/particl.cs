using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particl : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 objPosition;
    [SerializeField] GameObject particle;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 左クリックを検出
        {
            mousePosition = Input.mousePosition; // マウスのスクリーン座標を取得
            mousePosition.z = 10.0f; // カメラからの距離を設定
            objPosition = Camera.main.ScreenToWorldPoint(mousePosition); // ワールド座標に変換
            Instantiate(particle, objPosition, Quaternion.identity); // パーティクルを生成
        }
    }
}
