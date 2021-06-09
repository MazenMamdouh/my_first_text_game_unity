using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="State")]
public class State : ScriptableObject
{
    [SerializeField] State[] nextState;
    [SerializeField]  AudioClip Audio;
    [TextArea(10,10)][SerializeField] string StoryBox;

    public string Getstorytext()
    {
        return StoryBox;
    }
     public State[] GetStates()
    {
        return nextState;
    }
    public AudioClip GetAudio()
    {
        return Audio;
    }
     
}
