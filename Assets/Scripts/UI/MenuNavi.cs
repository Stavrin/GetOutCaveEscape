using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuNavi : MonoBehaviour
{
    public Selectable DefaultSelection;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        EventSystem.current.SetSelectedGameObject(null);
    }

    void LateUpdate()
    {
        if (EventSystem.current.currentSelectedGameObject == null)
        {
            if (Input.GetButtonDown("Submit")
                || Input.GetAxisRaw("Horizontal") != 0
                || Input.GetAxisRaw("Vertical") != 0)
            {
                EventSystem.current.SetSelectedGameObject(DefaultSelection.gameObject);
            }
        }
    }
}
