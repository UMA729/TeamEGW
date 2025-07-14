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
        Application.targetFrameRate = 60; // ‰Šúó‘Ô‚Í-1‚É‚È‚Á‚Ä‚¢‚é

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

    public  void DeleteData()
    {

        GManager.instance.score = 0;
        GManager.instance.perfect = 0;
        GManager.instance.good = 0;
        GManager.instance.bad = 0;
        GManager.instance.miss = 0;
        GManager.instance.combo = 0;
    }
}
