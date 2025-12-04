using UnityEngine;

public class SortingZone : MonoBehaviour
{
    public ClothingType acceptedType;

    [Header("Sound Effects")]
    public AudioSource audioSource;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    [Header("Particle Effects")]
    public ParticleSystem correctEffectPrefab;
    public ParticleSystem wrongEffectPrefab;

    private void OnTriggerEnter(Collider other)
    {
        var clothing = other.GetComponent<ClothingItem>();
        if (clothing == null) return;

        bool correct = clothing.type == acceptedType;

        // Play sound
        PlaySound(correct);

        // Play particles
        PlayParticles(correct, clothing.transform.position);

        if (correct)
        {
            Debug.Log("Correctly sorted: " + clothing.type);
            Destroy(clothing.gameObject);
        }
        else
        {
            Debug.Log("Wrong slot!");
        }
    }

    private void PlaySound(bool correct)
    {
        if (audioSource == null) return;

        if (correct && correctSound != null)
            audioSource.PlayOneShot(correctSound);
        else if (!correct && wrongSound != null)
            audioSource.PlayOneShot(wrongSound);
    }

    private void PlayParticles(bool correct, Vector3 position)
    {
        ParticleSystem prefab = correct ? correctEffectPrefab : wrongEffectPrefab;
        if (prefab == null) return;

        ParticleSystem effect = Instantiate(prefab, position, Quaternion.identity);
        effect.Play();

        Destroy(effect.gameObject, effect.main.duration + 0.1f);
    }
}



