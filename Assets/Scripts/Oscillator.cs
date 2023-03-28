using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Oscillator : MonoBehaviour
{

    float range = 1f;
     uint speed = 1;
    [SerializeField]
    InputAction increaseRange = new InputAction(type: InputActionType.Button);
[SerializeField]
    InputAction decreaseRange = new InputAction(type: InputActionType.Button);
    [SerializeField]
    InputAction increaseSpeed = new InputAction(type: InputActionType.Button);
[SerializeField]
    InputAction decreaseSpeed = new InputAction(type: InputActionType.Button);
    float axis = 0;
    float point;    

void OnEnable() {
        increaseRange.Enable();
        decreaseRange.Enable();
        increaseSpeed.Enable();
        decreaseSpeed.Enable();    
    }

    void OnDisable() {
        increaseRange.Disable();
        decreaseRange.Disable();
        increaseSpeed.Disable();
        decreaseSpeed.Disable();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(increaseRange.WasPressedThisFrame()) {
            this.range++;
        }
        if(decreaseRange.WasPressedThisFrame() && range > 1) {
            this.range--;
        }
        if(increaseSpeed.WasPressedThisFrame()) {
            this.speed++;
        }
        if(decreaseSpeed.WasPressedThisFrame() && speed > 1) {
            this.speed--;
        }
        Debug.Log(transform.position);
        axis = (axis % (2*Mathf.PI)) + Time.deltaTime * speed;
        point = Mathf.Sin(axis) * range;
        GetComponent<Transform>().position = new Vector3(point,transform.position.y,transform.position.z); 
       
    }
}
