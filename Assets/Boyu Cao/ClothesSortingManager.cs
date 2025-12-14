using UnityEngine;
using UnityEngine.SceneManagement;

public class ClothesSortingManager : MonoBehaviour
{
    public static ClothesSortingManager Instance;

    [Header("Sorting Settings")]
    public int totalItems = 12;
    private int correctlySorted = 0;

    [Header("Scene Settings")]
    public string nextSceneName = "BoyuCao(VegetablesCutting)";

    private void Awake()
    {
        Instance = this;
    }

    public void OnCorrectItemSorted()
    {
        correctlySorted++;

        if (correctlySorted >= totalItems)
        {
            LoadNextScene();
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}



