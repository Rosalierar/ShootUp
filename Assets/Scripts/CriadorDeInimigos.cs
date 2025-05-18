using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CriadorDeInimigos : MonoBehaviour
{
    public GameObject[] prefabs;
    public Vector3 range;
    public float repeatTime;
    Score score;

    public void Awake() {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    void Start() {
        InvokeRepeating("Create", 0, repeatTime);
    }

    void Create() {

        GameObject prefab = prefabs [Random.Range (0, prefabs.Length)];
        Vector3 pos = this.transform.position + Vector3.Lerp(-range, range, Random.value);
        Instantiate(prefab, pos, Quaternion.identity);
    }
}

