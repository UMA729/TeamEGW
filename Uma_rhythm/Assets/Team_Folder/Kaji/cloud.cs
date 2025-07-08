 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cloud : MonoBehaviour
{
    public RectTransform cloudman;
    public float img_speed;
    public float ResetPos;
    Vector2 img_pos;

    // Start is called before the first frame update
    void Start()
    {
        img_pos = cloudman.anchoredPosition;
        cloudman.anchoredPosition = new Vector2(1110, 308);
    }

    // Update is called once per frame
    void Update()
    {
        cloudman.anchoredPosition -= new Vector2(img_speed, 0) * Time.deltaTime;
        if (cloudman.anchoredPosition.x <= ResetPos)
        {
            cloudman.anchoredPosition = img_pos;
        }

    }
}
