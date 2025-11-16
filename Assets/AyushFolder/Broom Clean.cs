using UnityEngine;

public class BroomClean : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Brush"))
        {
            Debug.Log("Dirt cleaned!");
            gameObject.SetActive(false);
        }
    }
}
