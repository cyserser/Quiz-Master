using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
   
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 10f;
    float timerValue;
    public bool isAnsweringQuestion = false;
    public bool loadNextQuestion = false;
    public float fillFraction;
    
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer(){
        
        timerValue = 0;
    }

    void UpdateTimer(){

        timerValue -= Time.deltaTime;

        if(isAnsweringQuestion){ // if true

            if(timerValue <= 0){
                
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
                
            } else {
                
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            
        } else {
            
            if(timerValue <= 0){

                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;

            } else {

                fillFraction = timerValue / timeToShowCorrectAnswer;
            }

        }
        Debug.Log(isAnsweringQuestion + " - " + timerValue + " - " + fillFraction);
    }
}
