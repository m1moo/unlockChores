using UnityEngine;

public class DirtManager : MonoBehaviour

{
    public int dirtCount;

    public SimpleSceneLoader sceneLoader;

    public void OnDirtSpawn()
    {
        dirtCount++;
        Debug.Log("Dirt spawned. Total: " + dirtCount);
    }

    public void OnDirtRemoved()
    {
        dirtCount--;
        Debug.Log("Dirt cleaned. Remaining: " + dirtCount);

        if (dirtCount <= 0)
        {
            Debug.Log("Window fully cleaned!");
            sceneLoader.LoadNextScene();
        }
    }
}