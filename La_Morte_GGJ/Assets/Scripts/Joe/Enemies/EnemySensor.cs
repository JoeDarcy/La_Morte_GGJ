using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySensor : MonoBehaviour
{
    private EnemyHunting enemyHunting;


    private void Start()
    {
        enemyHunting = transform.GetComponentInParent<EnemyHunting>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            enemyHunting.targetTransform = other.transform;
    }
}
