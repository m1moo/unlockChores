using UnityEngine;

public class SortingZone : MonoBehaviour
{
    [Header("Sorting")]
    public ClothingType acceptedType;   // Which type this zone accepts

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    [Header("Particles")]
    public ParticleSystem correctEffectPrefab;
    public ParticleSystem wrongEffectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        // Check if this object is a clothing item
        ClothingItem clothing = other.GetComponent<ClothingItem>();
        if (clothing == null) return;

        bool isCorrect = clothing.type == acceptedType;
        Vector3 hitPosition = clothing.transform.position;

        // Play feedback (sound + particles)
        PlayFeedback(isCorrect, hitPosition);

        if (isCorrect)
        {
            Debug.Log("Correctly sorted: " + clothing.type);

            // Tell the manager we sorted one correctly
            if (ClothesSortingManager.Instance != null)
            {
                ClothesSortingManager.Instance.OnCorrectItemSorted();
            }

            // Remove the clothing item
            Destroy(clothing.gameObject);
        }
        else
        {
            Debug.Log("Wrong slot!");

            // If you want, you could also push the item out or leave it
            // For now, we just play wrong feedback and do nothing else
        }
    }

    private void PlayFeedback(bool correct, Vector3 position)
    {
        // Audio
        if (audioSource != null)
        {
            if (correct && correctSound != null)
            {
                audioSource.PlayOneShot(correctSound);
            }
            else if (!correct && wrongSound != null)
            {
                audioSource.PlayOneShot(wrongSound);
            }
        }

        // Particles
        ParticleSystem prefab = correct ? correctEffectPrefab : wrongEffectPrefab;
        if (prefab != null)
        {
            ParticleSystem effect = Instantiate(prefab, position, Quaternion.identity);
            effect.Play();
            Destroy(effect.gameObject, effect.main.duration + 0.1f);
        }
    }
}




