using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;



public class QuizUI : MonoBehaviour
{
    [SerializeField] private QuizManager quizManager;
    [SerializeField]  private Text questionText;
    [SerializeField]  private Image questionImage;
    [SerializeField]  private UnityEngine.Video.VideoPlayer questionVideo;
    [SerializeField]  private AudioSource questionAudio;
    [SerializeField] private List<Button> options;
    [SerializeField] private Color correctCol, wrongCol, normalCol;

    private Question question;
    private bool answered;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SetQuestion(Question question)
    {
        this.question = question;

        switch(question.questionType)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
