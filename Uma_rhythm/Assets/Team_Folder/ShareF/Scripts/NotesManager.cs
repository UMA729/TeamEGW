using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[Serializable]
public class Data
{
    public string name;
    public int maxBlock;
    public int BPM;
    public int offset;
    public Note[] notes;

}
[Serializable]
public class Note
{
    public int type;
    public int num;
    public int block;
    public int LPB;
}

public class NotesManager : MonoBehaviour
{
    [SerializeField]SongDataBase dataBase;
    SongSelect songSelect;

    public int noteNum;
    private string songName;

    public string testS;

    public List<int> LaneNum = new List<int>();
    public List<int> NoteType = new List<int>();
    public List<float> NotesTime = new List<float>();
    public List<GameObject> NotesObj = new List<GameObject>();

    [SerializeField] private float NotesSpeed;
    public GameObject[] noteObj;

    void OnEnable()
    {
        NotesSpeed = GManager.instance.noteSpeed;
        noteNum = 0;
        songName = dataBase.SongDatas[GManager.instance.songID].SongName;
        Load(songName);
    }

    private void Load(string SongName)
    {
        string inputString = Resources.Load<TextAsset>(SongName).ToString();
        Data inputJson = JsonUtility.FromJson<Data>(inputString);

        noteNum = inputJson.notes.Length;

        for (int i = 0; i < inputJson.notes.Length; i++)
        {
            float Note_interval = 60 / (inputJson.BPM * (float)inputJson.notes[i].LPB);
            float beatSec = Note_interval * (float)inputJson.notes[i].LPB;
            float ntoffset = inputJson.offset * 0.1f;
            float time = (beatSec * inputJson.notes[i].num / (float)inputJson.notes[i].LPB) + ntoffset;

            NotesTime.Add(time);
            LaneNum.Add(inputJson.notes[i].block);
            NoteType.Add(inputJson.notes[i].type);

            float x = NotesTime[i] * NotesSpeed;

            for (int j = 0; j < noteObj.Length; j++)
            {
                if (NoteType[i] == j + 1)
                    NotesObj.Add(Instantiate(noteObj[j], new Vector3(x, 0.55f, 1.5f), Quaternion.identity));
            }
        }
    }
}