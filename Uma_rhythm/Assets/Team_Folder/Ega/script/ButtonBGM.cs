using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonBGM : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        Debug.Log("ボタンをクリックした");

        audioSource.Play();
    }



}
