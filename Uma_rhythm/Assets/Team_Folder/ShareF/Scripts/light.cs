using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    [SerializeField] int Speed = 6;
    [SerializeField] int Num = 0;
    [SerializeField] AudioClip TapSound;
    AudioSource audioSource;
    Renderer rend;
    private float Alfa = 0;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = TapSound;
        audioSource.volume = 0.7f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(rend.material.color.a <= 0))
        {
            rend.material.color = new Color(rend.material.color.r, rend.material.color.r, rend.material.color.r, Alfa);
        }

        if (Input.GetKeyDown("up") ||
            Input.GetKeyDown("down") ||
            Input.GetKeyDown("left") ||
            Input.GetKeyDown("right")||
            Input.GetKeyDown(KeyCode.W)||
            Input.GetKeyDown(KeyCode.A)||
            Input.GetKeyDown(KeyCode.S)||
            Input.GetKeyDown(KeyCode.D)||
            Input.GetKeyDown(KeyCode.Space))
        {
            color_change();
            if (audioSource.clip != null)
            {
                Debug.Log("a");
                audioSource.Play();
            }
        }

        Alfa -= Speed * Time.deltaTime;
    }

    private void color_change()
    {
        Alfa = 1.0f;
        rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, Alfa);
    }
}