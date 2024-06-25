using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalPhoto : MonoBehaviour
{
    [HideInInspector]public Sprite sprite;
    public void SetImage()
    {
        gameObject.GetComponent<Image>().sprite = sprite;
        gameObject.GetComponent<Image>().SetNativeSize();
    }
}
