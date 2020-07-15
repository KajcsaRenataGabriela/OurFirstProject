﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class QuizManager : MonoBehaviour
{
    [SerializeField]
    private List<Question> questions;

    private Question selectedQuestion;
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
        int val= UnityEngine.Random.Range(0, questions.Count);
        selectedQuestion = questions[val];
    }

   public bool Answer(string answered)
    {
        bool correctAns = false;

        if(answered == selectedQuestion.correctAns)
        {
            //yes
            correctAns = true;
        }
        else
        {
            //No
        }

        Invoke("SelectQuestion", 0.4f);

        return correctAns;
    }
}

[System.Serializable]

public class Question
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