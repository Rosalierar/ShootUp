using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentar : MonoBehaviour
{
    public float speed = 5;
    public GameObject tiro;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Vector3 pos = this.transform.position;
            Instantiate(tiro, pos, Quaternion.Euler(0,0,180));
        }
    }

    void FixedUpdate() {
        float h = Input.GetAxis("Horizontal");

        Rigidbody2D r = this.GetComponent<Rigidbody2D>();
        r.velocity = new Vector3(h,0,0) * speed;
    }
}
