using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(this.gameObject);  //删除游戏对象
    }
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(-10.0f, 9.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
