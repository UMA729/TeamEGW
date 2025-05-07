using UnityEngine;
using UnityEngine.UI;

public class DeleteObject : MonoBehaviour
{
    public GameObject objectToDelete; // 削除するオブジェクトを指定

    void Start()
    {
        // ボタンのクリックイベントにメソッドを登録
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(DeleteTargetObject);
        }
    }

    void DeleteTargetObject()
    {
        if (objectToDelete != null)
        {
            Destroy(objectToDelete);
        }
    }
}
