using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SongSelect : MonoBehaviour
{
    [SerializeField] SongDataBase dataBase;
    [SerializeField] TextMeshProUGUI[] songNameText;
    [SerializeField] Image songImage;
    [SerializeField] GameObject[] notesonj_set;

    NotesManager notesManager = new NotesManager();
    public string songName;
    public int ID;

    AudioSource audioSorce;
    string songname;

    // Start is called before the first frame update
    void Start()
    {
        

        //for (int i = 0; i < 8; i++)
        //{
        //    notesManager.noteObj[i] = notesonj_set[i];
        //}
        songname = songName;
    }

    public void SongStart()
    {
        GManager.instance.songID = ID;
        SceneManager.LoadScene(songname);
    }
   
}
