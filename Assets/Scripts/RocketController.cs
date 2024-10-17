using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
public float thrust;
public float fuel;
public Rigidbody2D rocket;
    // Start is called before the first frame update
    void Start()
    {

    }

public void FixedUpdate()
{
    if (fuel > 0)
    {
        float h = Input.GetAxis("Horizontal");

        rocket.AddForce(transform.up * thrust);
        fuel -= thrust*.01f;
        Debug.Log(fuel);
    }
}
}