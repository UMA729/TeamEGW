using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horse_anime : MonoBehaviour
{
    Animator animator;

    [SerializeField] Esc Esc;
    string normal = "真打ウマバシリ改";
    string jump = "Jump_Animation";
    string now_anime = "";
    string old_anime = "";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        now_anime = normal;
        old_anime = normal;
    }

    private void FixedUpdate()
    {
        if (Esc.time == false)
        {
            return;
        }
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0); //アニメーションの現状を変数
        if (Input.GetKeyDown(KeyCode.Space))
        {
            now_anime = jump;
        }
        // アニメーションが終了しているか確認
        if (stateInfo.IsName("Jump_Animation") && stateInfo.normalizedTime >= 1.0f)
        {
            Debug.Log("アニメーションが終了しました");
            // アニメーション終了後の処理
            now_anime = normal;
        }



        if (old_anime != now_anime)
        {
            old_anime = now_anime;
            animator.Play(now_anime);
        }
    }
}
