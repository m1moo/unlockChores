using UnityEngine;

public class VegetableSliceManager : MonoBehaviour
{
    public int totalVegetables = 2;   // how many must be sliced
    private int slicedCount = 0;

    public SlidingWall slidingWall;   // assign your wall script here

    public void OnVegetableSliced()
    {
        slicedCount++;

        if (slicedCount >= totalVegetables)
        {
            slidingWall.OpenWall();
        }
    }
}
