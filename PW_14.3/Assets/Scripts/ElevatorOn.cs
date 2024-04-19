using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorOn : MonoBehaviour
{
    [Tooltip("Лифт.")]
    [SerializeField] Animator _elevator;

    private bool elevatorPermission = false;    

    // Update is called once per frame
    void Update()
    {
        if (elevatorPermission)
        {
            // Включаем параметр для работы лифта
            _elevator.SetBool("ElevatorOn", true);
        }
        else
        {
            // Выключаем параметр для работы лифта
            _elevator.SetBool("ElevatorOn", false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // Если объект вошел в зону с Rigidbody, то даем разрешение на работу лифта
        if (other.attachedRigidbody != null)
        {            
            elevatorPermission = true;
        }        
    }

    private void OnTriggerExit(Collider other)
    {
        // Если объект вышел из зоны, то отзываем разрешение на работу лифта
        if (other.attachedRigidbody != null)
        {            
            elevatorPermission = false;            
        }
    }
}
