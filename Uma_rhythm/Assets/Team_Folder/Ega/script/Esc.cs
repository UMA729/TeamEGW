using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Esc : MonoBehaviour
{
    public GameObject Panel;
    public AudioSource audioSource;  //Ä¶’†AudioSource
    public GameObject textobj;
    public Text Text;
    public static bool pause = false;

    private bool isPaused = false;
    private bool isResuming = false;
    private float time = 0f;
    private float nowtime = 0f;
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
                Debug.Log("Button honkon clicked!");
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
            textobj.SetActive(true);
            time += Time.unscaledDeltaTime;
          
            if (time >= 2f)
            {
                Text.text = ("1");
            }
            else if (time >= 1f)
            {
                Text.text = ("2");
            }
            else if (time >= 0)
            {
                Text.text = ("3");
            }

            if (time >= waittime)
            {
                textobj.SetActive(false);
                isPaused = false;
                isResuming = false;
                time = 0f;
                audioSource.UnPause();

                Debug.Log("Button");
                Text.text = ("3");
                Time.timeScale = 1;

            }
        }



    }
}
