using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int contador;
    public TextMeshProUGUI score;
    
    public TextMeshProUGUI betterScore;

    void Start()
    {

    }

    public void Pontuar()
    {
        contador += 1;
        score.text = "SCORE: " + contador.ToString();
    }

}

