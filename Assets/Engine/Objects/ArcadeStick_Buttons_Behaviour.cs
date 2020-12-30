using UnityEngine;
using UnityEngine.InputSystem;

public class ArcadeStick_Buttons_Behaviour : MonoBehaviour
{
    // WARNING! Hardcoded strings: update if event trigger name is changed.
    private const string PRESSED  =  "Pressed";
    private const string RELEASED = "Released";

    public PlayerInput playerInput;

    [Header("Buttons")]
    public GameObject ButtonSquare;
    public GameObject ButtonTriangle;
    public GameObject ButtonCross;
    public GameObject ButtonCircle;
    public GameObject ButtonR1;
    public GameObject ButtonR2;
    public GameObject ButtonL1;
    public GameObject ButtonL2;
    public GameObject ButtonStart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Button Callbacks

    public void OnButtonSquarePressed(InputAction.CallbackContext context)
    {
        var animator = ButtonSquare.GetComponentInChildren<Animator>();
        var mesh = ButtonSquare.GetComponentInChildren<MeshRenderer>();

        if (context.action.phase == InputActionPhase.Performed)
        {
            //Debug.Log("Square was pressed!");
            animator.SetTrigger(PRESSED);
            mesh.material.color = new Color(mesh.material.color.r - .2f, mesh.material.color.g - .2f, mesh.material.color.b - .2f);
        }
        else if (context.action.phase == InputActionPhase.Canceled)
        {
            //Debug.Log("Square was released!");
            animator.SetTrigger(RELEASED);
            mesh.material.color = new Color(mesh.material.color.r + .2f, mesh.material.color.g + .2f, mesh.material.color.b + .2f);
        }
    }

    public void OnButtonTrianglePressed(InputAction.CallbackContext context)
    {
        var animator = ButtonTriangle.GetComponentInChildren<Animator>();
        var mesh = ButtonTriangle.GetComponentInChildren<MeshRenderer>();

        if (context.action.phase == InputActionPhase.Performed)
        {
            //Debug.Log("Triangle was pressed!");
            animator.SetTrigger(PRESSED);
            mesh.material.color = new Color(mesh.material.color.r - .2f, mesh.material.color.g - .2f, mesh.material.color.b - .2f);
        }
        else if (context.action.phase == InputActionPhase.Canceled)
        {
            //Debug.Log("Triangle was released!");
            animator.SetTrigger(RELEASED);
            mesh.material.color = new Color(mesh.material.color.r + .2f, mesh.material.color.g + .2f, mesh.material.color.b + .2f);
        }
    }

    public void OnButtonCrossPressed(InputAction.CallbackContext context)
    {
        var animator = ButtonCross.GetComponentInChildren<Animator>();
        var mesh = ButtonCross.GetComponentInChildren<MeshRenderer>();

        if (context.action.phase == InputActionPhase.Performed)
        {
            //Debug.Log("Cross was pressed!");
            animator.SetTrigger(PRESSED);
            mesh.material.color = new Color(mesh.material.color.r - .2f, mesh.material.color.g - .2f, mesh.material.color.b - .2f);
        }
        else if (context.action.phase == InputActionPhase.Canceled)
        {
            //Debug.Log("Cross was released!");
            animator.SetTrigger(RELEASED);
            mesh.material.color = new Color(mesh.material.color.r + .2f, mesh.material.color.g + .2f, mesh.material.color.b + .2f);
        }
    }

    public void OnButtonCirclePressed(InputAction.CallbackContext context)
    {
        var animator = ButtonCircle.GetComponentInChildren<Animator>();
        var mesh = ButtonCircle.GetComponentInChildren<MeshRenderer>();

        if (context.action.phase == InputActionPhase.Performed)
        {
            //Debug.Log("Circle was pressed!");
            animator.SetTrigger(PRESSED);
            mesh.material.color = new Color(mesh.material.color.r - .2f, mesh.material.color.g - .2f, mesh.material.color.b - .2f);
        }
        else if (context.action.phase == InputActionPhase.Canceled)
        {
            //Debug.Log("Circle was released!");
            animator.SetTrigger(RELEASED);
            mesh.material.color = new Color(mesh.material.color.r + .2f, mesh.material.color.g + .2f, mesh.material.color.b + .2f);
        }
    }

