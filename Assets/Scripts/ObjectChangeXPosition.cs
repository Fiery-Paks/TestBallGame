using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ObjectChangeXPosition : MonoBehaviour
{
    enum SomeVector
    {
        Right,
        Left
    }
    public GameObject SelectObject;
    public float speed =  0.005f;
    private Vector3 startPosition;
    private SomeVector some = SomeVector.Right;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = SelectObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (startPosition.x + 5 >= SelectObject.transform.position.x && some == SomeVector.Right)
        {
            SelectObject.transform.position = SelectObject.transform.position + new Vector3(speed, 0, 0);
        }
        else 
        {
            some = SomeVector.Left;
        }
        if (startPosition.x <= SelectObject.transform.position.x && some == SomeVector.Left)
        {
            SelectObject.transform.position = SelectObject.transform.position + new Vector3(-speed, 0, 0);
        }
        else 
        {
            some = SomeVector.Right;
        }
    }
}
