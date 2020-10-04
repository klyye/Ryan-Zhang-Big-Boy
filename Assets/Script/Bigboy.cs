using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Bigboy : MonoBehaviour
{
    public int bigness;

    public bool isTooBig => bigness > tooBigThreshold;

    [SerializeField]
    private float startingScale;
    [SerializeField]
    private float scaleFactor;

    [SerializeField] private int tooBigThreshold;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = startingScale * Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        var scale = scaleFactor * bigness + startingScale;
        transform.localScale = scale * Vector3.one;
    }
    
    void OnMouseDown()
    {
        bigness += 1;
    }
}
