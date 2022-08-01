using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollController : MonoBehaviour
{
    // Start is called before the first frame update
    public float minTimer, maxTimer;    
    public bool isGreenLight = true;
    public Animator animator;
    public readonly string greenLightAnim = "GreenLight";

    void Start()
    {
        StartCoroutine(ChangeLightCoroutine());
    }

    IEnumerator ChangeLightCoroutine()
    {
        yield return new WaitForSeconds(Random.Range(minTimer,maxTimer));

        if (isGreenLight)
        {
            isGreenLight = false;
            animator.SetBool(greenLightAnim, false);
            print("Lampu merah gan");
        }
        else
        {
            isGreenLight = true;
            animator.SetBool(greenLightAnim, true);
            print("Lampu hijau gan");
        }

        StartCoroutine(ChangeLightCoroutine());
    }
}
