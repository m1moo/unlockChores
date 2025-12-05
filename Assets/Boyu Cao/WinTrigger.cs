using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public AudioSource partySound;   // drag your audio source here
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;
        if (!other.CompareTag("Player")) return;

        triggered = true;

        if (partySound != null)
            partySound.Play();
    }
}

