using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Esc : MonoBehaviour
{
    public GameObject Panel;
    public AudioClip audioClip;

    public AudioSource audioSource;  //çƒê∂íÜAudioSource
    int num = 0;
    //public KeyCode stopKey = KeyCode.Escape;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(!Panel.activeSelf);
            Debug.Log("Button clicked!");

        }
     
   
    }
}
