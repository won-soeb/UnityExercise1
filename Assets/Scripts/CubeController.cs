using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{
    private int count=0;
    [SerializeField]private Button countBtn;
    [SerializeField]private Button nextBtn;
    [SerializeField]private Text countText;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        countBtn.onClick.AddListener(() => {
            ++count;
            countText.text = count.ToString();
        });
        nextBtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("NextScene");
        });
    }
    public int UpdaterCountData()
    {
        return count;
    }
}
