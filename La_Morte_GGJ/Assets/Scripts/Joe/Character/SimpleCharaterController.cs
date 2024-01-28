using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    private float x = 0.0f;
    private float z = 0.0f;
    private Vector3 move;
    public float speed = 0.0f;
    public float jumpHeight = 0.0f;
    public CharacterController controller = null;
    Vector3 velocity;
    public float gravity = -9.81f;
    public Transform groundCheck = null;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    // Update is called once per frame
    void Update()
    {
        // Get keyboard input left, right, forward and backwards
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        // Get player transform
        Transform playerTransform = transform;
        // Set movement direction
        move = playerTransform.right * x + playerTransform.forward * z;

        // Apply movement to character controller component
        controller.Move(move * speed * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);
    }
}
