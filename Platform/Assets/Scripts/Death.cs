using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
    public int Health = 1;
    private int currentHealth;

    public Text TekrarDeneyin;

    private bool isDead = false;

    private void Start()
    {
        currentHealth = Health;
        TekrarDeneyin.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (isDead)
        {
           
            GetComponent<PlayerController>().enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Die();
        }
        
    }

    private void Die()
    {
        currentHealth--;
        if (currentHealth <= 0 && !isDead)
        {
            isDead = true;
           
            GetComponent<PlayerController>().enabled = false;
            // Instantiate(TekrarDeneyin, new Vector3(0f, 0f, 0f), Quaternion.identity);
            TekrarDeneyin.gameObject.SetActive(true);
            Debug.Log("Player has died.");
        }
    }
}
