using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rotator : MonoBehaviour
{

    float speed = 10f;

    [SerializeReference]
    bool yAxis, xAxis, zAxis = false;

    [SerializeField]
    InputAction changeDireaction = new InputAction(type: InputActionType.Button);
        [SerializeField]
    InputAction stopRotate = new InputAction(type: InputActionType.Button);
    
        void OnEnable() {
        changeDireaction.Enable(); 
                stopRotate.Enable();    
   
    }

    void OnDisable() {
        changeDireaction.Disable(); 
        stopRotate.Disable();   
    }




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(changeDireaction.WasPressedThisFrame()) {
            speed *= -1;
        }
        if(stopRotate.WasPressedThisFrame()) {
            zAxis = !zAxis;
        }

        Transform t = GetComponent<Transform>();

        if (t != null)
        {

            if (yAxis)
            {
                //change the y-axis 
                t.Rotate(0, speed * Time.deltaTime, 0);
            }
            if (xAxis)
            {
                //change the x-axis 
                t.Rotate(speed * Time.deltaTime, 0, 0);
            }
            //change the z-axis 
            if (zAxis)
            {
                t.Rotate(0, 0, speed * Time.deltaTime);
            }
            

        }
    }
}
