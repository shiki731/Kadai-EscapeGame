using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSystem : MonoBehaviour
{
    public float speed = 3.0f;
    Rigidbody2D rb;
    InputAction moveAction;

    float axisX = 0.0f;
    float axisY = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PlayerInput input = GetComponent<PlayerInput>();
        moveAction = input.currentActionMap.FindAction("Move");
        
    }

    // Update is called once per frame
    void Update()
    {
        axisX = moveAction.ReadValue<Vector2>().x;
        axisY = moveAction.ReadValue<Vector2>().y;
        
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(axisX * speed, axisY * speed);
    }
}
