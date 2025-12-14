using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashCounter : MonoBehaviour
{
    public static TrashCounter instance;

    public int totalTrashToSort = 9;
    private int sortedTrash = 0;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void TrashSorted()
    {
        sortedTrash++;
        Debug.Log("Trash sorted: " + sortedTrash + "/" + totalTrashToSort);

        if (sortedTrash >= totalTrashToSort)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
