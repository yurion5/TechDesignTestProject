using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClicker : MonoBehaviour
{
    public Button ButtObject;

    private void OnMouseDown()
    {
        ButtObject.onClick.Invoke();
    }
}
