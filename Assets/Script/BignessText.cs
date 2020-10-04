using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class BignessText : MonoBehaviour
{
    private TMP_Text text;

    // Start is called before the first frame update
    private void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (GameManager.bigboy.isTooBig)
            text.SetText("Ryan is TOO BIG! OH NO!");
        else
            text.SetText("Ryan is " + GameManager.bigness + " big!");
    }
}