using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class RankingUI : MonoBehaviour
{
    public RankingManager rankingManager;
    public GameObject rankingEntryPrefab;
    public RectTransform rankingContainer;
    public int maxEntriesToShow = 10;  // 表示する最大エントリー数を指定

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
        int entriesToShow = Mathf.Min(rankingEntries.Count, maxEntriesToShow);

        for (int i = 0; i < maxEntriesToShow; i++)
        {
            GameObject entryObject = Instantiate(rankingEntryPrefab, rankingContainer);
            if (i < entriesToShow)
            {
                RankingEntry entry = rankingEntries[i];
                entryObject.transform.Find("Name").GetComponent<TextMeshProUGUI>().text = entry.name;
                entryObject.transform.Find("Score").GetComponent<TextMeshProUGUI>().text = entry.score.ToString();
                entryObject.transform.Find("Date").GetComponent<TextMeshProUGUI>().text = entry.date.ToString("yyyy/MM/dd HH:mm");
            }
            else
            {
                entryObject.transform.Find("Name").GetComponent<TextMeshProUGUI>().text = "";
                entryObject.transform.Find("Score").GetComponent<TextMeshProUGUI>().text = "";
                entryObject.transform.Find("Date").GetComponent<TextMeshProUGUI>().text = "";
            }
        }
    }
}
