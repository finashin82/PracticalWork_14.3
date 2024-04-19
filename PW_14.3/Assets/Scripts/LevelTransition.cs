using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelTransition : MonoBehaviour
{
    [Tooltip("Номер уровня")]
    [SerializeField] private int _level;   

    /// <summary>
    ///  Загружаем уровень
    /// </summary>
    public void LevelTransitionsButton()
    {        
        // Загружаем сцену
        SceneManager.LoadScene(_level);        
    }
    
    /// <summary>
    /// Кнопка паузы в игре
    /// </summary>
    public void PauseButton()
    {
        Time.timeScale = 0;
    }

    /// <summary>
    /// Кнопка продолжения игры
    /// </summary>
    public void PlayButton()
    {
        Time.timeScale = 1;
    }

    /// <summary>
    ///  Переход на следующий уровень
    /// </summary>
    public void NextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }    

    /// <summary>
    ///  Повтор уровня
    /// </summary>
    public void RepeatLevel()    
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// Главное меню
    /// </summary>
    public void MainMenuLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}

