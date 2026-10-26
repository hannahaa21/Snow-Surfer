using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    InputAction moveAction;
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        print(moveAction);
        if(moveAction != null)
            moveAction.Enable();
    }

    void Update()
    {
        // Vector 2 -> (x, y) up down y, left right x
        Vector2 moveVector = moveAction.ReadValue<Vector2>();
        print(moveVector);
    }
}
