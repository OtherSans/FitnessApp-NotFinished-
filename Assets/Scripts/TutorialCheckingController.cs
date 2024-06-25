using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCheckingController : MonoBehaviour
{
    public void CheckTutorial()
    {
        PlayerPrefs.SetInt("firstEntry", 1);
    }
}
