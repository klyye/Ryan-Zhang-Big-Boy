using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ClickerBuyer : MonoBehaviour
{
    [SerializeField] private Clicker clicker;
    [SerializeField] private float spawnRadius;
    private TMP_Text childText;

    // Start is called before the first frame update
    private void Start()
    {
        childText = GetComponentInChildren<TMP_Text>();
        childText.text = $"Buy {clicker.name} (${clicker.price})";
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void BuyClicker()
    {
        if (GameManager.bigness >= clicker.price)
        {
            Instantiate(clicker, spawnRadius * Random.insideUnitCircle, Quaternion.identity);
            GameManager.bigness -= clicker.price;
        }
    }
}