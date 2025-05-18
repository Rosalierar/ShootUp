using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidade : MonoBehaviour
{
    public Vector2 velocidade;

    void FixedUpdate() {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = velocidade;
    }
}


