using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleToneMain : MonoBehaviour
{
    //싱글톤 선언방식
    public static readonly SingleToneMain Instance = new SingleToneMain();
    private SingleToneMain()
    {
        //생성자를 private으로 선언한다.
    }
    public void Access()
    {
        Debug.Log("싱글톤 메소드 호출");
    }
}
