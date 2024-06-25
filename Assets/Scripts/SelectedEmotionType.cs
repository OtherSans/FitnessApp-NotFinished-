using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedEmotionType : MonoBehaviour
{
    [SerializeField] private ChooseEmotionController[] emotionType = new ChooseEmotionController[] { };

    [HideInInspector] public Button selectedEmotion;
    public void SelectedEmotionButton()
    {
        foreach (var btn in emotionType)
        {
            selectedEmotion = btn.emotionsButton;
            Debug.Log(selectedEmotion);
        }
        
    }
}
