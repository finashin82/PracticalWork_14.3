using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectInteractions : MonoBehaviour
{
    [Tooltip("Панель победы при прохождении уровня")]
    [SerializeField] private GameObject _objectPanelWin;

    [Tooltip("Панель победы при прохождении игры")]
    [SerializeField] private GameObject _objectPanelEndGame;

    public void OnTriggerEnter(Collider other)
    {
        // Если коснулся запрещенных предметов, играем заново
        //if (other.CompareTag("Death"))
        //{
        //    // Запускаем заново активную сцену
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //}

        // Если коснулся выхода, переходим на следующий уровень
        if (other.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            _objectPanelWin.SetActive(true);
        }

        // При касании объекта игрок исчезает
        if (other.CompareTag("Death"))
        {
            gameObject.SetActive(false);
        }

        // Панель "Конец игры"
        if (other.CompareTag("EndGame"))
        {
            Time.timeScale = 0;
            _objectPanelEndGame.SetActive(true);
        }
    }
}
