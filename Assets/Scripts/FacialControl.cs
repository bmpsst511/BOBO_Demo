using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacialControl : MonoBehaviour
{
    public GameObject still, happy, sad, disgust;
    public bool _stillState, _happyState, _sadState, _disgustState;
    public Animator Tail_Animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_stillState){
            still.SetActive(true);
            happy.SetActive(false);
            sad.SetActive(false);
            disgust.SetActive(false);
            Tail_Animator.SetBool("happy", false);
            Tail_Animator.SetBool("disgust", false);
        }
        else if(_happyState){
            still.SetActive(false);
            happy.SetActive(true);
            sad.SetActive(false);
            disgust.SetActive(false);
            Tail_Animator.SetBool("happy", true);
            Tail_Animator.SetBool("disgust", false);
        }
        else if(_sadState){
            still.SetActive(false);
            happy.SetActive(false);
            sad.SetActive(true);
            disgust.SetActive(false);
        }
        else if(_disgustState){
            still.SetActive(false);
            happy.SetActive(false);
            sad.SetActive(false);
            disgust.SetActive(true);
            Tail_Animator.SetBool("happy", false);
            Tail_Animator.SetBool("disgust", true);
        }
    }
}
