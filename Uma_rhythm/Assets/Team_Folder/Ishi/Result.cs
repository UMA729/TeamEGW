using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public Text ScoreText;
    public Text PerfectText;
    public Text GoodText;
    public Text BadText;
    public Text MissText;
    public Text RealScoreText;
    int Score;
    int Perfect;
    int Good;
    int Bad;
    int Miss;
    int Real;


    // Start is called before the first frame update
    void Start()
    {
        Score = Judge.GetScore();
        ScoreText.text = string.Format("{0}", Score);

        Perfect = Judge.GetPerfect();
        PerfectText.text = string.Format("{0}", Perfect);

        Good = Judge.GetGood();
        GoodText.text = string.Format("{0}", Good);

        Bad = Judge.GetBad();
        BadText.text = string.Format("{0}", Bad);

        Miss = Judge.GetMiss();
        MissText.text = string.Format("{0}", Miss);
    }

    // Update is called once per frame
    void Update()
    {
        Real = Judge.GetScore();
        RealScoreText.text = string.Format("{0}", Real);
    }
}
