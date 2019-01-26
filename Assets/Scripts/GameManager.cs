using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static int health=100;
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthText.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage_Small()
    {
        health -= 10;
    }

    public void TakeDamage_High()
    {
        health -= 30;
    }

    public void PlayerDeath()
    {
        Debug.Log("Player Died");

    }
}
