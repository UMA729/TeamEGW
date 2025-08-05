using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NSpeedSet_B : MonoBehaviour
{
    [SerializeField]private Button PlusOneB;
    [SerializeField]private Button PlusTenB;
    [SerializeField]private Button MinusOneB;
    [SerializeField]private Button MinusTenB;
    [SerializeField]private Text NotesText;
    string NotesTitle;
    // Start is called before the first frame update
    void Start()
    {
        PlusOneB = GetComponent<Button>();
        PlusTenB = GetComponent<Button>();
        MinusOneB = GetComponent<Button>();
        MinusTenB = GetComponent<Button>();
        NotesTitle = NotesText.name;

        NotesText = GameObject.Find(NotesTitle).GetComponent<Text>();

        NotesText.text = GManager.instance.noteSpeed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpeedPlusOne()
    {
        GManager.instance.noteSpeed++;
        SetNotesSpeed();
    }
    public void SpeedPlusTen()
    {
        GManager.instance.noteSpeed += 10.0f;
        SetNotesSpeed();
    }
    public void SpeedMinusOne()
    {
        GManager.instance.noteSpeed--;
        SetNotesSpeed();
    }
    public void SpeedMinusTen()
    {
        GManager.instance.noteSpeed -= 10.0f;
        SetNotesSpeed();
    }

    void SetNotesSpeed()
    {
        EventSystem.current.SetSelectedGameObject(null);

        NotesText.text = GManager.instance.noteSpeed.ToString();

        if (GManager.instance.noteSpeed < 0.9f)
        {
            NotesText.text = "1";
        }
        if (GManager.instance.noteSpeed >= 20.0f)
        {
            NotesText.text = "20";
        }

        
        GManager.instance.noteSpeed = float.Parse(NotesText.text);       

    }
}
