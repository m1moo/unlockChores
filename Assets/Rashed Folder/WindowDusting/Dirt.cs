using UnityEngine;

public class Dirt : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cloth"))
        {
            Destroy(gameObject);
        }
    }
}
