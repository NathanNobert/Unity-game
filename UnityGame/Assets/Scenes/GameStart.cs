using System.Collections;
using System.Collections.Generic;
using Constants;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // I'm adding the ability to move an object with a mouse click
        if (Input.GetMouseButtonDown(Actions.LeftMouseButton))
        {
            transform.Rotate(0,0,45);
            
        }
        else if (Input.GetMouseButtonDown(Actions.RightMouseButton))
        {
            transform.Rotate(0, 0, -45);

        }
    }
}
