using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    public int stars = 0;
    [SerializeField] private Text StarCounter;
 private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Star"))
        {
            Destroy(collision.gameObject);
            stars = stars + 1;
            StarCounter.text = "Toplanan Yýldýzlar = " + stars;
        }
    }
}
