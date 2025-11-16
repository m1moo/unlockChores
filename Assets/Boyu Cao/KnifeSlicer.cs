using UnityEngine;

public class KnifeSlicer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SlicableVegetable veg = other.GetComponentInParent<SlicableVegetable>();

        if (veg != null)
        {
            Vector3 sliceDir = transform.forward;
            veg.Slice(sliceDir);
        }
    }
}

