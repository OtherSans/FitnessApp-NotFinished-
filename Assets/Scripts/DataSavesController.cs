using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataSavesController : MonoBehaviour
{
    [SerializeField] private GameObject onboard;
    [SerializeField] private GameObject info;

    [Header("PersonalInfo")]
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private TextMeshProUGUI nickName;
    [SerializeField] private ScrollingController chosenWeight;
    [SerializeField] private TextMeshProUGUI chosenWeightText;
    [SerializeField] private ScrollingController chosenHeight;
    [SerializeField] private TextMeshProUGUI chosenHeightText;

    [Header("Goals")]
    [SerializeField] private TMP_InputField goalInputField;
    [SerializeField] private ButtonController chosenGoal;
    [SerializeField] private List<GameObject> allGoals;

    [SerializeField] private GameObject goal;
    [SerializeField] private Transform transformGoal;

    [Header("Photos")]
    [SerializeField] private List<Sprite> goalImages;
    [SerializeField] private ChosenImageController chosenImageIndex;

    [Header("TrainingInfo")]

    [SerializeField] private SelectedTrainingType trainingType;
    [SerializeField] private TextMeshProUGUI trainingTypeTextField;
    [SerializeField] private SelectedEmotionType emotionType;
    [SerializeField] private TextMeshProUGUI emotionTypeTextField;
    [SerializeField] private ScrollingController chosenHour;
    [SerializeField] private TextMeshProUGUI hourTimeText;
    [SerializeField] private ScrollingController chosenMin;
    [SerializeField] private TextMeshProUGUI minTimeText;

    [SerializeField] private List<TrainingPlayerData> allHistory;
    [SerializeField] private GameObject training;
    [SerializeField] private Transform transformTraining;
    private MainMenuGoalData mainGoal;

    private void Start()
    {
        if (PlayerPrefs.HasKey("firstEntry") == false)
        {
            onboard.SetActive(true);
            info.SetActive(false);
        }

        else if (PlayerPrefs.HasKey("firstEntry") == true)
        {
            onboard.SetActive(false);
            info.SetActive(true);
        }
        mainGoal = FindObjectOfType<MainMenuGoalData>(true);
    }
    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
    public void SavePersonalInfo()
    {
        PlayerPrefs.SetString("Name", nameInputField.text);
        nickName.text = "Hi, " + PlayerPrefs.GetString("Name") + "!";
    }
    public void SaveWeight()
    {
        PlayerPrefs.SetString("Weight", chosenWeight.chosenGameObj.GetComponent<TextMeshProUGUI>().text);
        chosenWeightText.text = PlayerPrefs.GetString("Weight");
    }
    public void SaveHeight()
    {
        PlayerPrefs.SetString("Height", chosenHeight.chosenGameObj.GetComponent<TextMeshProUGUI>().text);
        chosenHeightText.text = PlayerPrefs.GetString("Height");
    }
    public void SaveGoals()
    {
        var goalData = ScriptableObject.CreateInstance<GoalPlayerData>();

        //goalType
        var obj = Instantiate(goal, transformGoal);
        allGoals.Add(obj);
        obj.GetComponentInChildren<NewPlayerData>().goalPlayerData = goalData;

        goalData.goalType = chosenGoal.goalButton.GetComponentInChildren<TextMeshProUGUI>().text;


        //goalCover
        PlayerPrefs.SetInt("Photo", chosenImageIndex.chosenIndex);

        goalData.image = goalImages[PlayerPrefs.GetInt("Photo")];

        obj.GetComponentInChildren<NewPlayerData>().trainingHistoryData = goalData.historyTraining;

        obj.GetComponentInChildren<NewPlayerData>().SetGoalData();
        obj.GetComponentInChildren<NewPlayerData>().ChooseGoalToMenu();
    }
    public void SaveTrainingInfo()
    {
        var trainingData = ScriptableObject.CreateInstance<TrainingPlayerData>();

        var obj = Instantiate(training, transformTraining);
        allHistory.Add(obj.GetComponent<GoalTrainingData>().trainingPlayerData);

        obj.GetComponentInChildren<GoalTrainingData>().trainingPlayerData = trainingData;

        if (trainingType.selectedType != null)
        {
            trainingData.trainingType = trainingType.selectedType.GetComponentInChildren<TextMeshProUGUI>().name;
        }

        if (emotionType.selectedEmotion != null)
        {
            trainingData.condition = emotionType.selectedEmotion.name;
        }
        if (mainGoal.mainHistory != null)
        {
            mainGoal.mainHistory.Add(trainingData);

        }
        mainGoal.mainGoalData.historyTraining.Add(trainingData);

        Debug.Log(mainGoal.goal);
        mainGoal.goal.GetComponentInChildren<NewPlayerData>(true).goalPlayerData.historyTraining.Add(trainingData);

        trainingData.hours = chosenHour.chosenGameObj.GetComponent<TextMeshProUGUI>().text;
        trainingData.minutes = chosenMin.chosenGameObj.GetComponent<TextMeshProUGUI>().text;

        obj.GetComponentInChildren<GoalTrainingData>().SetTrainingData();

        mainGoal.goal.GetComponentInChildren<NewPlayerData>(true).trainingInfoObj.Add(obj);
    }
}
