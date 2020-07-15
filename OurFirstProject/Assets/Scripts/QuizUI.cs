using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class QuizUI : MonoBehaviour
{

    [SerializeField]  private Text questionText;
    [SerializeField]  private Image questionImage;
    [SerializeField]  private UnityEngine.Video.VideoPlayer questionVideo;
    [SerializeField]  private AudioSource questionAudio;
    [SerializeField] private List<Button> options;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
