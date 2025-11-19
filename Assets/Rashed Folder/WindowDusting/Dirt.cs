using UnityEngine;

public class Dirt : MonoBehaviour
{
    public DirtManager manager;
    
    private void Start()
    {
        manager = GetComponentInParent<DirtManager>();
        manager.OnDirtSpawn();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cloth"))
        {
            manager.OnDirtRemoved();
            Destroy(gameObject);
        }
    }
}
