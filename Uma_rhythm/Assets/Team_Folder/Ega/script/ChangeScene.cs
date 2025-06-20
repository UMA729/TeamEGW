using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    //シーンの行き先
    public Button myButton;
    public string sceneName;
    public AudioClip AudioClip;
    private AudioSource AudioSource;
    int s = 0;


    void Start()
    {
        // AudioSourceを取得またはアタッチ
        AudioSource = gameObject.AddComponent<AudioSource>();
        AudioSource.playOnAwake = false;
        //audioSource.loop = false; // ループ再生を有効化
        AudioSource.clip = AudioClip;


        if (myButton != null)
        {

            myButton.onClick.AddListener(OnButtonClick);
        }
        else
        {

            Debug.LogError("Button is not assigned!");
        }
    }

    public void OnButtonClick()
    {
        AudioSource.Play();
        Invoke("SceneChange", 0.3f);
        Debug.Log("Button clicked!");
    }

    //ボタンから呼び出す関数
    public void SceneChange()
    {
        SceneManager.LoadScene(sceneName);
    }

}

