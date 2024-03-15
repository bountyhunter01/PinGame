using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp : MonoBehaviour
{
    public int difficulty = 1; // 현재 난이도
    public int clearedLevels = 0; // 클리어한 레벨 수
    [SerializeField]
    private float timeSinceLastIncrease = 0; // 마지막 난이도 증가 이후 경과 시간

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 매 프레임마다 시간을 측정합니다.
        timeSinceLastIncrease += Time.deltaTime;

        // 예를 들어, 매 10초마다 난이도를 증가시킵니다.
        if (timeSinceLastIncrease >= 10)
        {
            // 난이도 증가 로직
            difficulty++;
            clearedLevels++;
            Debug.Log("난이도가 " + difficulty + "로 증가했습니다. 현재까지 클리어한 레벨 수: " + clearedLevels);

            // 시간 측정 리셋
            timeSinceLastIncrease = 0;
        }

        // 여기에 추가적인 게임 로직을 구현할 수 있습니다.
        // 예를 들어, 난이도에 따라 적의 속도를 증가시키는 등의 조치를 취할 수 있습니다.
    }
}
