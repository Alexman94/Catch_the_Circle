using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour
{
    Vector3 offsetDistance;
    private void OnMouseDown()
    {
        offsetDistance = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        offsetDistance.z = 0;
    }
    private void OnMouseDrag()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        transform.position = mousePosition - offsetDistance;
    }
}
