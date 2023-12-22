using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI cointCounterText;
    public Slider healthSlider;

    private void Update()
    {
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;

        cointCounterText.text = player.coins.ToString();
    }
}
