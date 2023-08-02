using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragAndDrop : MonoBehaviour
{
    Vector3 mousePositionOffset;


    private Vector3 GetMouseWorldPosition()
    {

        return Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    private void OnMouseDown()
    {

        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();

    }
    private void OnMouseDrag()
    {

        transform.position = GetMouseWorldPosition() + mousePositionOffset;

    }

}
