using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fullcombo : MonoBehaviour
{
    int Bad;
    int Miss;
    public GameObject FullCombo;
    void Start()
    {
        Bad = Judge.GetBad();
        Miss = Judge.GetMiss();
        if (Bad == 0 && Miss == 0)
        {
            FullCombo.SetActive(true);
        }
        else
        {
            FullCombo.SetActive(false);
        }
    }


}
