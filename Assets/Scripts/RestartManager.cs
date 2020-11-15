using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityChan;

public class RestartManager : MonoBehaviour
{
    private GameObject player;
    private GameObject text;
    private bool isGameOver = false;

    // コンストラクタ
    public RestartManager(GameObject player,GameObject text)
    {
        this.player = player;
        this.text = text;
    }

    public void PrintGameOver()
    {
        //ゲームオーバーを表示する
        text.GetComponent<Text>().text = "GameOver...\nClick to return to top.";
        text.SetActive(true);
 
        //ユニティちゃんを動けなくする
        player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        //アニメーションをオフにする
        player.GetComponent<Animator>().enabled = false;
 
        //ゲームオーバー
        isGameOver = true;
    }

    public void PrintGoal()
    {
        text.GetComponent<Text>().text = "Goal!\nClick to return to top.";
        text.SetActive(true);
 
        //ユニティちゃんを動けなくする
        player.GetComponent<UnityChanControlScriptWithRgidBody>().enabled = false;
        //アニメーションをオフにする
        player.GetComponent<Animator>().enabled = false;
        isGameOver = true;
    }

    public void Restart()
    {
        // トップに戻る
        SceneManager.LoadScene("TopMenu");
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
