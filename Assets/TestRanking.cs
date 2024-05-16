using UnityEngine;

public class TestRanking : MonoBehaviour
{
    public RankingManager rankingManager;
    public RankingUI rankingUI;

    void Start()
    {
        // サンプルデータを追加
        rankingManager.AddRankingEntry("Player1", 100);
        rankingManager.AddRankingEntry("Player2", 200);
        rankingManager.AddRankingEntry("Player3", 150);

        // UIを更新して表示
        rankingUI.DisplayRanking();
    }
}
