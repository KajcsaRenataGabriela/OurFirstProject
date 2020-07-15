using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizManager : MonoBehaviour
{
    [SerializeField]
    private List<Questions> questions;

    private Questions selectQuestion;
    // Start is called before the first frame update
    void Start()
    {
        SelectQuestion();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SelectQuestion()
    {
        int val;//= Random.Range(0, questions.Count);
      //  selectedQuestion = questions[val];
    }

    void Answer()
    {

    }
}

[System.Serializable]

public class Questions
{
    public string questionInfo;
    public QuestionType questionType;
    public Sprite questionImg;
    public AudioClip questionClip;
    public UnityEngine.Video.VideoClip questionVideo;
    public List<string> options;
    public string correctAns;

}

[System.Serializable]

public enum QuestionType
{
    TEXT,
    IMAGE,
    VIDEO,
    AUDIO
}