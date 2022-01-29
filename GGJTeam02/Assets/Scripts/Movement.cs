using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            //move left
            this.transform.position = this.transform.position + new Vector3(-10, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            //move right
            this.transform.position = this.transform.position + new Vector3(10,0,0);
        }
    }
}
