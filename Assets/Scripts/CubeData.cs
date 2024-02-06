using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeData : MonoBehaviour
{
    CubeController cubeController;
    [SerializeField] private Text countText;
    private void Start()
    {
        cubeController = FindAnyObjectByType<CubeController>();
        countText.text = cubeController.UpdaterCountData().ToString();
    }
}