using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class return_button : MonoBehaviour
{
    [SerializeField] Esc Esc;
    public GameObject Panel;
    public AudioSource audioSource;
    public UnityEngine.UI.Button button;

    int count = 3;
    void Start()
    {


        button.onClick.AddListener(() =>
        {
            Panel.SetActive(false);
            Invoke(nameof(ResumeGame), 3f);
        });
  
       
    }

    public void ResumeGame()
    {
        Debug.Log("AAAAAAAAA");
        audioSource.Play();
        Esc.pause = false;
    }
}
