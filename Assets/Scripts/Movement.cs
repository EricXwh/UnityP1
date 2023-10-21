using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float mainThrust = 1000f;
    [SerializeField] float rotateThrust = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust(){
        if(Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W)){
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }

    void ProcessRotation(){
        if(Input.GetKey(KeyCode.A)){
            ApplyRotation(rotateThrust);
        }
        else if(Input.GetKey(KeyCode.D)){
            ApplyRotation(-rotateThrust);
        }
    }

    void ApplyRotation(float rotationThisFrame){
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
    }
}
