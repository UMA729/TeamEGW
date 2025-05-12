using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    [SerializeField] private GameObject messe_obj;
    [SerializeField] NotesManager note_mana;

    void Update()
    {
        if (Input.GetKeyDown("up") ||
            Input.GetKeyDown("down") ||
            Input.GetKeyDown("left") ||
            Input.GetKeyDown("right")||
            Input.GetKeyDown(KeyCode.Space))
        {
            if (note_mana.LaneNum[0] == 0)
            {

            }
        }
    }
}
