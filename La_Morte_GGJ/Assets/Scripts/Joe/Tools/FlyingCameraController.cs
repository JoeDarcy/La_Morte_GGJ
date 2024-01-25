using UnityEngine;

public class FlyingCameraController : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 2.0f;
    public float elevationSpeed = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    private void Start()
    {
        // Lock and hide the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Handle camera movement
        float horizontalInput = 0.0f;
        float verticalInput = 0.0f;
        float elevationInput = 0.0f;

        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            verticalInput = -1.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1.0f;
        }

        if (Input.GetKey(KeyCode.E))
        {
            elevationInput = 1.0f;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            elevationInput = -1.0f;
        }

        Vector3 moveDirection = new Vector3(horizontalInput, elevationInput, verticalInput);
        transform.Translate(moveDirection * movementSpeed * Time.deltaTime);

        // Handle camera rotation with mouse
        yaw += rotationSpeed * Input.GetAxis("Mouse X");
        pitch -= rotationSpeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
