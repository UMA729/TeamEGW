using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SongDataBase",menuName ="楽曲データベースを作成")]
public class SongDataBase : MonoBehaviour
{
    [SerializeField] private SongData[] SongDatas;
}
