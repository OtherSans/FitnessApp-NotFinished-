using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private List<Sprite> levelSprites = new List<Sprite>() { };
    private Button selectedButton;
    [HideInInspector] public Button goalButton;
    [HideInInspector] public bool goalSelected;
    public void LevelSelectedButton(Button button)
    {
        if (selectedButton == button)
        {

            button.GetComponent<Image>().sprite = levelSprites[0];
            button.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;

            selectedButton = null;
        }
        else
        {
            if (selectedButton != null)
            {

                selectedButton.GetComponent<Image>().sprite = levelSprites[0];
                selectedButton.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
            }

            button.GetComponent<Image>().sprite = levelSprites[1];
            button.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;
            selectedButton = button;
        }
    }
    public void GoalSelectedButton(Button button)
    {
        if (goalButton == button)
        {

            button.GetComponent<Image>().sprite = levelSprites[0];

            goalButton = null;
        }
        else
        {
            if (goalButton != null)
            {

                goalButton.GetComponent<Image>().sprite = levelSprites[0];
            }

            button.GetComponent<Image>().sprite = levelSprites[1];
            goalButton = button;
        }
    }
}
