using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    if(Keyboard.current.wKey.isPressed)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }

    if (Keyboard.current.sKey.isPressed)
        {
            transform.position -= transform.up * speed * Time.deltaTime;
        }

    if (Keyboard.current.dKey.isPressed)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

    if (Keyboard.current.aKey.isPressed)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }


    }
}
