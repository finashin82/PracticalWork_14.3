using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [Tooltip("��������� ��� ������� � �����.")]
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
                // �������� �����
                animDoor.SetBool("OpenDoor", true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // ���� � ����� ������� �����
        if (other.CompareTag("Player"))
        {
            // ��������� ������ � ���������� �������� �����
            _gameObject.SetActive(true);

            // ���������� �� �������� �����
            isDoorPermission = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // ���� ����� ������ �� �����
        if (other.CompareTag("Player"))
        {
            // ������������ ������ � ���������� �������� �����
            _gameObject.SetActive(false);
        }
    }
}
