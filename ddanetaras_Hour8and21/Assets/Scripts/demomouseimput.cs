using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demomouseimput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXvalue = Input.GetAxis("Mouse X");
        float mouseYvalue = Input.GetAxis("Mouse Y");
        if (mouseXvalue != 0)
        {
            Debug.Log("mouse x movement: " + mouseXvalue);
        }
        if (mouseYvalue != 0)
        {
            Debug.Log("mouse y movement: " + mouseYvalue);
        }

        if (Input.GetMouseButton(0))
        {
            Debug.Log("pew pew!");
        }
    }
}
