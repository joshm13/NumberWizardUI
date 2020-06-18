using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        nextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        nextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        nextGuess();
    }

    void nextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

}


