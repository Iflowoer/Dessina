
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    public GameObject Point; // 포인트 정의
    public float checkTime;  // 시간 검사할 변수 선언
    public static bool PointSpawn;
    public Text Score_text;        //점수를 표시할 텍스트 컴포넌트
    public int Score = 0;

    void Start()
    {
        PointSpawn = false;
    }
    void Update()
    {
       
        if (PointSpawn == false)
        {
            GameObject temp = Instantiate(Point);  //포인트 프리팹을 Instantiate 로 생성한다.
            temp.transform.position = this.gameObject.transform.position;  //생성할때 스크립트가 있는 오브젝트 위치로 생성
            int RandomNumber = Random.Range(1, 4); //4에 9까지의 랜덤값을 받아서
            if (RandomNumber == 1)
            {
                temp.transform.position += new Vector3(-4.0f, 0.0f, 4.0f); //Y값 위치에 더해준다.
            }
            if (RandomNumber == 2)
            {
                temp.transform.position += new Vector3(4.0f, 0.0f, -4.0f); //Y값 위치에 더해준다.
            }
            if (RandomNumber == 3)
            {
                temp.transform.position += new Vector3(4.0f, 0.0f, 4.0f); //Y값 위치에 더해준다.
            }
            if (RandomNumber == 4)
            {
                temp.transform.position += new Vector3(-4.0f, 0.0f, -4.0f); //Y값 위치에 더해준다.
            }

            PointSpawn = true;
        }

    }
}
