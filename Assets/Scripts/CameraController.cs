using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   [SerializeField] private float rotationSpeed = 500;

    private float xRotation;

    private float mouseX;
    private float mouseY;

    public Transform playerBody;

    void Update()
    {
        //camera rotation with mouse
        mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        playerBody.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);


    }
}
