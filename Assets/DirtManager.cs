using UnityEngine;

public class DirtManager : MonoBehaviour
{
    public int dirtCount;
    public void OnDirtRemoved()
    {
        dirtCount--;
        
    }
    public void OnDirtSpawn()
    {
        dirtCount++;
    }
}
