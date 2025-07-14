using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class chenge : MonoBehaviour
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
            Time.timeScale = 1;
            Esc.isPaused = false;
            Esc.isResuming = false;
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
        Invoke("SceneChange", 0.01f);
        Debug.Log("Buttonclicked!");

    }

    //ボタンから呼び出す関数
    public void SceneChange()
    {
        GManager.instance.score = 0;

        SceneManager.LoadScene(sceneName);
        Debug.Log("スコア警察");

    }

}

