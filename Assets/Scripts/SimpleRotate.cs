using UnityEngine;
using System.Collections;

public class SimpleRotate : MonoBehaviour
{
    private float sensitivity = 0.8f;
    private Vector3 mouseReference;
    private Vector3 mouseOffset;
    private Vector3 rotation = Vector3.zero;
    private bool isRotating;

    void Update()
    {
        if (isRotating)
        {
            Rotate();
        }
    }

    void OnMouseDown()
    {
        isRotating = true;
        mouseReference = Input.mousePosition;
    }

    void OnMouseUp()
    {
        isRotating = false;
    }

    void Rotate()
    {
        mouseOffset = (Input.mousePosition - mouseReference);
        rotation.y = -(mouseOffset.x + mouseOffset.y) * sensitivity;
        gameObject.transform.Rotate(rotation);
        mouseReference = Input.mousePosition;
    }

}