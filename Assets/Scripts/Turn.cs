using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{   
    float speed = 100f;
    void Update()
    {
        if(!EndGame.GetGameEnded())
            transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }

}
