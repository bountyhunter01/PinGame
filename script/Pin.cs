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
        //Debug.Log("delta time: " + Time.deltaTime);�α�Ȯ�ι��
        if (isPinned == false&& isLaunched == true)
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        isPinned = true;
        if (other.gameObject.tag == "Target")//Ÿ�ϰ� �������
        {
            //GameObject childObject = transform.Find("Square").gameObject;//���1
            GameObject childObject = transform.GetChild(0).gameObject;//���2
            SpriteRenderer childSprite = childObject.GetComponent<SpriteRenderer>();
            childSprite.enabled = true;//üũ�ڽ��� üũ���ִ� ����

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
