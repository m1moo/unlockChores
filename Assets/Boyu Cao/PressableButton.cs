using UnityEngine;
using UnityEngine.Events;

public class PressableButton : MonoBehaviour
{
    public UnityEvent onPressed;

    private bool isPressed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isPressed) return;

        isPressed = true;
        onPressed.Invoke();

        Invoke(nameof(ResetButton), 0.3f);
    }

    private void ResetButton()
    {
        isPressed = false;
    }
}

