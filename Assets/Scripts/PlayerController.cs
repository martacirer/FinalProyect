using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody playerRigidbody;

    float horizontalInput;
    float verticalInput;

    Transform mainCamera;


    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;//Se oculta el raton
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if(Mathf.Abs(horizontalInput)< 0.001f)
        {
            Vector3 vel = playerRigidbody.velocity;

            playerRigidbody.velocity = new Vector3(0, vel.y, vel.z);
            playerRigidbody.angularVelocity = Vector3.zero;
        }

        if(Mathf.Abs(verticalInput)< 0.001f)
        {
            Vector3 vel = playerRigidbody.velocity;

            playerRigidbody.velocity = new Vector3(vel.x, vel.y, 0);
            playerRigidbody.angularVelocity = Vector3.zero;
        }
    }


    void FixedUpdate()
    {      
       //Movimiento horizontal del player
       playerRigidbody.AddForce(transform.right * speed * horizontalInput);
       
        //Movimiento vertical del player
        playerRigidbody.AddForce(playerRigidbody.gameObject.transform.forward * speed * verticalInput);
      
    }
}
