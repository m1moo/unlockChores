using UnityEngine;
using UnityEngine.SceneManagement;

public class VegetableSliceManager : MonoBehaviour
{
    [Header("How many breads / vegetables must be sliced")]
    public int totalVegetables = 2;

    private int slicedCount = 0;

    [Header("Next Scene")]
    public string nextSceneName = "DishWashing";

    public void OnVegetableSliced()
    {
        slicedCount++;

        if (slicedCount >= totalVegetables)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}

