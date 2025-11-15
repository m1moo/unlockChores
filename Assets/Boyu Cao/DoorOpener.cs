using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    [Header("Slide Settings")]
    public Vector3 openOffset = new Vector3(0, 0, 1f);   
    public float speed = 2f;                            

    private bool isOpening = false;
    private Vector3 closedPosition;
    private Vector3 openPosition;

    private void Start()
    {
        closedPosition = transform.localPosition;
        openPosition = closedPosition + openOffset;
    }

    private void Update()
    {
        if (isOpening)
        {
            transform.localPosition = Vector3.Lerp(
                transform.localPosition,
                openPosition,
                Time.deltaTime * speed
            );
        }
    }

    public void OpenDoor()
    {
        isOpening = true;
    }
}


