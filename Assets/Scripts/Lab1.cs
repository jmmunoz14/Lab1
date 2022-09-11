using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(1.5f, 2.5f, 3.5f);
        Vector3 v2 = new Vector3(1.0f, -3.5f, 1.5f);

        float k = 0.75f;

        Debug.Log("v1 + v2 = " + (v1 + v2));

        Debug.Log("v1 - v2 = " + (v1 - v2));

        Debug.Log("K * v1 = " + (k * v1));

        Debug.Log("K * v2 = " + (k * v2));

        Debug.Log("v1 . v2 = " + (Vector3.Dot(v1, v2)));

        Debug.Log("v1 x v2 = " + (Vector3.Cross(v1, v2)));

        Debug.Log("|v1| = " + (Vector3.Magnitude(v1)));

        Debug.Log("|v2| = " + (Vector3.Magnitude(v2)));

        Debug.Log(Vector3.Angle(v1, v2));

        

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
