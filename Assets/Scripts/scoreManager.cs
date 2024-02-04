using TMPro;
using UnityEngine;

namespace choco

{
    [DefaultExecutionOrder(0)]
    public class scoreManager : MonoBehaviour
    {
        [Header("����")]
        public TextMeshProUGUI textscore;
        [Header("�Ҧ��v�ܩi������")]
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
