using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class return_button : MonoBehaviour
{
    public GameObject Panel;
    public AudioSource audioSource;
    public UnityEngine.UI.Button button;

    // Start is called before the first frame update
    void Start()
    {
        //bool isActive = false;

        button.onClick.AddListener(() =>
        {
            //isActive = !isActive;
            Panel.SetActive(false);
            audioSource.Play();
        });
    }

    // Update is called once per frame
    void Update()
    {
       //Panel.SetActive(false);
       // audioSource.Play();
    }
}
