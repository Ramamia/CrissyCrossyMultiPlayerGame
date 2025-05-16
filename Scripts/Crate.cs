using UnityEngine;

public class Crate : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("bam");
    }

    private void OnCollisionStay(Collision collision)
    {
        rb.AddForce(0, 1, 0);
    }

}
