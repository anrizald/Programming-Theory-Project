using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButton : MonoBehaviour
{
    public Button jumpButton;

    void Start()
    {
        Button btn = jumpButton.GetComponent<Button>();
        btn.onClick.AddListener(OnJumpButtonClick);
    }

    private void OnJumpButtonClick()
    {
        if (Shape.m_Selected != null)
        {
            Shape shapeScript = Shape.m_Selected.GetComponent<Shape>();

            if (shapeScript != null)
            {
                shapeScript.Jump();
            }
            else
            {
                Debug.LogWarning("Shape script not found");
            }
        }
        else
        {
            Debug.LogWarning("No Shape selected");
        }
    }
}
