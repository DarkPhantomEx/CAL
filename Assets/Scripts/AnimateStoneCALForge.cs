using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimateStoneCALForge : MonoBehaviour
{
    public Animator anim;
    public GameObject SM;
    public IdleCounter idle;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        idle = SM.GetComponent<IdleCounter>();
    }

    // Update is called once per frame
    void Update()
    {
          

        if ((idle.count) >= 1000)
        {
            StartCoroutine(Finale3());

        }

    }

    IEnumerator Finale3()
    {
        anim.Play("StoneCalFinal");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
}
