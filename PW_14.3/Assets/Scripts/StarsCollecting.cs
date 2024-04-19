using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StarsCollecting : MonoBehaviour
{
    [Tooltip("Количество звезд в панели победы")]
    [SerializeField] private Text _starsCountWin;

    [Tooltip("Количество в уровне")]
    [SerializeField] private Text _starQuantityConclusion;

    [Tooltip("Звук при сборе звезд")]
    [SerializeField] private AudioSource _starAudioClip;    

    private int starCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        // Сбор звезд
        if (other.CompareTag("Star"))
        {
            // Включаем звук при сборе звезды
            _starAudioClip.Play();

            // Уничтожаем объект
            Destroy(other.gameObject);           

            // Увеличиваем количество звезд
            starCount += 1;

            // Выводим количество звезд на экран
            _starQuantityConclusion.text = starCount.ToString();

            // Выводим звезды на экран победы
            _starsCountWin.text = starCount.ToString();
        }        
    }
}
