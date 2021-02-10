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
    PlayerControls inputActions;
    Vector2 movementInput;
    Vector2 cameraInput;
<<<<<<< .merge_file_a13560
    
    CameraHandler cameraHandler;
=======
    public bool b_Input;
    public bool rollFlag;
    public bool isinteract;
>>>>>>> .merge_file_a11644
    public void OnEnable()
    {
        if(inputActions==null)
        {
            inputActions = new PlayerControls();
            inputActions.PlayerMovement.Movement.performed += inputActions => movementInput = inputActions.ReadValue<Vector2>();
            inputActions.PlayerMovement.Camera.performed += i => cameraInput = i.ReadValue<Vector2>();

        }
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }
    private void  Awake()
    {
        cameraHandler=CameraHandler.singleton;
    }

    private  void FixedUpdate()
    {
        float delta=Time.fixedDeltaTime;
        if(cameraHandler!=null)
        {
            cameraHandler.FollowTarget(delta);
            cameraHandler.HandleCameraRotation(delta,mouseX,mouseY);
        }
    }

    public void TickInput(float delta)
    {
        MoveInput(delta);
        HandleRollInput(delta);
    }

    private void MoveInput(float delta)
    {
        horizontal = movementInput.x;
        vertical = movementInput.y;
        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontal) + Mathf.Abs(vertical));
        mouseX = cameraInput.x;
        mouseY = cameraInput.y;

    }

    private void HandleRollInput(float delta)
    {
        b_Input = inputActions.PlayerActions.Roll.phase == UnityEngine.InputSystem.InputActionPhase.Started;
        if(b_Input)
        {
            rollFlag = true;
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
