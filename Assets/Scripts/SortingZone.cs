using UnityEngine;

public class SortingZone : MonoBehaviour
{
    public ClothingType acceptedType;

    private void OnTriggerEnter(Collider other)
    {
        var clothing = other.GetComponent<ClothingItem>();
        if (clothing == null) return;

        if (clothing.type == acceptedType)
        {
            Debug.Log("Correctly sorted: " + clothing.type);
            Destroy(clothing.gameObject); 
        }
        else
        {
            Debug.Log("Wrong slot!");
        }
    }
}

