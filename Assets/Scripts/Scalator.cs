using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scalator : MonoBehaviour
{
    
    float x = 0;
    [SerializeField]
    uint speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<Transform>().localScale = new Vector3(0.5f,0.5f,1);
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = GetComponent<Transform>();
        x = (x % (2*Mathf.PI)) + Time.deltaTime;
       float  scale = (Mathf.Sin(x)/(speed+8))+1;

        t.localScale = new Vector3(scale - 0.5f, scale - 0.5f, 0);



    }
}
