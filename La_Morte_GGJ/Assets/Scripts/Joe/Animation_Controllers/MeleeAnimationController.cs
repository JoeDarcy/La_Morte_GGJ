using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAnimationController : MonoBehaviour
{
    private Animator meleeAnimator;

    // Start is called before the first frame update
    void Start()
    {
        meleeAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            meleeAnimator.Play("Right_Punch");
        if (Input.GetKeyDown(KeyCode.Q))
            meleeAnimator.Play("Left_Punch");
        if (Input.GetKeyDown(KeyCode.Space))
            meleeAnimator.Play("Block");
    }
}
