using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    // �̵� �ӷ�
    public float speed = 8f;

    // �� �ڽ��� ���� ����
    public GameObject my;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
        {
        float xInput = Input.GetAxis("Horizontal");

        float zInput = Input.GetAxis("Vertical");
        }  

        void DirectInput()
       {
        if (Input.GetKey(KeyCode.UpArrow) == true)

        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
       }
        void Die() 
        {
            my.SetActive(false);
          
        }


    


}
