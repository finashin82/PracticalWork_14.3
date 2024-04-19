using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorOn : MonoBehaviour
{
    [Tooltip("����.")]
    [SerializeField] Animator _elevator;

    private bool elevatorPermission = false;    

    // Update is called once per frame
    void Update()
    {
        if (elevatorPermission)
        {
            // �������� �������� ��� ������ �����
            _elevator.SetBool("ElevatorOn", true);
        }
        else
        {
            // ��������� �������� ��� ������ �����
            _elevator.SetBool("ElevatorOn", false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // ���� ������ ����� � ���� � Rigidbody, �� ���� ���������� �� ������ �����
        if (other.attachedRigidbody != null)
        {            
            elevatorPermission = true;
        }        
    }

    private void OnTriggerExit(Collider other)
    {
        // ���� ������ ����� �� ����, �� �������� ���������� �� ������ �����
        if (other.attachedRigidbody != null)
        {            
            elevatorPermission = false;            
        }
    }
}
