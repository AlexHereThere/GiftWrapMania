using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        pointsText.text = score + " POINTS";
        print("Game Over");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void ExitButton()
    {
        SceneManager.LoadScene(0);
    }
}