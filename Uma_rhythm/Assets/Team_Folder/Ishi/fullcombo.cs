using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fullcombo : MonoBehaviour
{
    int Bad;
    int Miss;
    [SerializeField] Text text;
    void Start()
    {
        Bad = Judge.GetBad();
        Miss = Judge.GetMiss();
        if (Bad == 0 && Miss == 0)
        {
            text.enabled = true;
        }
        else
        {
            text.enabled = false;
        }
    }


}
