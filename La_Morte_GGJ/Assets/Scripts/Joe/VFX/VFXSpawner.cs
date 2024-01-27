using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXSpawner : MonoBehaviour
{
    [SerializeField] private GameObject VFXPrefab;

    private GameObject VFXInstance;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
            VFXInstance = Instantiate(VFXPrefab, transform.position, transform.rotation, transform);
    }
}
