using UnityEngine;
using UnityEngine.InputSystem;
public class BulletMove : MonoBehaviour
{
    public float Speed;

    private Vector2 mousePos;
    private Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        direction = mousePos - (Vector2)transform.position;

        transform.up = direction;
    }

    // Update is called once per frame
    void Update()
    {
     

        transform.position += transform.up * Speed * Time.deltaTime;

    

    }
}
