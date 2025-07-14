using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GManager : MonoBehaviour
{
    public static GManager instance = null;

    public int songID;
    public float noteSpeed;

    public bool Start;
    public float StartTime;

    public int combo;
    public int maxcombo;
    public int score;

    public int perfect;
    public int great;
    public int good;
    public int bad;
    public int miss;

    public GameObject backImage;
    public void Awake()
    {
        Application.targetFrameRate = 60; // èâä˙èÛë‘ÇÕ-1Ç…Ç»Ç¡ÇƒÇ¢ÇÈ

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    public  void resetData()
    {
        if (Esc.isResuming)
        {
            Esc.isResuming = false;
        }
        if (Esc.isPaused)
        {
            Esc.isPaused = false;
        }
        score = 0;
        perfect = 0;
        good = 0;
        bad = 0;
        miss = 0;
        combo = 0;
    }
}
