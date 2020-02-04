using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AnimateForge : MonoBehaviour
{
    public Animator anim;
    public GameObject SM;
    public IdleCounter1 idle;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        idle = SM.GetComponent<IdleCounter1>();
    }

    // Update is called once per frame
    void Update()
    {

        if ((idle.count) >= 50)
        {
            Debug.Log("HAMMER TIME!");
            anim.SetBool("HammerTime", true);
        }
        else
            anim.SetBool("HammerTime", false);


        if ((idle.count) >= 1000)
        {
            StartCoroutine(Finale2());

        }

    }

    IEnumerator Finale2()
    {
        anim.Play("ForgeFinal");
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(2);
    }
}
