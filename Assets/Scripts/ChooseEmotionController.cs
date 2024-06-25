using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseEmotionController : MonoBehaviour
{
    [SerializeField] private List<Sprite> levelSprites = new List<Sprite>() { };

    [HideInInspector] public Button emotionsButton;
    public void EmotionsSelectedButton(Button button)
    {
        if (emotionsButton == button)
        {
            button.GetComponent<Image>().sprite = button.GetComponent<ChooseEmotionController>().levelSprites[0];

            emotionsButton = null;
        }
        else
        {
            if (emotionsButton != null)
            {

                emotionsButton.GetComponent<Image>().sprite = emotionsButton.GetComponent<ChooseEmotionController>().levelSprites[0];
            }

            button.GetComponent<Image>().sprite = button.GetComponent<ChooseEmotionController>().levelSprites[1];
            emotionsButton = button;
        }
    }
}
