using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class NumberFX : MonoBehaviour
{
    private TMP_Text tmpText;
    [SerializeField] private float duration;
    [SerializeField] private float speed;
    private float timeExisted;

    public void setNumber(int num)
    {
        if (!tmpText)
        {
            tmpText = GetComponent<TMP_Text>();
        }

        tmpText.text = $"+{num}";
    }

    // Start is called before the first frame update
    void Start()
    {
        tmpText = GetComponent<TMP_Text>();
        timeExisted = 0;
        Destroy(gameObject, duration);
    }

    // Update is called once per frame
    void Update()
    {
        timeExisted += Time.deltaTime;
        tmpText.alpha = Mathf.Lerp(1, 0, timeExisted / duration);
        tmpText.transform.Translate(speed * Time.deltaTime * Vector3.up);
    }
}