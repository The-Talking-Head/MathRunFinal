using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos=65;

    public bool creatingSec = false;
    public int secNum;


    // Update is called once per frame
    void Update()
    {
        if(creatingSec==false)
        {
            creatingSec = true;
            StartCoroutine(GenerateSection());

        }

    }
    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3); //generates numbers 0 to 3
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 65;
        yield return new WaitForSeconds(2);
        creatingSec = false;
    }
}
