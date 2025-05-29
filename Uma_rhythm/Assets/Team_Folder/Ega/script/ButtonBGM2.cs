using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonBGM2 : MonoBehaviour, IPointerEnterHandler
{
    public AudioClip hoverSound; // 再生する音声
    private AudioSource audioSource;

    void Start()
    {
        // AudioSourceを取得またはアタッチ
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        //audioSource.loop = false; // ループ再生を有効化
        audioSource.clip = hoverSound;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // 音声を再生
        if (hoverSound != null)
        {
            audioSource.Play();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("カーソルがボタンから離れました！");
        audioSource.Stop(); // ボタンからカーソルが離れたら音を停止
    }
}