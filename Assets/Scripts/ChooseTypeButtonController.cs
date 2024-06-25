using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseTypeButtonController : MonoBehaviour
{
    [SerializeField] private List<Sprite> levelSprites = new List<Sprite>() { };

    [HideInInspector] public Button selectButton;
    [HideInInspector] public bool trainingSelected;

    public void TrainingSelectedButton(Button button)
    {
        if (selectButton == button)
        {

            button.GetComponent<Image>().sprite = button.GetComponent<ChooseTypeButtonController>().levelSprites[0];
            button.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
            selectButton = null;
        }
        else
        {
            if (selectButton != null)
            {
                selectButton.GetComponent<Image>().sprite = selectButton.GetComponent<ChooseTypeButtonController>().levelSprites[0];
                selectButton.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
            }
            button.GetComponent<Image>().sprite = button.GetComponent<ChooseTypeButtonController>().levelSprites[1];
            button.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;
            
            selectButton = button;
        }
    }
    
}
