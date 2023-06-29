using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      for(int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
                hearts[i].color = Color.white;

            }
            else
            {
                hearts[i].sprite = fullHeart;
                hearts[i].color = Color.black;
            }

            if (i < numOfHearts)
            {
                hearts[i].enabled = true;

            }
            else
            {
                hearts[i].enabled = false;
            }
        }   
    }

    public void addHealth(int heal)
    {
        health += heal;
    }

    public void getDamaged()
    {
        health--;
    }
}
