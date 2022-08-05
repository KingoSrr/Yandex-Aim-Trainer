using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    //��������� ������������
    [SerializeField]float speed = 6f;
    float jumpSpeed = 8f;
    float gravity = 20f;
    //��������� ��������
    float sensetivity = 4f;
    float rotationX = 0f;
    float rotationY = 0f;

    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;
    Camera playerCamera;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerCamera = transform.Find("PlayerCamera").GetComponent<Camera>();
    }
    void FixedUpdate()
    {
        Move();
        Squat();
        Rotation();
    }
    void Move()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));//���������� ������������
            moveDirection = transform.TransformDirection(moveDirection);//������� � ������� ����������
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;//������
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;//�������
        controller.Move(moveDirection * Time.deltaTime);//������������ � �����������
    }
    void Squat()//� �������
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            controller.height = 1f;
            transform.localScale = new Vector3(transform.localScale.x, 0.5f, transform.localScale.z);
        }
        else
        {
            controller.height = 2f;
            transform.localScale = new Vector3(transform.localScale.x, 1f, transform.localScale.z);
        }
    }
    void Rotation()
    {
        //������������ ����
        float mouseX = Input.GetAxis("Mouse X") * sensetivity;
        float mouseY = -Input.GetAxis("Mouse Y") * sensetivity;


        rotationY += mouseY;
        rotationY = Mathf.Clamp(rotationY, -90f, 90f);//����������� �������� �� ���������
        rotationX += mouseX;

        playerCamera.transform.localRotation = Quaternion.Euler(rotationY, 0f, 0f);//������� �� ���������
        transform.localRotation = Quaternion.Euler(0f, rotationX, 0f);//������� �� �����������

    }
}