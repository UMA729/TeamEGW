using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.Member;

public class Esc2 : MonoBehaviour
{
    public GameObject Panel; // ï\é¶ÇµÇΩÇ¢UIÉpÉlÉã
    public AudioSource audioSource;  //çƒê∂íÜAudioSource
    public Button myButton;

    private bool isPaused = false;
    private bool isResuming = false;
    private int s = 0;
    private float time = 0f;
    private float waittime = 3f;



    private void Start()
    {
        //audioSource = GetComponent<AudioSource>();

    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(!isPaused)
            {
                isPaused = true;
                s = 1;

                Panel.SetActive(!Panel.activeSelf);
                Debug.Log("Button clicked!");
                audioSource.Pause();

                Time.timeScale = 0;

            }
            else if(!isResuming)
            {
                Panel.SetActive(!Panel.activeSelf);

                isResuming = true;
                time = 0f;
            }

        }

        if(isResuming)
        {
            time += Time.unscaledDeltaTime;

            if (time >= waittime)
            {
                isPaused = false;
                isResuming = false;
                s = 0;
                time = 0f;
                audioSource.UnPause();

                Debug.Log("Button");

                Time.timeScale = 1;

            }
        }
    }
}
