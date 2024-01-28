using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHunting : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;

    public Transform targetTransform;


    // Update is called once per frame
    void Update()
    {
        if (targetTransform != null)
        {
            if (Vector3.Distance(transform.position, targetTransform.position) > 2)
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

            float yPosition = transform.position.y;
            yPosition = 0.42f;
            transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);
        }
    }
}
