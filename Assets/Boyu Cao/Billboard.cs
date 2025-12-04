using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Transform cam;

    void Start()
    {
        cam = Camera.main.transform; // VR headset camera
    }

    void LateUpdate()
    {
        if (cam == null) return;

        // Make the text face the player
        transform.LookAt(transform.position + cam.forward);
    }
}





