using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PPBlendingGizmo : MonoBehaviour
{
    private Volume sphereVolume;

    // Update gizmo sphere to represent blend distance start
    private void OnDrawGizmos()
    {
        sphereVolume = GetComponent<Volume>();
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, sphereVolume.blendDistance);
    }
}
