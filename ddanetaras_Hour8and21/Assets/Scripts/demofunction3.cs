using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demofunction3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("the A key is being pressed");
        }

        if (Input.GetKey(KeyCode.Z))
        {
            Debug.Log("the Z key was pressed");
        }
    }
}
