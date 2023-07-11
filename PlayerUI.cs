using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // NEW
using TMPro; // NEW

public class PlayerUI : MonoBehaviour
{
    // Add these inside the unity editor !!!
    public PlayerNS player;
    public TextMeshProUGUI counterText;
    public Slider hpSlider;

    void Update() {
        // Update the player's hp
        hpSlider.maxValue = player.maxHealth;
        hpSlider.value = player.health;

        // We have access to the player class fields (like health)
        // because we create a player object reference (PlayerNS)
        // inside this script.

        counterText.text = player.coins.ToString();
    }
}