    public void OnButtonR1Pressed(InputAction.CallbackContext context)
    {
        var animator = ButtonR1.GetComponentInChildren<Animator>();
        var mesh = ButtonR1.GetComponentInChildren<MeshRenderer>();

        if (context.action.phase == InputActionPhase.Performed)
        {
            //Debug.Log("R1 was pressed!");
            animator.SetTrigger(PRESSED);
            mesh.material.color = new Color(mesh.material.color.r - .2f, mesh.material.color.g - .2f, mesh.material.color.b - .2f);
        }
        else if (context.action.phase == InputActionPhase.Canceled)
        {
            //Debug.Log("R1 was released!");
            animator.SetTrigger(RELEASED);
            mesh.material.color = new Color(mesh.material.color.r + .2f, mesh.material.color.g + .2f, mesh.material.color.b + .2f);
        }
    }

    public void OnButtonL1Pressed(InputAction.CallbackContext context)
    {
        var animator = ButtonL1.GetComponentInChildren<Animator>();
        var mesh = ButtonL1.GetComponentInChildren<MeshRenderer>();

        if (context.action.phase == InputActionPhase.Performed)
        {
            //Debug.Log("L1 was pressed!");
            animator.SetTrigger(PRESSED);
            mesh.material.color = new Color(mesh.material.color.r - .2f, mesh.material.color.g - .2f, mesh.material.color.b - .2f);
        }
        else if (context.action.phase == InputActionPhase.Canceled)
        {
            //Debug.Log("L1 was released!");
            animator.SetTrigger(RELEASED);
            mesh.material.color = new Color(mesh.material.color.r + .2f, mesh.material.color.g + .2f, mesh.material.color.b + .2f);
        }
    }

    public void OnButtonR2Pressed(InputAction.CallbackContext context)
    {
        var animator = ButtonR2.GetComponentInChildren<Animator>();
        var mesh = ButtonR2.GetComponentInChildren<MeshRenderer>();

        if (context.action.phase == InputActionPhase.Performed)
        {
            //Debug.Log("R2 was pressed!");
            animator.SetTrigger(PRESSED);
            mesh.material.color = new Color(mesh.material.color.r - .2f, mesh.material.color.g - .2f, mesh.material.color.b - .2f);
        }
        else if (context.action.phase == InputActionPhase.Canceled)
        {
            //Debug.Log("R2 was released!");
            animator.SetTrigger(RELEASED);
            mesh.material.color = new Color(mesh.material.color.r + .2f, mesh.material.color.g + .2f, mesh.material.color.b + .2f);
        }
    }

    public void OnButtonL2Pressed(InputAction.CallbackContext context)
    {
        var animator = ButtonL2.GetComponentInChildren<Animator>();
        var mesh = ButtonL2.GetComponentInChildren<MeshRenderer>();

        if (context.action.phase == InputActionPhase.Performed)
        {
            //Debug.Log("L2 was pressed!");
            animator.SetTrigger(PRESSED);
            mesh.material.color = new Color(mesh.material.color.r - .2f, mesh.material.color.g - .2f, mesh.material.color.b - .2f);
        }
        else if (context.action.phase == InputActionPhase.Canceled)
        {
            //Debug.Log("L2 was released!");
            animator.SetTrigger(RELEASED);
            mesh.material.color = new Color(mesh.material.color.r + .2f, mesh.material.color.g + .2f, mesh.material.color.b + .2f);
        }
    }

    public void OnButtonStartPressed(InputAction.CallbackContext context)
    {
        var animator = ButtonStart.GetComponentInChildren<Animator>();
        var mesh = ButtonStart.GetComponentInChildren<MeshRenderer>();

        if (context.action.phase == InputActionPhase.Performed)
        {
            //Debug.Log("Start was pressed!");
            animator.SetTrigger(PRESSED);
            mesh.material.color = new Color(mesh.material.color.r - .2f, mesh.material.color.g - .2f, mesh.material.color.b - .2f);
        }
        else if (context.action.phase == InputActionPhase.Canceled)
        {
            //Debug.Log("Start was released!");
            animator.SetTrigger(RELEASED);
            mesh.material.color = new Color(mesh.material.color.r + .2f, mesh.material.color.g + .2f, mesh.material.color.b + .2f);
        }
    }
    
    #endregion Button Callbacks
}
