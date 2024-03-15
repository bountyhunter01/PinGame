using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10f;
    private bool isPinned = false;
    private bool isLaunched = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.Log("delta time: " + Time.deltaTime);로그확인방법
        if (isPinned == false&& isLaunched == true)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        isPinned = true;
        if (other.gameObject.tag == "Target")//타켓과 닿았을때
        {
            //GameObject childObject = transform.Find("Square").gameObject;//방법1
            GameObject childObject = transform.GetChild(0).gameObject;//방법2
            SpriteRenderer childSprite = childObject.GetComponent<SpriteRenderer>();
            childSprite.enabled = true;//체크박스를 체크해주는 역할

            transform.SetParent(other.gameObject.transform);

            GameManager.instance.DecreaseGoal();
        }else if (other.gameObject.tag == "Pin")
        {
            GameManager.instance.SetGameOver(false);
            
        }
    }
    public void Launch()
    {
        isLaunched = true;
    }
}
