using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Tiro : MonoBehaviour
{
    public GameObject explode;
    public string alvo;
    Score score;

    public void Awake() {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<Score>();
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.name.StartsWith (alvo)) {
            Vector3 pos = col.transform.position;
            GameObject clone = (GameObject)Instantiate(explode, pos, Quaternion.identity);
            score.Pontuar();
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Destroy (clone, 0.05f);
            if(col.name.StartsWith ("Player")) {
                SceneManager.LoadScene(2);
            }
        }
    }
}


