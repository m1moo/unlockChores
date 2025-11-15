using UnityEngine;

public class BasketTrigger : MonoBehaviour
{
    public string basketType; // Set in Inspector: "Toy" or "Ball"

    private void OnTriggerEnter(Collider other)
    {
        // Get the ItemType component from the object entering the basket
        ItemType item = other.GetComponent<ItemType>();

        if (item == null)
        {
            Debug.Log("Object has no ItemType script.");
            return;
        }

        // Compare basket type with item type
        if (item.typeName == basketType)
        {
            Debug.Log("Correct item placed in: " + basketType + " basket");
            // Do success behavior (score, play sound, lock item, etc.)
        }
        else
        {
            Debug.Log("Wrong item for this basket!");

            // Example: push the object out
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
            }
        }
    }
}
