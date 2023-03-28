using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class VisibilityToggle : MonoBehaviour
{
    [SerializeField]
    InputAction show = new InputAction(type: InputActionType.Button);
    
        void OnEnable() {
        show.Enable();    
    }

    void OnDisable() {
        show.Disable();    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(show.WasPressedThisFrame()) {
            // gameObject.SetActive(!gameObject.activeSelf);
            GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;            // appear = !appear;
            Debug.Log(gameObject.activeSelf);
        }
    }
}
