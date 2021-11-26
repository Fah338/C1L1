using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckOnCollision : MonoBehaviour
{
    public GameObject wreckedVersion;//

    // Update is called once per frame
    void OnCollisionEnter()
    {
        Destroy(gameObject);//odject ที่ทำงาน
        Instantiate(wreckedVersion,transform.position,transform.rotation);
    }//นำตัว2 มาแทนตัวเดิม
}
