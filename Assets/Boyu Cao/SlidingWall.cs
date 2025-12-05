using System.Collections;
using UnityEngine;

public class SlidingWall : MonoBehaviour
{
    public Transform wall;
    public float moveUpDistance = 3f;
    public float duration = 2f;

    public void OpenWall()
    {
        StartCoroutine(SlideUp());
    }

    private IEnumerator SlideUp()
    {
        Vector3 start = wall.position;
        Vector3 end = start + Vector3.up * moveUpDistance;

        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime / duration;
            wall.position = Vector3.Lerp(start, end, t);
            yield return null;
        }

        wall.position = end;
    }
}

