using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class NSpeedSet : MonoBehaviour
{
    public InputField NSP_ChangeT;
    double NoteSet = 0.0f;
    bool Num_Check;
    // Start is called before the first frame update
    void Start()
    {
        NSP_ChangeT = GameObject.FindObjectOfType<InputField>();

        NSP_ChangeT.text = GManager.instance.noteSpeed.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Enterキーを押す
        if (Input.GetKeyDown(KeyCode.Return))
        {
            NotesSpeedEnter();
        }
        else if (Input.GetMouseButtonDown(0))
        {
            NotesSpeedEnter();
        }
    }
    
    //入力したノーツを反映する
    void NotesSpeedEnter()
    {

        NSP_ChangeT.text = NSP_ChangeT.text.ToLower();
        //テキストに数字が入っているかチェックtrue/falseを返す
        Num_Check = double.TryParse(NSP_ChangeT.text, out NoteSet);

        NoteSet = Math.Truncate(NoteSet * 100) / 100;

        NSP_ChangeT.text = NoteSet.ToString();

        if (NoteSet < 0.9f)
        {
            NSP_ChangeT.text = "1";
        }
        if (NoteSet >= 20.0f)
        {
            NSP_ChangeT.text = "20";
        }

        //trueなら数字
        if (Num_Check == true)
        {
            //書いた数字がマイナスでなければ
            if (NoteSet > 0.0f && NoteSet <= 20.0f)
            {
                //ノーツの速度変更
                GManager.instance.noteSpeed = (float)NoteSet;
            }
        }
        //falseは数字以外
        else if (Num_Check == false)
        {
            //数字以外の場合は初期値を
            NSP_ChangeT.text = GManager.instance.noteSpeed.ToString();
        }
    }
}
