using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
            StartCoroutine(num());
        });
  
       
    }

    IEnumerator num()
    {
        while (count >= 0)
        {
            Debug.Log(count);
            yield return new WaitForSeconds(1f);
            count--;
        }
        if (count == 0)
        {
            audioSource.UnPause();
            Esc.time = true;
        }
    }
}
