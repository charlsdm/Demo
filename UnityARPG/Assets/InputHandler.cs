using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float moveAmount;
    public float mouseX;
    public float mouseY;
    //PlayerControls inputActions;
    Vector2 movementInput;
    Vector2 cameraInput;
    public void OnEnable()
    {
       // if(inputActions==null)
        {
           // inputActions = new PlayerControls();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
