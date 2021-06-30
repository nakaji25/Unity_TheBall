using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelectManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //ステージ選択ボタンを押した
    public void PushStageSelectButton(int stageNo)
    {
        //ゲームシーンへ
        SceneManager.LoadScene("PuzzleScene" + stageNo);
    }
}
