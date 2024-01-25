using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturationDistance : MonoBehaviour
{
    [SerializeField] private Color mainColour;
    [SerializeField] private Texture2D mainTexture;

    private Material desaturationMaterial;
    private Camera mainCamera;
    private float distanceToCamera;
    private float saturationLerp;
    private float pixelationLerp;


    // Start is called before the first frame update
    void Start()
    {
        desaturationMaterial = GetComponent<MeshRenderer>().material;
        desaturationMaterial.SetColor("_MainColour", mainColour);
        desaturationMaterial.SetTexture("_MainTexture", mainTexture);

        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToCamera = Vector3.Distance(transform.position, mainCamera.transform.position);
        saturationLerp = Mathf.InverseLerp(5, 0, distanceToCamera);

        pixelationLerp = Mathf.Lerp(70, 10, distanceToCamera - 2);
        //Debug.Log(pixelationLerp);

        if (distanceToCamera < 5)
        {
            desaturationMaterial.SetFloat("_SaturationAmount", saturationLerp);
        }

        desaturationMaterial.SetFloat("_PixelationAmount", pixelationLerp);

    }
}
