using UnityEngine;
using System.Collections;

public class ClothesSortingManager : MonoBehaviour
{
    public static ClothesSortingManager Instance;

    [Header("Sorting Settings")]
    public int totalItems = 12;
    private int correctlySorted = 0;

    [Header("Wall Settings")]
    public Transform wallToOpen;           // The wall object
    public float slideUpAmount = 3f;       // How high it moves
    public float slideDuration = 1.5f;     // Speed of movement

    [Header("Wall Audio")]
    public AudioSource wallAudioSource;    // Audio source on the wall
    public AudioClip openSound;            // Sound to play when opening

    private Vector3 closedPosition;
    private Vector3 openPosition;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        if (wallToOpen != null)
        {
            closedPosition = wallToOpen.position;
            openPosition = closedPosition + new Vector3(0, slideUpAmount, 0);
        }
    }

    public void OnCorrectItemSorted()
    {
        correctlySorted++;

        if (correctlySorted >= totalItems)
        {
            StartCoroutine(SlideWallUp());
        }
    }

    private IEnumerator SlideWallUp()
    {
        // Play open sound once
        if (wallAudioSource != null && openSound != null)
        {
            wallAudioSource.PlayOneShot(openSound);
        }

        float t = 0f;

        while (t < slideDuration)
        {
            t += Time.deltaTime;
            float lerp = Mathf.Clamp01(t / slideDuration);

            wallToOpen.position = Vector3.Lerp(closedPosition, openPosition, lerp);
            yield return null;
        }

        wallToOpen.position = openPosition;
    }
}


