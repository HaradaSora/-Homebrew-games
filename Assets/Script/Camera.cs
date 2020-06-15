using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    [SerializeField] Transform Player;
    [SerializeField] float RotateSpeed;

    float yaw, pitch;

    private void Start()
    {
        RotateSpeed = 1;
    }

    void Update()
    {

        //プライヤー位置を追従する
        transform.position = new Vector3(Player.position.x + 1 , transform.position.y  , Player.position.z - 2 );

        yaw += Input.GetAxis("Mouse X") * RotateSpeed; //横回転入力
        pitch -= Input.GetAxis("Mouse Y") * RotateSpeed; //縦回転入力

        pitch = Mathf.Clamp(pitch, -80, 60); //縦回転角度制限する

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f); //回転の実行
    }
}
