using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Person : MonoBehaviour
{
    public Text txtComponent;

    // ���� - �̸�
    string Name = "������";

    // ���� - ��������, ��������, ��������
    int mathScore;
    int englishScore;
    int koreanScore;

    //x
    int average;

    void Start()
    {
        average = (mathScore + englishScore + koreanScore) / 3;

    }

    public void gacha ()
    {
        Debug.Log("��í�� �߽��ϴ�!");

        mathScore = Random.Range(0, 100);
        englishScore = Random.Range(0, 100);
        koreanScore = Random.Range(0, 100);

        average = (mathScore + englishScore + koreanScore) / 3;

        txtComponent.text = "��í�� �߽��ϴ�!";
    }
    // �Լ�
    public void Math()
    {
        if (mathScore >= 90)
        {
            Debug.Log("���� ���迡 �հ��߽��ϴ�.");

            txtComponent.text = "���� ���迡 �հ��߽��ϴ�.";
        }
        else if (mathScore >= 70)
        {
            Debug.Log("������Դϴ�.");

            txtComponent.text = "������Դϴ�.";
        }
        else
        {
            Debug.Log("���н����� ���հ��Դϴ�.");

            txtComponent.text = "���н����� ���հ��Դϴ�.";
        }
    }

    public void English()
    {
        if (englishScore >= 90)
        {
            Debug.Log("���� ���迡 �հ��߽��ϴ�.");

            txtComponent.text = "���� ���迡 �հ��߽��ϴ�.";
        }
        else if (englishScore >= 70)
        {
            Debug.Log("������Դϴ�.");

            txtComponent.text = "������Դϴ�.";
        }
        else
        {
            Debug.Log("��������� ���հ��Դϴ�.");

            txtComponent.text = "��������� ���հ��Դϴ�.";
        }
    }

    public void LLLL()
    {
        if (mathScore >= 50)
        {
            Debug.Log("���� ���迡 ����߽��ϴ�.");

            txtComponent.text = "���� ���迡 ����߽��ϴ�.";
        }
        else
        {
            Debug.Log("���� ���迡 ������� ���߽��ϴ� �Ф�");

            txtComponent.text = "���� ���迡 ������� ���߽��ϴ� �Ф�";
        }

        // ����, ���� ���� ��� ����

        // 3 ��� 60�� ���ϸ� ����� ����
        Debug.Log("��� ������ �����ϴ�. ��� �� ������ ���� �ʾƵ� �˴ϴ�.");
        Debug.Log("����� ���߽��ϴ�. ��� �Ŀ� 302ȣ�� ���̼���.");
    }

    public void test()
    {
        Debug.Log("��í ��� ���");
        Debug.Log("�������: " + average + "��");

        if (average >= 90)
        {
            Debug.Log("���-��������");

            txtComponent.text = "���-��������";
        }
        else if (average >= 70)
        {
            Debug.Log("���-���� ����");

            txtComponent.text = "���-���� ����";
        }
        else if (average >= 50)
        {
            Debug.Log("���-����");

            txtComponent.text = "���-����";
        }
        else
        {
            Debug.Log("���-Ŀ��");

            txtComponent.text = "���-Ŀ��";
        }
    }
}