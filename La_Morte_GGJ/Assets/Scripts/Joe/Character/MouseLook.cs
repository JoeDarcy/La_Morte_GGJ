using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	public float mouseSensitivity = 100.0f;
	private float mouseX = 0.0f;
	private float mouseY = 0.0f;
    public Transform playerBody = null;

    // Start is called before the first frame update
    void Start()
    {
	    Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse input X and Y
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotate the camera based on mouse input
        transform.Rotate(Vector3.up * mouseX);

        // Limit the camera's vertical rotation
        //float currentRotationX = transform.rotation.eulerAngles.x;
        //float newRotationX = Mathf.Clamp(currentRotationX - mouseY, -90.0f, 90.0f);

        // Apply the new rotation to the camera
        //transform.rotation = Quaternion.Euler(newRotationX, transform.rotation.eulerAngles.y, 0.0f);

    }
}
