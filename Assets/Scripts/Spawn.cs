using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pin;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !EndGame.GetGameEnded())
        {
            SpawnPin();
        }
    }

    void SpawnPin()
    {
        PinToRotator.isPinned = false;
        Instantiate(pin, transform.position, transform.rotation);
    }
}
