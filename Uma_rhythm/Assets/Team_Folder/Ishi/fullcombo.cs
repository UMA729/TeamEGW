using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fullcombo : MonoBehaviour
{
    [SerializeField] Text text;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            text.enabled = false;
        }

        if (Input.GetMouseButtonDown(1))
        {
            text.enabled = true;
        }
    }
}
