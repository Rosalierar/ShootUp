using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimentar : MonoBehaviour
{
    public float speed = 5;
    public GameObject tiro;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            Vector3 pos = new Vector2(this.transform.position.x, this.transform.position.y + 0.5f);
            Instantiate(tiro, pos, Quaternion.Euler(0,0,180));
        }
    }

    void FixedUpdate() {
        float h = Input.GetAxis("Horizontal");

        Rigidbody2D r = this.GetComponent<Rigidbody2D>();
        r.velocity = new Vector3(h,0,0) * speed;
    }
}
