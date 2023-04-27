using System.Collections;
using System.Collections.Generic;
using Constants;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(Actions.LeftMouseButton))
        {
            transform.Rotate(0,0,45);
            
        }
    }
}
