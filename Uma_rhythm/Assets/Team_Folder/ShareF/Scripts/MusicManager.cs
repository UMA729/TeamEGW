using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField]SongDataBase dataBase;
    AudioSource audioSorce;
    AudioClip Music;
    string songName;
    bool played;
    void Start()
    {
        GManager.instance.Start = false;
        songName = dataBase.SongDatas[GManager.instance.songID].SongName;
        audioSorce = GetComponent<AudioSource>();
        audioSorce.volume = 0.8f;
        Music = (AudioClip)Resources.Load("Music/" + songName);
        played = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > 4f && !played)
        {
            GManager.instance.Start = true;
            GManager.instance.StartTime = Time.time;
            played = true;
            audioSorce.PlayOneShot(Music);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (audioSorce.isPlaying)
            {
                audioSorce.Stop();
                Debug.Log("âπäyÇí‚é~ÇµÇ‹ÇµÇΩÅB");
            }
        }
    }
}