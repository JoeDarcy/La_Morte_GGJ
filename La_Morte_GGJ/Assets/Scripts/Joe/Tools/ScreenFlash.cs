using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFlash : MonoBehaviour
{
    private float timerStart = 2;
    private float timer;

    private void Start()
    {
        timer = timerStart;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = timerStart;
            gameObject.SetActive(false);
        }
    }
}
