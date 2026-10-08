using UnityEngine;
using UnityEngine.InputSystem;

public class StageMove : MonoBehaviour
{

    private InputAction _playerInput;

    [SerializeField] 
    private GameObject _stage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //InputSystem.actions.FindAction("Move")
        //¨InputSystem‚Ìactions‚©‚ç"Move"‚ğ’T‚µ‚Äæ“¾‚·‚é
        _playerInput = InputSystem.actions.FindAction("Move");

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(_playerInput.ReadValue<Vector2>());
        //stage‚ğ‰ñ“]‚³‚¹‚éˆ—(horizontal:…•½,vertical:‚’¼)
        float horizontalInput = _playerInput.ReadValue<Vector2>().x;
        float verticalInput = _playerInput.ReadValue<Vector2>().y;

        _stage.transform.Rotate(horizontalInput*0.05f,0f,verticalInput*0.05f);

    }
}
