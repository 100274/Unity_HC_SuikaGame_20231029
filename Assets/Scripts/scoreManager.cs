using TMPro;
using UnityEngine;

namespace choco

{
    [DefaultExecutionOrder(0)]
    public class scoreManager : MonoBehaviour
    {
        [Header("分數")]
        public TextMeshProUGUI textscore;
        [Header("所有史萊姆的分數")]
        public int[] slimeScores = { 10, 20, 30, 40, 50, 60, 70, 80 };
        private int totalScore;
        public static scoreManager instance;
        internal object play;

        private void Awake()
        {
            instance = this;
            
        }
        public void AddScore(int _index)
        {
            int score = slimeScores[_index];
            totalScore += score;
            textscore.text = totalScore.ToString();
        }
    }
}
