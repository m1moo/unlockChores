using UnityEngine;
using UnityEngine.SceneManagement;

public class DirtClean : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Brush"))
        {
            Destroy(gameObject);

            // Check if any dirt is left
            if (GameObject.FindGameObjectsWithTag("Dirt").Length == 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
