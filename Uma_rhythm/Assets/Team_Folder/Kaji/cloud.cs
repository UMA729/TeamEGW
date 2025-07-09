 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cloud : MonoBehaviour
{
    [SerializeField] Sprite[] images;
    [SerializeField] Image image;
    public RectTransform cloudman;
    public float img_speed;
    public float ResetPos;
    int RandomNumP = 0;
    int RandomNumI = 0;

    // Start is called before the first frame update
    void Start()
    {
        RandomNumP = Random.Range(160, 460);
        cloudman.anchoredPosition = new Vector2(1110, RandomNumP);
    }

    // Update is called once per frame
    void Update()
    {
        cloudman.anchoredPosition -= new Vector2(img_speed, 0) * Time.deltaTime;

        if (cloudman.anchoredPosition.x <= ResetPos)
        {
            cloudman.anchoredPosition = new Vector2(1110, RandomNumP);

            RandomNumP = Random.Range(160, 460);
            RandomNumI = Random.Range(0, 100);
            if (0 < RandomNumI && RandomNumI < 70)
            {
                RandomNumI = 0;
            }
            else if (70 <= RandomNumI && RandomNumI <= 98)
            {
                RandomNumI = 1;
            }
            else
            {
                RandomNumI = 2;
            }
        image.overrideSprite = images[RandomNumI];
        }

    }
}
