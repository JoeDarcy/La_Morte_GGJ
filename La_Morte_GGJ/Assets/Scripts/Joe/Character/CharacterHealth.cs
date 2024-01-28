using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterHealth : MonoBehaviour
{
    [SerializeField] private int characterHealth;
    [SerializeField] GameObject screenFlash;


    private void Start()
    {
        screenFlash.SetActive(false);
    }

    private void Update()
    {
        if (characterHealth <= 0)
            SceneManager.LoadScene(0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            characterHealth -= 5;
            screenFlash.SetActive(true);
        }
    }
}
