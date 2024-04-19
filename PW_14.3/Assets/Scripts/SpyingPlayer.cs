using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpyingPlayer : MonoBehaviour
{
    [Tooltip("Поле для Player. Отслеживание SetActive игрока.")]
    [SerializeField] private GameObject _player;

    [Tooltip("Поле для Particle System. Взрыв игрока.")]
    [SerializeField] private ParticleSystem _burstsPlayer;

    private bool isPermissionBursts = true;

    private int countSecond = 2;

    // Update is called once per frame
    void Update()
    {
        // Проверка на исчезновение игрока со сцены
        if (_player.activeSelf == false)
        {
            StartCoroutine(Timer());
            
            // Запуск взрыва один раз
            if (isPermissionBursts)
            {
                _burstsPlayer.Play();
                isPermissionBursts = false;
            }
        }
    }

    /// <summary>
    /// Запуск уровня заново через несколько секунд
    /// </summary>
    /// <returns></returns>
    private IEnumerator Timer()
    {
        // Загруза уровня заново через несколько секунд
        yield return new WaitForSeconds(countSecond);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
