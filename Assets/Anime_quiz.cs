using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class Anime_quiz : MonoBehaviour
{
    State State1;

    [SerializeField] Image MainImage;
    [SerializeField] Text textcomponent;
    [SerializeField] AudioSource CurrentAudio;
    [SerializeField] State starting;

    // Start is called before the first frame update
    void Start()
    {
        State1 = starting;
        textcomponent.text = State1.Getstorytext();
        CurrentAudio.PlayOneShot(State1.GetAudio());
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageStates();
        
        
    }

    private void ManageStates()
    {

        var nextQ = State1.GetStates();     
        
            // question 1  
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Debug.Log("Correct !!!");
                State1 = nextQ[0];
            CurrentAudio.Stop();
            textcomponent.text = State1.Getstorytext();
            CurrentAudio.PlayOneShot(State1.GetAudio());
        }
            else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha4))
            {
            CurrentAudio.Stop();
            State1 = nextQ[1];
                textcomponent.text = State1.Getstorytext();
            CurrentAudio.PlayOneShot(State1.GetAudio());

        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Debug.Log("Sorry :(");
            State1 = nextQ[0];
            CurrentAudio.Stop();
            textcomponent.text = State1.Getstorytext();
            CurrentAudio.PlayOneShot(State1.GetAudio());
        }


    }
    }

