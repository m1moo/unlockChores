using UnityEngine;

public class BinTrigger : MonoBehaviour
{
    public string binColor; // Set this in Inspector: "Red", "Blue", "Green"

    private void OnTriggerEnter(Collider other)
    {
        TrashObject trash = other.GetComponent<TrashObject>();

        if (trash != null)
        {
            if (trash.trashColor == binColor)
            {
                Debug.Log("Correct bin! " + trash.trashColor);
            }
            else
            {
                Debug.Log("Wrong bin! Trash was " + trash.trashColor + " but bin is " + binColor);
            }
        }
    }
}
