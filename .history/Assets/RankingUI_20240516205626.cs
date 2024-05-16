using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class RankingUI : MonoBehaviour
{
    public RankingManager rankingManager;
    public GameObject rankingEntryPrefab;
    public RectTransform rankingContainer;

    void Start()
    {
        DisplayRanking();
    }

    public void DisplayRanking()
    {
        foreach (Transform child in rankingContainer)
        {
            Destroy(child.gameObject);
        }

        List<RankingEntry> rankingEntries = rankingManager.GetRankingEntries();
        foreach (RankingEntry entry in rankingEntries)
        {
            GameObject entryObject = Instantiate(rankingEntryPrefab, rankingContainer);
            entryObject.transform.Find("Name").GetComponent<TextMeshProUGUI>().text = entry.name;
            entryObject.transform.Find("Score").GetComponent<TextMeshProUGUI>().text = entry.score.ToString();
            entryObject.transform.Find("Date").GetComponent<TextMeshProUGUI>().text = entry.date.ToString("yyyy/MM/dd HH:mm");
        }
    }
}
