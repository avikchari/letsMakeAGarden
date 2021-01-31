using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
    private Vector3 offset; 
    private float ZCoord;
    /*
    void OnMouseDown()
    {
        zCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPos();
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;

        mousePoint.z = ZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() = +offset;
    }*/
}
