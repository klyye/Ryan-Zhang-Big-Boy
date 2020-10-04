using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Bigboy bigboy;
    public static Canvas overlay;
    public static Camera cam;

    public static int bigness
    {
        get => bigboy.bigness;
        set => bigboy.bigness = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        bigboy = FindObjectOfType<Bigboy>();
        cam = FindObjectOfType<Camera>();
        overlay = FindObjectOfType<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
