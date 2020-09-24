using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUp : MonoBehaviour
{
    float speed = 40f;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if(!PinToRotator.isPinned && !EndGame.GetGameEnded())
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }
}
