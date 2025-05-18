using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int contador;
    public int contadorBetterScore;
    public TextMeshProUGUI score;
    
    public TextMeshProUGUI betterScore;

    void Start()
    {
        if (!PlayerPrefs.HasKey("BetterScore"))
        {
            PlayerPrefs.SetInt("BetterScore", 0);
        }
        else
        {
            contadorBetterScore = PlayerPrefs.GetInt("BetterScore");

            betterScore.text = "BETTER SCORE: " + contadorBetterScore.ToString();
        }
    }

    public void Pontuar()
    {
        contador += 1;
        score.text = "SCORE: " + contador.ToString();

        if (contador > contadorBetterScore)
        {
            contadorBetterScore = contador;

            PlayerPrefs.SetInt("BetterScore", contadorBetterScore);

            betterScore.text = score.text = "BETTER SCORE: " + contadorBetterScore.ToString();
        }
    }
}

