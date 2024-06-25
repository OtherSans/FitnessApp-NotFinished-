using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrainingButtonsController : MonoBehaviour
{
    [SerializeField] private List<Sprite> levelSprites = new List<Sprite>() { };
    [SerializeField] private GameObject overviewMenu;
    [SerializeField] private Button overviewBtn;
    [SerializeField] private GameObject historyMenu;
    [SerializeField] private Button historyBtn;

    private Button selectedButton;
    void Start()
    {
        SetOverviewButton();
    }
    public void TrainingInfoSelectButtons()
    {
        if (selectedButton == overviewBtn)
        {
            SetHistoryButton();
        }
        else if(selectedButton == historyBtn)
        {
            SetOverviewButton();
        }
    }
    private void SetActiveButton(Button button)
    {
        button.GetComponent<Image>().sprite = levelSprites[1];
        button.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;
    }
    private void SetNonActiveButton(Button button)
    {
        button.GetComponent<Image>().sprite = levelSprites[0];
        button.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
    }
    private void SetHistoryButton()
    {
        SetActiveButton(historyBtn);
        SetNonActiveButton(overviewBtn);

        selectedButton = historyBtn;

        historyMenu.SetActive(true);
        overviewMenu.SetActive(false);

        historyBtn.interactable = false;
        overviewBtn.interactable = true;
    }
    private void SetOverviewButton()
    {
        SetActiveButton(overviewBtn);
        SetNonActiveButton(historyBtn);

        selectedButton = overviewBtn;

        historyMenu.SetActive(false);
        overviewMenu.SetActive(true);

        historyBtn.interactable = true;
        overviewBtn.interactable = false;
    }
}
