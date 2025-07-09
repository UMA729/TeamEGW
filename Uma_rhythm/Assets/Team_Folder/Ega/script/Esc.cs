using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Esc : MonoBehaviour
{
    public GameObject Panel;
    public AudioSource audioSource;  //Ä¶’†AudioSource
    public static bool pause = false;

    private bool isPaused = false;
    private bool isResuming = false;
    private float time = 0f;
    private float waittime = 3f;

    // Start is called before the first frame update

    public static class GameStateManager
    {
        public static bool pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                isPaused = true;

                Panel.SetActive(!Panel.activeSelf);
                Debug.Log("Button clicked!");
                audioSource.Pause();

                Time.timeScale = 0;

            }
            else if (!isResuming)
            {
                Panel.SetActive(!Panel.activeSelf);

                isResuming = true;
                time = 0f;
            }

        }

        if (isResuming)
        {
            time += Time.unscaledDeltaTime;

            if (time >= waittime)
            {
                isPaused = false;
                isResuming = false;
                time = 0f;
                audioSource.UnPause();

                Debug.Log("Button");

                Time.timeScale = 1;

            }
        }



    }
}
