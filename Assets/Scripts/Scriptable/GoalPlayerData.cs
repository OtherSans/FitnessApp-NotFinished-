using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "GoalPlayerData", menuName = "Goal Player Data", order = 51)]
public class GoalPlayerData : ScriptableObject
{
    public Sprite image;
    public string goalType;

    public List<TrainingPlayerData> historyTraining = new List<TrainingPlayerData>();
}
