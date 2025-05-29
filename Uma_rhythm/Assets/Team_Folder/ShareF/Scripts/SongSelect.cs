using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SongSelect : MonoBehaviour
{
    [SerializeField] SongDataBase dataBase;
    [SerializeField] TextMeshProUGUI[] songNameText;
    [SerializeField] Image songImage;

    AudioSource audio;
    AudioClip Music;
    string songName;

    int select;

    // Start is called before the first frame update
    void Start()
    {
        select = 0;
        audio = GetComponent<AudioSource>();
        songName = dataBase.SongDatas[select].SongName;
        Music = (AudioClip)Resources.Load("/Music" + songName);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up"))
        {
            if (select < dataBase.SongDatas.Length)
            {               
            select++;
            SongUpdateALL();
            }
        }  
        if(Input.GetKeyDown("down"))
        {
            if (select > 0)
            {               
            select--;
            SongUpdateALL();
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
    void SongUpdateALL()
    {
        songName = dataBase.SongDatas[select].SongName;
        Music = (AudioClip)Resources.Load("/Music" + songName);
        audio.Stop();
        audio.PlayOneShot(Music);
        for(int i=0;i<5;i++)
        {
            SongStart(i - 2);
        }
    }
    void SongStart(int id)
    {
        try
        {
            songNameText[id + 2].text = dataBase.SongDatas[select + id].SongName;
        }
        catch
        {
            songNameText[id + 2].text = "";
        }
        if(id == 0)
        {
            songImage.sprite = dataBase.SongDatas[select + id].SongImage;
        }
    }
}
