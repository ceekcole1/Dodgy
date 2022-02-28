using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    // �̵� �ӷ�
    public float speed = 3f;

    // �� �ڽ��� ���� ����
    public GameObject my;

    private void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã��
        // playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()

       {
        // ������� �������� �Է°��� �����ؼ� ����
        float xInput = Input.GetAxis("Horizontal");

        float zInput = Input.GetAxis("Vertical");

        float xspeed = xInput * speed;
        float zspeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xspeed, 0, zspeed);

        playerRigidbody.velocity = newVelocity;


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
        public void Die() 
        {
            my.SetActive(false);

        // ���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        GameManager gameManager =
            FindObjectOfType<GameManager>();

        gameManager.EndGame();

          
        }


    


}
