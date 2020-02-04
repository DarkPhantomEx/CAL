using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimateStoneCAL : MonoBehaviour
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

        if ((idle.count) >= 50)
        {
            Debug.Log("SHIMMY TIME!");
            anim.SetBool("Shimmy", true);
        }
        else
            anim.SetBool("Shimmy", false);


        if ((idle.count) >= 1000)
        {
            StartCoroutine(Finale1());

        }

    }

    IEnumerator Finale1()
    {
        anim.Play("StoneCalFinal");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
