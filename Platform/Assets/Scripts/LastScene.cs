using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastScene : MonoBehaviour
{
    public int collectedStars=0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "EndScene")
        {
            itemCollector itemcollector = GetComponent<itemCollector>();
            collectedStars = itemcollector.stars;
            lastScene();
        }
        
    }
    private void lastScene()
    {
if ((collectedStars >= 0) && (collectedStars <= 2))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Level Changed...");
        }
else if( (collectedStars >= 3) && (collectedStars <= 5))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
            Debug.Log("Level Changed...");
        }
        else if ( (collectedStars >= 6) && (collectedStars <= 9))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            Debug.Log("Level Changed...");
        }
else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
            Debug.Log("Level Changed...");
        }
    }
}
