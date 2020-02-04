using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AddtoCounter : MonoBehaviour
{
    static public float toAdd;
    ///public float count;
    //public GameObject G;
    public IdleCounter idle;
    
    // Start is called before the first frame update
    void Start()
    {
        
        idle = GetComponent<IdleCounter>();
        toAdd = 0.0f;
        InvokeRepeating("addPoints", 0.0f, 1.0f);
    }

    void addPoints()
    {
        
        idle.count += toAdd;
        //idle.CountDisplay.text = idle.count.ToString();
        //Debug.Log("Add points + " + idle.count);
    }

    public void gimmeMoney(float cost)
    {
        idle.count -= cost;
        switch(cost)
        {
            case 25: idle.Adder.interactable = false; break;
            case 65: idle.Ability.interactable = false; break;
            case 120: idle.Adder1.interactable = false; break;
            case 220: idle.Ability1.interactable = false; break;
        }
    }

    public void addToAdder(float a)
    {
        toAdd += a;
        Debug.Log("toAdd + " + toAdd);
    }

    public void strengthenAbility(float b)
    {
        Debug.Log("Added ability " + b);
        idle.ability += b;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
