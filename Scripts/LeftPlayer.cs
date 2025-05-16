using UnityEngine;

public class LeftPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))//forward
        {
            transform.Translate(0, 0, 0.6f);
        }
        if (Input.GetKey(KeyCode.S))//backward
        {
            transform.Translate(0, 0, -0.4f);
        }
        if (Input.GetKey(KeyCode.A))//left
        {
            transform.Rotate(0, -0.5f, 0);

        }
        if (Input.GetKey(KeyCode.right))//right
        {
            transform.Rotate(0, 0.5f, 0);
        }
    }
}
