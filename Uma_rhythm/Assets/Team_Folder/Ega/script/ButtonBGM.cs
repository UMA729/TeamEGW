using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonBGM : MonoBehaviour
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("マウスが" + gameObject.name + "に触れた");
        // 何かしらの処理
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("マウスが" + gameObject.name + "から離れた");
    }
}
