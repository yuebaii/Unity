using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected float jump_speed = 12f;
    public bool is_landing = false;  //着陆标记
    // Start is called before the first frame update
    void Start()
    {
        this.is_landing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.is_landing)
        {
            if (Input.GetMouseButtonDown(0))  //点击鼠标左键触发
            {
                this.is_landing = false;  //将着陆标记设置为false（未着陆 = 在空中）
                this.GetComponent<Rigidbody>().velocity = Vector3.up * this.jump_speed;  //设定向上速度
               // Debug.Break();

            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            this.is_landing = true;  //将着陆标记设置为true（着陆 = 在地面上）
        }
    }
}
