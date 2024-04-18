using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Spawner : MonoBehaviour
{

    public GameObject bullet_prefab;            //������ ź���� ���� ������
    public float spawn_rate_min = 0.5f;         //�ּ� ���� �ֱ�
    public float spawn_rate_max = 1f;           //�ִ� ���� �ֱ�

                           //�߻��� ���
    float spawn_rate;                           //�����ֱ�
    float time_after_spawn;                     //�ֱ� ���� �������� ���� �ð�            

    // Start is called before the first frame update
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        time_after_spawn = 0;
        //ź�� ���� ������ spawn_rate_min �� spawn_rate_max ���̿��� ���� ����
        spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        //player_controller ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        //target = FindObjectOfType<Player_controller>().transform;           //���� �����ϴ� ��� ������Ʈ���� �˻��Ͽ� ������ Ÿ�԰� ��ġ�� ������Ʈ�� �������� �ű⶧���� ������ �����ų ��� ���α׷��� �ɰ��ϰ� ������ �� �ֽ��ϴ�.
        //FindObjectsOfType �޼���� ������ Ÿ���� ������Ʈ�� �������̰� �� ������Ʈ���� ������ �� ����Ѵ�.
    }

    // Update is called once per frame
    void Update()
    {
        //time_after_spawn ����
        time_after_spawn += Time.deltaTime;

        //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if(time_after_spawn>spawn_rate)
        {
            //������ �ð��� ����
            time_after_spawn = 0;

            //bullet_prefad�� ��������
            //transform.position ��ġ�� transform.rotation ȸ������ ����
            GameObject bullet
                = Instantiate(bullet_prefab);
            //������ bullet���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ�� 
            bullet.transform.position = transform.position;
            bullet.transform.LookAt(transform.position + transform.forward);

            //������ ���� ������ spawn_rate_min, spawn_rate_max ���̿��� ���� ����
            spawn_rate = Random.Range(spawn_rate_min, spawn_rate_max);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Vector3 END = transform.position + transform.forward * 3f;
        Gizmos.DrawLine(transform.position, END);
    }
}
