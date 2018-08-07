using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour {

    // Use this for initialization
    void Start () {
    }

    private void OnGUI()
    {
        
    }

    // Update is called once per frame
    void Update () {
        transform.position = transform.position +31*transform.right*Time.deltaTime;
        // 鼠标左键按下

        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("鼠标左键按下");

            // 这里得到的  是 相对于摄像机的坐标  也就是屏幕坐标
            Debug.Log(Input.mousePosition.x + "  " + Input.mousePosition.y + "  " + Input.mousePosition.z);
            
            // 摄像机到屏幕上点的一条射线,  这里 使用的camera 需要设置 tag 为  MainCamera 不然会有空指针错误 
            Ray ray  = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit floorHit;
            //  Raycast(射线, 输出信息变量,射线最远距离,遮罩)  ,用来检测 射线是否与 地图物有碰撞
            if (Physics.Raycast(ray, out floorHit, 1000)){
                // floorHit.point // 获取碰撞点
                Debug.Log(" 点击坐标"+floorHit.point.z);
                // 获取碰撞物体
                Debug.Log("点击物体 "+floorHit.collider.gameObject);
                //
                Debug.Log("射线距离" +floorHit.distance);
            }


        }
        //if (Input.GetMouseButton(0)) {
        //    Debug.Log("鼠标左键在按下状态");

        //}
        //if (Input.GetMouseButtonUp(0)) {
        //    Debug.Log("鼠标左键抬起");
        //}
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");

    }
   
}
