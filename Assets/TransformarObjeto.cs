using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformarObjeto : MonoBehaviour
{
    public GameObject myCube;
    public GameObject rotado;
    public GameObject escalado;
    public GameObject rotadoYEscalado;

    Vector3 originalRotation;
    Vector3 originalScale;
    bool isRotated;
    bool isScaled;

    // Start is called before the first frame update
    void Start()
    {
        isRotated = false;
        isScaled = false;
        originalRotation = myCube.transform.eulerAngles;
        originalScale = myCube.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (isRotated)
            {
                myCube.transform.eulerAngles = originalRotation;
                isRotated = false;
            }

            else
            {
                myCube.transform.eulerAngles = rotado.transform.eulerAngles;
                isRotated = true;
            }            
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (isScaled)
            {
                myCube.transform.localScale = originalScale;
                isScaled = false;
            }

            else
            {
                myCube.transform.localScale = escalado.transform.localScale;
                isScaled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isRotated || isScaled)
            {
                myCube.transform.eulerAngles = originalRotation;
                myCube.transform.localScale = originalScale;
                isRotated = false;
                isScaled = false;
            }

            else
            {
                myCube.transform.eulerAngles = rotadoYEscalado.transform.eulerAngles;
                myCube.transform.localScale = rotadoYEscalado.transform.localScale;
                isRotated = true;
                isScaled = true;
            }            
        }
    }
}
