using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //movement of kamado
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
            this.transform.position = this.transform.position + new Vector3(-.05f, 0, 0);
        }
        else if (Input.GetKey("d"))
        {
            //move right
            this.transform.position = this.transform.position + new Vector3(.05f,0,0);
        }
        else if (Input.GetKey("w"))
        {
            //move up
            this.transform.position = this.transform.position + new Vector3(0, 0, .05f);
        }
        else if (Input.GetKey("s"))
        {
            //move down
            this.transform.position = this.transform.position + new Vector3(0, 0, -.05f);
        }
    }
}
