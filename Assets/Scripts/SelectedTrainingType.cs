using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedTrainingType : MonoBehaviour
{
    private ChooseTypeButtonController[] buttonType = new ChooseTypeButtonController[] { };

    [HideInInspector] public Button selectedType;
    private void Start()
    {
        buttonType = FindObjectsOfType<ChooseTypeButtonController>();
    }
    public void SelectedTypeButton()
    {
        foreach(var btn in buttonType)
        {
            if(btn.selectButton != null)
            {
                selectedType = btn.selectButton;
            }
        }
    }
   
}
