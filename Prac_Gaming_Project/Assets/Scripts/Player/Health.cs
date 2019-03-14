using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour
{
    public Slider healthSlider;
    private int currentHealth = 100;
    private int minHealth = 0;
    private int maxHealth = 100;
    private bool isDead = false;
    private int deathCount = 0;
    public Text gameOverText;

    void Update()
    {
        if(currentHealth == minHealth)
        {
            isDead = true;
            deathCount++;
        }

        if(isDead)
        {
            gameOver();
        }
    }

    public void lossHealth(int healthLoss)
    {
        if(currentHealth != minHealth)
        {
            currentHealth -= healthLoss;
            healthSlider.value = currentHealth;
        }
    }

    public void gainHealth(int healthGain)
    {
        if(currentHealth != maxHealth)
        {
            currentHealth += healthGain;
            healthSlider.value = currentHealth;
        }
    }

    private void gameOver()
    {
        if(deathCount==1)
        {
            gameOverText.text = "GAME OVER";
        }
    }
}