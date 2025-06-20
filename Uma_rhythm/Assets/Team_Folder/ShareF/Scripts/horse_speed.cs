using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class horse_speed : MonoBehaviour
{
    public InputField NSP_ChangeT;
    float NoteSet = 0.0f;
    bool Num_Check;
    // Start is called before the first frame update
    void Start()
    {
        NSP_ChangeT = GameObject.FindObjectOfType<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        //テキストに数字が入っているかチェックtrue/falseを返す
        Num_Check = float.TryParse(NSP_ChangeT.text, out NoteSet);
        if (NoteSet < 1.0f)
        {
            NSP_ChangeT.text = "5.00";
        }
        if (NoteSet >= 20.0f)
        {
            NSP_ChangeT.text = "20.00";
        }

        //trueなら数字
        if (Num_Check == true)
        {
            //書いた数字がマイナスでなければ
            if (NoteSet > 0.0f && NoteSet <= 20.0f)
            {
                //ノーツの速度変更
                GManager.instance.noteSpeed = NoteSet;
            }
        }
        //falseは数字以外
        else if(Num_Check == false) 
        {
            //数字以外の場合はもとの数値を
            NSP_ChangeT.text = "10.00";
        }
    }
}
