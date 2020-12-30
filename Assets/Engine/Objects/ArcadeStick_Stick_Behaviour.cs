using UnityEngine;
using UnityEngine.InputSystem;

public class ArcadeStick_Stick_Behaviour : MonoBehaviour
{
    public PlayerInput playerInput; // represents a player/user

    //private string _arcadeStickActionMap = "ArcadeStick Controls"; // WARNING! This is a hardcoded string and must be updated when the name is changed in-editor!

    private Vector2 _stickPosition;
    private float _newX, _newY, _newZ;

    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnModifyStickDisplay(InputAction.CallbackContext context)
    {
        //Debug.Log("Stick was moved. Value was " + context.ReadValueAsObject().ToString() + ". Value type is " + context.valueType);

        _stickPosition = context.ReadValue<Vector2>();

        _newX = (float)StickPosition.NEUTRAL;
        _newY = _newZ = 0f;

        if (_stickPosition.y > 0f)
            _newX = (float)StickPosition.UP;
        else if (_stickPosition.y < 0f)
            _newX = (float)StickPosition.DOWN;

        if (_stickPosition.x < 0f)
            _newY = (float)StickPosition.LEFT;
        else if (_stickPosition.x > 0f)
            _newY = (float)StickPosition.RIGHT;

        transform.localRotation = Quaternion.Euler(_newX, _newY, _newZ);
    }
}

internal enum StickPosition
{
    NEUTRAL =    -90,
    UP      =    -70,
    DOWN    =   -110,
    LEFT    =     20,
    RIGHT   =    -20
}