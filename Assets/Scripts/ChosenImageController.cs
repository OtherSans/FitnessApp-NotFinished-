using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ChosenImageController : MonoBehaviour
{
    private List<int> indexes = new List<int> {0, 1, 2 };
    public int chosenIndex;
    [SerializeField] private List<GameObject> photos;

    public void SetImageIndex(int imageIndex)
    {
        chosenIndex = imageIndex;
        foreach (var index in indexes)
        {
            if (index == chosenIndex)
            {
                photos[index].gameObject.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
            }
            else if(index != chosenIndex)
            {
                photos[index].gameObject.transform.localScale = Vector3.one;
            }
        }
        
    }
}
