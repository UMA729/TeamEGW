using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    public Sprite[] numberSprites; // 0～9のスプライト
    public GameObject digitPrefab; // 桁ごとのImageプレハブ
    public Transform parentTransform; // 桁を配置する親オブジェクト
    private int number = 123;

    void Start()
    {
        string numberString = number.ToString();
        for (int i = 0; i < numberString.Length; i++)
        {
            int digit = int.Parse(numberString[i].ToString());
            GameObject digitObject = Instantiate(digitPrefab, parentTransform);
            digitObject.GetComponent<Image>().sprite = numberSprites[digit];
        }
    }
}
