using UnityEngine;
using UnityEngine.SceneManagement;

public class lEVELlOADER : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            SceneManager.LoadSceneAsync(i, LoadSceneMode.Additive);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
