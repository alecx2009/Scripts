using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temperature : MonoBehaviour
{
    private float currrentTemp = 36.6f;
    private float maxTemp = 36.6f;
    private float minTemp = 34.4f;
    public TextMeshProUGUI tempText;
    public int damage = 2;
    private float delay = 2;
    public float freezeSpeed = 0.05f;
    // Update is called once per frame
    void Update()
    {
        currrentTemp -= 0.1f * Time.deltaTime;
        tempText.text = System.MathF.Round(currrentTemp,2).ToString();
        if (currrentTemp <= minTemp)
        {
            delay -= Time.deltaTime;
            if (delay <= 0)
            {
                print("Проверь темпу");
                gameObject.GetComponent<Health>().TakeDamage(damage);
                delay = 2;
            }
        }
    }

    public void TemperatureUp(float temp)
    {
        if (currrentTemp < maxTemp)
        {
            currrentTemp += temp * Time.deltaTime;
        }
    }
}