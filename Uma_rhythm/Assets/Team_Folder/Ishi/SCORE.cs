using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class SCORE : MonoBehaviour
{
    public Text RealScoreText;
    public Text ComboText;
    public GameObject TextCombo;
    public GameObject TextCombo2;

    int Real;
    int Combo;


    // Update is called once per frame
    void Update()
    {
        Real = Judge.GetScore();
        RealScoreText.text = string.Format("{0}", Real);

        Combo = Judge.GetCombo();
        ComboText.text = string.Format("{0}", Combo);
        if (Combo != 0)
        {
            TextCombo.SetActive(true);
            TextCombo2.SetActive(true);

        }
        else
        {
            TextCombo.SetActive(false);
            TextCombo2.SetActive(false);
        }
  
    }
}
