using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinToRotator : MonoBehaviour
{
    public static bool isPinned = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Rotator"))
        {
            transform.SetParent(collision.transform);
            Score.PinCount++;
            isPinned = true;
        }
        
    }
    
}
