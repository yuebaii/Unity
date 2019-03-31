using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))  //点击鼠标右键后触发
        {
            Instantiate(this.ballPrefab);  //创建ballPrefab的实例
        }
    }
}
