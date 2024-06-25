using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;
[CreateAssetMenu(fileName = "TrainingPlayerData", menuName = "Training Player Data", order = 52)]
public class TrainingPlayerData : ScriptableObject
{
    public string trainingType;
    public string condition;
    public string hours;
    public string minutes;
}
