using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public int difficulty = 1; // ���� ���̵�
    public int clearedLevels = 0; // Ŭ������ ���� ��
    [SerializeField]
    private float timeSinceLastIncrease = 0; // ������ ���̵� ���� ���� ��� �ð�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �� �����Ӹ��� �ð��� �����մϴ�.
        timeSinceLastIncrease += Time.deltaTime;

        // ���� ���, �� 10�ʸ��� ���̵��� ������ŵ�ϴ�.
        if (timeSinceLastIncrease >= 10)
        {
            // ���̵� ���� ����
            difficulty++;
            clearedLevels++;
            Debug.Log("���̵��� " + difficulty + "�� �����߽��ϴ�. ������� Ŭ������ ���� ��: " + clearedLevels);

            // �ð� ���� ����
            timeSinceLastIncrease = 0;
        }

        // ���⿡ �߰����� ���� ������ ������ �� �ֽ��ϴ�.
        // ���� ���, ���̵��� ���� ���� �ӵ��� ������Ű�� ���� ��ġ�� ���� �� �ֽ��ϴ�.
    }
}
