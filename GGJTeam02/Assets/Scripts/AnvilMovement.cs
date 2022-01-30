using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnvilMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("q"))
        {
            //move left
            this.transform.position = this.transform.position + new Vector3(-.05f, 0, 0);
        }
        else if (Input.GetKey("e"))
        {
            //move right
            this.transform.position = this.transform.position + new Vector3(.05f, 0, 0);
        }
        else if (Input.GetKey("t"))
        {
            //move up
            this.transform.position = this.transform.position + new Vector3(0, 0, .05f);
        }
        else if (Input.GetKey("g"))
        {
            //move down
            this.transform.position = this.transform.position + new Vector3(0, 0, -.05f);
        }
    }
}
