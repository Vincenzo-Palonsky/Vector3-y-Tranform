using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Script : MonoBehaviour
{
    public Vector3 myVector3;
    public GameObject myObject;

    // Start is called before the first frame update
    void Start()
    {
        myObject.transform.position = myVector3;
        //myObject.transform.localScale = myVector3;
        //myObject.transform.eulerAngles = myVector3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
