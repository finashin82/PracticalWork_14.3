using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelTransition : MonoBehaviour
{
    [Tooltip("����� ������")]
    [SerializeField] private int _level;   

    /// <summary>
    ///  ��������� �������
    /// </summary>
    public void LevelTransitionsButton()
    {        
        // ��������� �����
        SceneManager.LoadScene(_level);        
    }
    
    /// <summary>
    /// ������ ����� � ����
    /// </summary>
    public void PauseButton()
    {
        Time.timeScale = 0;
    }

    /// <summary>
    /// ������ ����������� ����
    /// </summary>
    public void PlayButton()
    {
        Time.timeScale = 1;
    }

    /// <summary>
    ///  ������� �� ��������� �������
    /// </summary>
    public void NextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }    

    /// <summary>
    ///  ������ ������
    /// </summary>
    public void RepeatLevel()    
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// ������� ����
    /// </summary>
    public void MainMenuLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}

