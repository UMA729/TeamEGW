using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Esc : MonoBehaviour
{
    public GameObject Panel;
    public AudioSource audioSource;  //çƒê∂íÜAudioSource
    public bool time = true;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Panel.SetActive(true);
            Debug.Log("Button clicked!");
            time = false;
            audioSource.Pause();
        }
     
   
    }
}
