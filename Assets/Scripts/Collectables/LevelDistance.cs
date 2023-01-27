using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public int disRun;
    public bool addingDis = false;
    public float disDelay = 0.35f;


    void Update()
    {
        if (PlayerMove.canMove == true && addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
        else
        {
            addingDis = false;
        }
        
    }
    IEnumerator AddingDis()
    {
            disRun += 1;
            disDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + disRun;
            yield return new WaitForSeconds(disDelay);
            addingDis = false;
        
    }
}
