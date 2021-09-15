using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreController : MonoBehaviour
{
    [Header("UI")]
    public Text score;
    public Text highScore;

    [Header("Instruction")]
    public Text instruction;

    [Header("Score")]
    public ScoreController scoreController;

    private void Update()
    {
        score.text = scoreController.GetCurrentScore().ToString();
        highScore.text = ScoreData.highScore.ToString();
        Instruction();
    }

    void Instruction() 
    {
        instruction.CrossFadeAlpha(0f, 1, false);
        if (instruction.color.a == 0f)
        {
            instruction.gameObject.SetActive(false);
        }
    }
}
