using UnityEngine;

public class LeverState : MonoBehaviour
{
    public bool isUp;
    public LeverPuzzleManager manager;

    void Update()
    {
        // Get lever rotation
        float z = transform.localEulerAngles.z;

        // Convert angle from 0–360 to -180–180
        if (z > 180) z -= 360;

        // Lever is UP if angle is above 0
        bool newState = z > 0;

        // Only update if it changed (prevents spam)
        if (newState != isUp)
        {
            isUp = newState;
            manager.CheckPuzzle();     // Check puzzle every time a lever is moved
        }
    }
}
