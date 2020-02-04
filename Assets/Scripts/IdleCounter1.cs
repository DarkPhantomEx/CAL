using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdleCounter1 : MonoBehaviour
{
    public float count;
    public float ability;
    public Text CountDisplay;
    public Button Adder;
    public Button Ability;
    public Button Adder1;
    public Button Ability1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateCounter", 0.0f, 1.0f);
        count = 0;
        ability = 1;
        Adder.interactable = false;
        Ability.interactable = false;
        Adder1.interactable = false;
        Ability1.interactable = false;
    }

    void UpdateCounter()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        CountDisplay.text = count.ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count += ability;
        }
        Debug.Log("Count " + count);
        Debug.Log("CountString" + CountDisplay.text);

        if(count >=60)
        {
            Adder.interactable = true;
        }

        if(count >=100)
        {
            Ability.interactable = true;
        }

        if (count >= 380)
        {
            Adder1.interactable = true;
        }

        if (count >= 400)
        {
            Ability1.interactable = true;
        }
    }
}
