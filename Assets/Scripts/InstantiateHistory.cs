using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InstantiateHistory : MonoBehaviour
{
    [SerializeField] private GameObject historyPrefab;
    [SerializeField] private Transform historyPosition;

    public List<GameObject> histories = new List<GameObject>();

    [SerializeField] private TextMeshProUGUI hoursText;
    [SerializeField] private TextMeshProUGUI minText;
    [SerializeField] private TextMeshProUGUI emotionText;
    [SerializeField] private TextMeshProUGUI trainingText;
    private void Start()
    {
    }
    public void InstantiatePrefab()
    {
        var history = Instantiate(historyPrefab, historyPosition);
        histories.Add(history);
    }
}
