using UnityEngine;

public class applyForce : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Rigidbody ourRigidbody;
    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ourRigidbody.AddForce(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ourRigidbody.AddExplosionForce(1000, transform.position - new Vector3(0, 0, 0), 6);
        }
        if (Input.GetKey(KeyCode.W))
        {
            ourRigidbody.AddForce(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        { 
            ourRigidbody.AddForce(Vector3.back);
        }
        if (Input.GetKey(KeyCode.D))
        {
            ourRigidbody.AddForce(Vector3.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            ourRigidbody.AddForce(Vector3.left);
        }
    }
}
