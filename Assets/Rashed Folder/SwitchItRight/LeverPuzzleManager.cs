using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class LeverPuzzleManager : MonoBehaviour
{
    public LeverState[] levers;
    public bool[] correctPattern = { false, true, false, true, false };
    public SimpleSceneLoader sceneLoader;
    private bool puzzleSolved = false;

    public void CheckPuzzle()
    {
        if (puzzleSolved) return;

        for (int i = 0; i < levers.Length; i++)
        {
            if (levers[i].isUp != correctPattern[i])
            {
                Debug.Log("Wrong combination!");
                return;
            }
        }

        puzzleSolved = true;
        Debug.Log("Puzzle solved!");
        sceneLoader.LoadNextScene();
    }
}

