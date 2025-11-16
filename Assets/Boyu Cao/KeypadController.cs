using UnityEngine;
using TMPro;

public class KeypadController : MonoBehaviour
{
    [Header("Keypad Settings")]
    public string correctCode = "4231";     
    public TextMeshProUGUI display;        

    [Header("Door")]
    public DoorOpener door;                 

    private string input = "";              
    private bool unlocked = false;          

    public void PressNumber(string number)
    {
        if (unlocked) return;               
        if (input.Length >= 4) return;      

        input += number;                    
        UpdateDisplay();                    

        if (input.Length == 4)              
            CheckCode();
    }


    public void ClearInput()
    {
        if (unlocked) return;
        input = "";
        UpdateDisplay();
    }


    private void CheckCode()
    {
        if (input == correctCode)
        {
            Unlock();
        }
        else
        {
            display.text = "WRONG";
            Invoke(nameof(ClearInput), 1f);  
        }
    }

   
    private void Unlock()
    {
        unlocked = true;
        display.text = "OPEN";

        if (door != null)
            door.OpenDoor();                
    }


    private void UpdateDisplay()
    {
        display.text = input;
    }
}


