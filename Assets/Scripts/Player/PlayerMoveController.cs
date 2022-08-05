using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    //��������� ������������
    [SerializeField] private float _speed = 12f;
    [SerializeField] private float _jumpSpeed = 8f;
    [SerializeField] private float _gravity = 20f;
    //��������� ��������
    [SerializeField] private float _sensetivity = 4f;
    [SerializeField] private float _rotationX = 0f;
    [SerializeField] private float _rotationY = 0f;

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
            moveDirection *= _speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = _jumpSpeed;//������
            }
        }
        moveDirection.y -= _gravity * Time.deltaTime;//�������
        controller.Move(moveDirection * Time.deltaTime);//������������ � �����������
    }
    void Squat()//� �������
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            _speed = 6f;
            controller.height = 1f;
            transform.localScale = new Vector3(transform.localScale.x, 0.5f, transform.localScale.z);
        }
        else
        {
            _speed = 12f;
            controller.height = 2f;
            transform.localScale = new Vector3(transform.localScale.x, 1f, transform.localScale.z);
        }
    }
    void Rotation()
    {
        //������������ ����
        float mouseX = Input.GetAxis("Mouse X") * _sensetivity;
        float mouseY = -Input.GetAxis("Mouse Y") * _sensetivity;


        _rotationY += mouseY;
        _rotationY = Mathf.Clamp(_rotationY, -90f, 90f);//����������� �������� �� ���������
        _rotationX += mouseX;

        playerCamera.transform.localRotation = Quaternion.Euler(_rotationY, 0f, 0f);//������� �� ���������
        transform.localRotation = Quaternion.Euler(0f, _rotationX, 0f);//������� �� �����������

    }
}