using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    public Button highButton;
    public Button lowButton;
    // Start is called before the first frame update
    void Start()
    {
        
        StartGame();
    }

    // Update is called once per frame

    private void Update()
    {
        if (min == max)
        {
            highButton.enabled = false;
            lowButton.enabled = false;
        }
        if (max > 1000)
        {
            highButton.enabled = false;
            lowButton.enabled = false;

        }
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
        
    }
}