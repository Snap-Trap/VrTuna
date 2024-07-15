using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputAction zMovement;
    public InputAction xMovement;
    public InputAction yMovement;

    public float speed = 5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 move = new Vector3(xMovement.ReadValue<float>(), yMovement.ReadValue<float>(), zMovement.ReadValue<float>());
        rb.velocity = move * speed;


    }

    private void OnEnable()
    {
        zMovement.Enable();
        xMovement.Enable();
        yMovement.Enable();
    }

    private void OnDisable()
    {
        zMovement.Disable();
        xMovement.Disable();
        yMovement.Disable();
    }
}
