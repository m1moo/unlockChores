using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    public string basketType; // "Toy" or "Ball"
    public PickPlaceManager pickPlaceManager; // assign in Inspector

    private void OnTriggerEnter(Collider other)
    {
        ItemType item = other.GetComponent<ItemType>();

        if (item == null)
        {
            return;
        }

        if (item.typeName == basketType)
        {
            Debug.Log("Correct item placed in: " + basketType + " basket");

            // Tell manager ONE item is done
            pickPlaceManager.ItemPlacedCorrectly();

            // Remove item so it can't be counted again
            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("Wrong item for this basket!");

            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            }
        }
    }
}
