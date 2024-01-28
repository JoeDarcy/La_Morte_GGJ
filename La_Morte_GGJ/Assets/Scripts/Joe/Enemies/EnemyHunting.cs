using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHunting : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;

    private Transform targetTransform;


    // Start is called before the first frame update
    void Start()
    {
        targetTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetTransform.position, movementSpeed * Time.deltaTime);

        // Get the direction from the sprite to the target
        Vector3 direction = targetTransform.position - transform.position;

        // Check if the direction is not zero (avoid division by zero)
        if (direction != Vector3.zero)
        {
            // Calculate the rotation quaternion to face the target
            Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);

            // Smoothly rotate the sprite to face the target
            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * 5f);
        }
    }
}
