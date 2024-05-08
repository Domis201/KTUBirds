using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    [SerializeField] Text health;

    public int currentLives;

    private void Awake()
    {
        currentLives = 3;
        UpdateHUD();
    }

    private void UpdateHUD()
    {
        health.text = currentLives.ToString();
    }
    void Update()
    {
        UpdateHUD();
    }

    public void LoseLive(int amount)
    {
        currentLives = currentLives - amount;
    }

}
