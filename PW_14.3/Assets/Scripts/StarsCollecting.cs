using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StarsCollecting : MonoBehaviour
{
    [Tooltip("���������� ����� � ������ ������")]
    [SerializeField] private Text _starsCountWin;

    [Tooltip("���������� � ������")]
    [SerializeField] private Text _starQuantityConclusion;

    [Tooltip("���� ��� ����� �����")]
    [SerializeField] private AudioSource _starAudioClip;    

    private int starCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        // ���� �����
        if (other.CompareTag("Star"))
        {
            // �������� ���� ��� ����� ������
            _starAudioClip.Play();

            // ���������� ������
            Destroy(other.gameObject);           

            // ����������� ���������� �����
            starCount += 1;

            // ������� ���������� ����� �� �����
            _starQuantityConclusion.text = starCount.ToString();

            // ������� ������ �� ����� ������
            _starsCountWin.text = starCount.ToString();
        }        
    }
}
