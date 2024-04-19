using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [Tooltip("Подсказка при подходе к двери.")]
    [SerializeField] private GameObject _gameObject;

    private Animator animDoor;
    private bool isDoorPermission = false;

    // Start is called before the first frame update
    void Start()
    {
        animDoor = GetComponent<Animator>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDoorPermission)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Откываем дверь
                animDoor.SetBool("OpenDoor", true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Если к двери подошел игрок
        if (other.CompareTag("Player"))
        {
            // Появление панели с подсказкой открытия двери
            _gameObject.SetActive(true);

            // Разрешение на открытие двери
            isDoorPermission = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Если игрок отошел от двери
        if (other.CompareTag("Player"))
        {
            // Исчезновение панели с подсказкой открытия двери
            _gameObject.SetActive(false);
        }
    }
}
