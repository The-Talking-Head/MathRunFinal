 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelStarter : MonoBehaviour
{
    public GameObject countdown3;
    public GameObject countdown2;
    public GameObject countdown1;
    public GameObject countdowngo;
    public GameObject fadein;
    public AudioSource readyFX;
    public AudioSource goFX;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.1f);
        countdown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        countdown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        countdown1.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1f);
        countdowngo.SetActive(true);
        goFX.Play();
        PlayerMove.canMove = true;

    }
}
