using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{
    //private float temperature; //celsius
    bool extended;
    // Start is called before the first frame update
    void Start()
    {
        extended = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (temperature >= 400){
            //change color to red
        }*/
        if (this.transform.position.x >= 4 && this.transform.position.x <= 7)
        {
            if (this.transform.position.z >= 5 && this.transform.position.z <= 7)
            {
                extend();
            }
        }
    }
    void extend()
    {
        //increase length
        if (!extended)
        {
            this.transform.localScale=this.transform.localScale+new Vector3(.2f,0,0);
            extended = true;
        }    
    }
}
