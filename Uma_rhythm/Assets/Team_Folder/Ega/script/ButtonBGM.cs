using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBGM : MonoBehaviour
{
    public Button myButton; // UIボタン
    public AudioSource audioSource; // 効果音
    public string nextSceneName; // 遷移先のシーン名

    // Start is called before the first frame update
    void Start()
    {
        myButton.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        StartCoroutine(PlaySoundAndChangeScene());
    }

    IEnumerator PlaySoundAndChangeScene()
    {
        audioSource.Play(); // 効果音を再生
        yield return new WaitForSeconds(audioSource.clip.length); // 効果音が終わるのを待つ
        SceneManager.LoadScene(nextSceneName); // シーンを遷移
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
