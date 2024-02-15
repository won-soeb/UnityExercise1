using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleToneTest : MonoBehaviour
{
    private void Start()
    {
        SingleToneMain.Instance.Access();
        //싱글톤 클래스에 접근하는 법
    }
}
