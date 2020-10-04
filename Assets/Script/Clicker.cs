using UnityEngine;

public class Clicker : MonoBehaviour
{
    public int price;
    public float period;
    public int clicks;
    [SerializeField] private Vector3 throbScale;
    [SerializeField] private NumberFX numFX;
    private bool growing;
    private Vector3 origScale;
    private float timeUntilClick;

    // Start is called before the first frame update
    private void Start()
    {
        timeUntilClick = period;
        origScale = transform.localScale;
        growing = true;
    }

    // Update is called once per frame
    private void Update()
    {
        timeUntilClick -= Time.deltaTime;
        if (growing)
            transform.localScale = Vector3.Lerp(throbScale, origScale, timeUntilClick / period);
        else
            transform.localScale = Vector3.Lerp(origScale, throbScale, timeUntilClick / period);

        if (timeUntilClick <= 0)
        {
            timeUntilClick = period;
            growing = !growing;

            var num = Instantiate(numFX, GameManager.overlay.transform);
            num.transform.position = GameManager.cam.WorldToScreenPoint(transform.position);
            num.setNumber(clicks);
            GameManager.bigness += clicks;
        }
    }
}