using UnityEngine;
using UnityEngine.SceneManagement;

public class DirtParentManager : MonoBehaviour
{
    void Update()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("Dirt cleaned!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
