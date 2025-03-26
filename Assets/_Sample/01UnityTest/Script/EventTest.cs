using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventTest : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("1 Awake 실행");
    }


    
    private void Start()
    {
        Debug.Log("2 start 실행");

    }

    private void FixedUpdate() // 1초에 50프레임 고정
    {
        Debug.Log("3 fiexdupdate 실행");
    }
    /*
    4 update 
    5 lateupdate update 실행 끝난후에 바로따라서
    6-1 onenable 활성화될때 1회실행
    6-2 ondisable 비활성화될때 1회실행
    7 ondestroy 파괴할때 1회실행

    */

}
