using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    private Vector3 m_oldMousePosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        m_oldMousePosition = Input.mousePosition;
        m_oldMousePosition.z = 1.0f;
    }

    private void OnMouseDrag()
    {
        var screenPoint = Input.mousePosition;
        screenPoint.z = 1.0f; //distance of the plane from the camera
        transform.position += Camera.main.ScreenToWorldPoint(screenPoint) - Camera.main.ScreenToWorldPoint(m_oldMousePosition);

        m_oldMousePosition = screenPoint;
    }
}
