using UnityEngine;

public class movement : MonoBehaviour {

    public Rigidbody rb;

    public float force = 0f;

    void FixedUpdate()
    {

        rb.AddForce(force * Time.deltaTime, 0, 0);

    }

}

