using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SongData", menuName = "MakeMusic")]
public class SongData : ScriptableObject
{
    public string SongID;
    public string SongName;
    public Sprite SongImage;
}
