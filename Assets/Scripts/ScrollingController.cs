using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ScrollingController : MonoBehaviour
{
    private TextMeshProUGUI textMeshProUGUI;
    [SerializeField] private float pickedFontSize;
    [SerializeField] private float startFontSize;
    [HideInInspector] public GameObject chosenGameObj;
    public ScrollRect scrollRect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<TextMeshProUGUI>().fontSize = pickedFontSize;
        chosenGameObj = collision.gameObject;
        Debug.Log(chosenGameObj.GetComponent<TextMeshProUGUI>().text);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<TextMeshProUGUI>().fontSize = startFontSize;
    }
}
