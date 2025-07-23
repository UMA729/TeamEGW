using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.Member;

public class Esc2 : MonoBehaviour
{
    public GameObject Panel; // •\Ž¦‚µ‚½‚¢UIƒpƒlƒ‹

    private bool isPaused = false;
    private bool isResuming = false;



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

                Panel.SetActive(!Panel.activeSelf);
                Debug.Log("Button clicked!");


            }
            else if(!isResuming)
            {
                Panel.SetActive(!Panel.activeSelf);

                isResuming = true;
            }

        }

        if(isResuming)
        {
            isPaused = false;
            isResuming = false;

            Debug.Log("Button");



        }
    
    }
}
