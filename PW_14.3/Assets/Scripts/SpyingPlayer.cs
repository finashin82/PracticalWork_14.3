using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpyingPlayer : MonoBehaviour
{
    [Tooltip("���� ��� Player. ������������ SetActive ������.")]
    [SerializeField] private GameObject _player;

    [Tooltip("���� ��� Particle System. ����� ������.")]
    [SerializeField] private ParticleSystem _burstsPlayer;

    private bool isPermissionBursts = true;

    private int countSecond = 2;

    // Update is called once per frame
    void Update()
    {
        // �������� �� ������������ ������ �� �����
        if (_player.activeSelf == false)
        {
            StartCoroutine(Timer());
            
            // ������ ������ ���� ���
            if (isPermissionBursts)
            {
                _burstsPlayer.Play();
                isPermissionBursts = false;
            }
        }
    }

    /// <summary>
    /// ������ ������ ������ ����� ��������� ������
    /// </summary>
    /// <returns></returns>
    private IEnumerator Timer()
    {
        // ������� ������ ������ ����� ��������� ������
        yield return new WaitForSeconds(countSecond);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
