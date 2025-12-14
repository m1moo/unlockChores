using UnityEngine;

public class PickPlaceManager : MonoBehaviour
{
    public int totalItems;   // how many correct items needed
    private int placedItems;

    public SimpleSceneLoader sceneLoader;

    public void ItemPlacedCorrectly()
    {
        placedItems++;
        Debug.Log("Correct items placed: " + placedItems + "/" + totalItems);

        if (placedItems >= totalItems)
        {
            Debug.Log("Pick & Place completed!");
            sceneLoader.LoadNextScene();
        }
    }
}