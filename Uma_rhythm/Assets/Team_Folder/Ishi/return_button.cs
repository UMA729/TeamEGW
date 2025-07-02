using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class return_button : MonoBehaviour
{
    [SerializeField] SongDataBase dataBase;
    public GameObject Panel;
    public AudioSource audioSource;
    public UnityEngine.UI.Button button;
    AudioClip Music;
    string songName;



    // Start is called before the first frame update
    void Start()
    {
        //songName = dataBase.SongDatas[GManager.instance.songID].SongName;
        //audioSource = GetComponent<AudioSource>();
        //Music = (AudioClip)Resources.Load("Music/" + songName);
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        // audioSource.Play();
        button.onClick.AddListener(() =>
        {


            //isActive = !isActive;
            Panel.SetActive(false);
            audioSource.Play();
        });
    }
}
