using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class script : MonoBehaviour
{
    public string[] phrases;
    public int num;
    public bool mode;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        mode = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == true)
        {
            text.text = phrases[Random.Range(0, 9)];
            mode = false;
        }
    }

    public void ButtonPressed()
    {
        mode = true;
    }
}
