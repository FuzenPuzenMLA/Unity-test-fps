using UnityEngine;

public class EnemyServer : MonoBehaviour
{
    // ������ ����� ��������� �������� ��� ������ ������ ���������� ��� ������ ����� �������(��� ��� ������� � �����)
    // �� ����������� ������ ��������� ���� ������ �� ����� � ������ ������� ��� ������ ������
    // ��� � ����� ������ "�������" ��� ������������ GameObject.FindGameObjectWithTag("Player")
    [SerializeField] private Transform player;
    
    public Transform GetPlayer()
    {
        return player;
    }
}
