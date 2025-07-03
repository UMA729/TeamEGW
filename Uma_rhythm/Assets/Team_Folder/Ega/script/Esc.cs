using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Esc : MonoBehaviour
{
    public GameObject Panel;
    public AudioSource audioSource;  //çƒê∂íÜAudioSource
    public static bool pause = false;
    public float time = 0;
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
            Panel.SetActive(true);
            Debug.Log("Button clicked!");
            audioSource.Pause();
            GameStateManager.pause = true;
            pause = true;
        }
    }
}
