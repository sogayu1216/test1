using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    // ClearUIのGameObject型変数
    public GameObject clearUi;

    // Start is called before the first frame update
    void Start()
    {
        // ゲームを再生するとClearUIを非表示にする
        clearUi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // スコアが5点以上になると
        if (Score.score >= 5)
        {
            // ClearUIを表示する
            clearUi.SetActive(true);
        }
    }
    public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Score.score = 0;
    }
}
