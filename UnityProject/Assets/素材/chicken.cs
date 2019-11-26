using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicken : MonoBehaviour
{
    [Header("跳躍高度"), Range(50, 2000)]
    public int jump = 100;
    [Header("移動速度")]
    public int speed = 100;
    private void speak()
    {
        print("咕咕咕");

    }
    private void Start()
    {
        speak();
    }
    [Header("是否取得雞蛋")]
    public bool egg = true;
}
