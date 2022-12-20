using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Person : MonoBehaviour
{
    public Text txtComponent;

    // 문자 - 이름
    string Name = "염예찬";

    // 숫자 - 수학점수, 영어점수, 국어점수
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
        Debug.Log("가챠를 했습니다!");

        mathScore = Random.Range(0, 100);
        englishScore = Random.Range(0, 100);
        koreanScore = Random.Range(0, 100);

        average = (mathScore + englishScore + koreanScore) / 3;

        txtComponent.text = "가챠를 했습니다!";
    }
    // 함수
    public void Math()
    {
        if (mathScore >= 90)
        {
            Debug.Log("수학 시험에 합격했습니다.");

            txtComponent.text = "수학 시험에 합격했습니다.";
        }
        else if (mathScore >= 70)
        {
            Debug.Log("재시험입니다.");

            txtComponent.text = "재시험입니다.";
        }
        else
        {
            Debug.Log("수학시험은 불합격입니다.");

            txtComponent.text = "수학시험은 불합격입니다.";
        }
    }

    public void English()
    {
        if (englishScore >= 90)
        {
            Debug.Log("영어 시험에 합격했습니다.");

            txtComponent.text = "영어 시험에 합격했습니다.";
        }
        else if (englishScore >= 70)
        {
            Debug.Log("재시험입니다.");

            txtComponent.text = "재시험입니다.";
        }
        else
        {
            Debug.Log("영어시험은 불합격입니다.");

            txtComponent.text = "영어시험은 불합격입니다.";
        }
    }

    public void LLLL()
    {
        if (mathScore >= 50)
        {
            Debug.Log("수학 시험에 통과했습니다.");

            txtComponent.text = "수학 시험에 통과했습니다.";
        }
        else
        {
            Debug.Log("수학 시험에 통과하지 못했습니다 ㅠㅠ");

            txtComponent.text = "수학 시험에 통과하지 못했습니다 ㅠㅠ";
        }

        // 영어, 국어 시험 통과 여부

        // 3 평균 60점 이하면 방과후 수업
        Debug.Log("평균 점수가 높습니다. 방과 후 수업을 하지 않아도 됩니다.");
        Debug.Log("평균이 망했습니다. 방과 후에 302호로 모이세요.");
    }

    public void test()
    {
        Debug.Log("가챠 평균 결과");
        Debug.Log("평균점수: " + average + "점");

        if (average >= 90)
        {
            Debug.Log("등급-레전더리");

            txtComponent.text = "등급-레전더리";
        }
        else if (average >= 70)
        {
            Debug.Log("등급-슈퍼 에픽");

            txtComponent.text = "등급-슈퍼 에픽";
        }
        else if (average >= 50)
        {
            Debug.Log("등급-에픽");

            txtComponent.text = "등급-에픽";
        }
        else
        {
            Debug.Log("등급-커먼");

            txtComponent.text = "등급-커먼";
        }
    }
}