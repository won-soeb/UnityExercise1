using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneMain : MonoBehaviour
{
    [SerializeField] private Text textHp;
    [SerializeField] private Button btnLoadScene;
    [SerializeField] private GameObject heroPrefab;
    [SerializeField] private CubeData cubeData;
    void Start()
    {
        //버튼을 클릭하면 람다문이 호출됨 
        this.btnLoadScene.onClick.AddListener(() => {
            Debug.Log("NextScene으로 전환");
            SceneManager.LoadScene("NextScene");
        });

        this.CreateHero();
    }

    private void CreateHero()
    {
        GameObject cube = Instantiate(this.heroPrefab);
        Debug.LogFormat("heroGo: {0}", cube);
        CubeController cubeController = cube.GetComponent<CubeController>();

        cubeController.onHit = () => {

            Debug.Log("영웅이 피해를 받았습니다.");
            Debug.LogFormat("{0}/{1}", cubeController.Hp, cubeController.MaxHp);

            this.cubeData.UpdateHeroHpAndMaxHp(cubeController.Hp, cubeController.MaxHp);

            this.textHp.text = string.Format("{0}/{1}", cubeController.Hp, cubeController.MaxHp);
        };
    }
}