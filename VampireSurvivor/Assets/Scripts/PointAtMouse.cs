using UnityEngine;
using UnityEngine.InputSystem;

public class PointAtMouse : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint (Mouse.current.position.ReadValue());

        direction = mousePos - (Vector2)transform.position;

        transform.up = direction;

    }
}
