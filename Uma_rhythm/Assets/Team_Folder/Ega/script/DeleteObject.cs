using UnityEngine;
using UnityEngine.UI;

public class DeleteObject : MonoBehaviour
{
    public GameObject objectToDelete; // �폜����I�u�W�F�N�g���w��

    void Start()
    {
        // �{�^���̃N���b�N�C�x���g�Ƀ��\�b�h��o�^
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
