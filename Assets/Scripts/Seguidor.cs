using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguidor : MonoBehaviour
{
    public GameObject alvo;
    public float speed;

    void Start()
    {
        alvo = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 pos = alvo.transform.position - this.transform.position;
        Vector3 velocidade = pos.normalized * speed;
        this.transform.Translate(velocidade * Time.deltaTime);
    }
}


