using TMPro;
using UnityEngine;

namespace choco

{
    public class scoreManager : MonoBehaviour
    {
        [Header("分數")]
        public TextMeshProUGUI textscore;
        [Header("所有史萊姆的分數")]
        public int[] slimeScpres = { 10, 20, 30, 40, 50, 60, 70, 80 };
        private int totalScore;
    }
}
