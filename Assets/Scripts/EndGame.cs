using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private static bool gameEnded = false;

    public static void SetGameEnded(bool state)
    {
        gameEnded = state;
    }
    public static bool GetGameEnded()
    {
        return gameEnded;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pin"))
        {
            SetGameEnded(true);
        }
    }
}
