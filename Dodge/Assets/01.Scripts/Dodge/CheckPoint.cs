
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    public GameObject Point; // ����Ʈ ����
    public float checkTime;  // �ð� �˻��� ���� ����
    public static bool PointSpawn;
    public Text Score_text;        //������ ǥ���� �ؽ�Ʈ ������Ʈ
    public int Score = 0;

    void Start()
    {
        PointSpawn = false;
    }
    void Update()
    {
       
        if (PointSpawn == false)
        {
            GameObject temp = Instantiate(Point);  //����Ʈ �������� Instantiate �� �����Ѵ�.
            temp.transform.position = this.gameObject.transform.position;  //�����Ҷ� ��ũ��Ʈ�� �ִ� ������Ʈ ��ġ�� ����
            int RandomNumber = Random.Range(1, 4); //4�� 9������ �������� �޾Ƽ�
            if (RandomNumber == 1)
            {
                temp.transform.position += new Vector3(-4.0f, 0.0f, 4.0f); //Y�� ��ġ�� �����ش�.
            }
            if (RandomNumber == 2)
            {
                temp.transform.position += new Vector3(4.0f, 0.0f, -4.0f); //Y�� ��ġ�� �����ش�.
            }
            if (RandomNumber == 3)
            {
                temp.transform.position += new Vector3(4.0f, 0.0f, 4.0f); //Y�� ��ġ�� �����ش�.
            }
            if (RandomNumber == 4)
            {
                temp.transform.position += new Vector3(-4.0f, 0.0f, -4.0f); //Y�� ��ġ�� �����ش�.
            }

            PointSpawn = true;
        }

    }
}
