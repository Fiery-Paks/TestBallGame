using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChangeYPosition : MonoBehaviour
{
    enum SomeVector
    {
        Up,
        Down
    }
    public GameObject SelectObject;
    public float speed =  0.005f;
    private Vector3 startPosition;
    private SomeVector some = SomeVector.Up;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = SelectObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (startPosition.y + 3 >= SelectObject.transform.position.y && some == SomeVector.Up)
        {
            SelectObject.transform.position = SelectObject.transform.position + new Vector3(0, speed, 0);
        }
        else 
        {
            some = SomeVector.Down;
        }
        if (startPosition.y <= SelectObject.transform.position.y && some == SomeVector.Down)
        {
            SelectObject.transform.position = SelectObject.transform.position + new Vector3(0, -speed, 0);
        }
        else 
        {
            some = SomeVector.Up;
        }
    }
}
