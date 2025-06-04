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
 

    public string songName;
    public int ID;

    AudioSource audio;
    string songname;

    // Start is called before the first frame update
    void Start()
    {
        songname = songName;
    }

    public void SongStart()
    {
        GManager.instance.songID = ID;
        SceneManager.LoadScene(songname);
    }
   
}
