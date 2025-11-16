using UnityEngine;

public class SlicableVegetable : MonoBehaviour
{
    [Header("Setup")]
    public GameObject wholeObject;
    public GameObject[] slicedPieces;

    [Header("Settings")]
    public float sliceForce = 2f;

    private bool isSliced = false;

    public void Slice(Vector3 knifeDirection)
    {
        if (isSliced) return;

        isSliced = true;

        wholeObject.SetActive(false);

        foreach (GameObject piece in slicedPieces)
        {
            piece.SetActive(true);

            Rigidbody rb = piece.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(knifeDirection * sliceForce, ForceMode.Impulse);
            }
        }
    }
}

