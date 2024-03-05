using UnityEngine;

public class MonsterController : MonoBehaviour
{
    private int health = 3; // ��������� ���������� ������ �������
    private int score = 0; // ��������� ���������� �����

    public void OnClick()
    {
        if (health > 0) // ���������, ��� � ������� �������� �����
        {
            health--; // ��������� ���������� ������ �� 1

            if (health == 0) // ���� ����� �����������
            {
                score += 100; // ����������� ���������� ����� �� 100
                Debug.Log("������ ���������! ����: " + score); // ������� ��������� � ���, ��� ������ ��������� � ���������� ������� ���������� �����
            }
        }
    }
}