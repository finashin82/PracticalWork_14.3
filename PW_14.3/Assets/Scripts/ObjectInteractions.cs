using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectInteractions : MonoBehaviour
{
    [Tooltip("������ ������ ��� ����������� ������")]
    [SerializeField] private GameObject _objectPanelWin;

    [Tooltip("������ ������ ��� ����������� ����")]
    [SerializeField] private GameObject _objectPanelEndGame;

    public void OnTriggerEnter(Collider other)
    {
        // ���� �������� ����������� ���������, ������ ������
        //if (other.CompareTag("Death"))
        //{
        //    // ��������� ������ �������� �����
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //}

        // ���� �������� ������, ��������� �� ��������� �������
        if (other.CompareTag("Finish"))
        {
            Time.timeScale = 0;
            _objectPanelWin.SetActive(true);
        }

        // ��� ������� ������� ����� ��������
        if (other.CompareTag("Death"))
        {
            gameObject.SetActive(false);
        }

        // ������ "����� ����"
        if (other.CompareTag("EndGame"))
        {
            Time.timeScale = 0;
            _objectPanelEndGame.SetActive(true);
        }
    }
}
