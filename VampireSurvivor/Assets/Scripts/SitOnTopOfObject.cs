using UnityEngine;

public class SitOnTopOfObject : MonoBehaviour
{
    public Transform playersPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playersPosition.position;
    }
}
