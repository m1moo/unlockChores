using UnityEngine;

public class DirtClean : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Brush"))
        {
            Debug.Log("Plate cleaned!");
            gameObject.SetActive(false); // simplest option
            // or Destroy(gameObject);
        }
    }
}
