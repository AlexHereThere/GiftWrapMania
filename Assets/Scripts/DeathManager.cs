using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{
    public TextMeshProUGUI pointsText;
    public Button buttonReset;
    public Button buttonMainMenu;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        pointsText.text = score.ToString() + " POINTS";
        print("Game Over");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        buttonReset.onClick.AddListener(RestartButton);
        buttonMainMenu.onClick.AddListener(ExitButton);
    }
    
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        print("PresionandoReset");

    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
        print("PresionandoMain");
    }
}
