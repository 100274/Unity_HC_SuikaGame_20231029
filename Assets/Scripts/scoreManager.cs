using TMPro;
using UnityEngine;

namespace choco

{
    public class scoreManager : MonoBehaviour
    {
        [Header("����")]
        public TextMeshProUGUI textscore;
        [Header("�Ҧ��v�ܩi������")]
        public int[] slimeScpres = { 10, 20, 30, 40, 50, 60, 70, 80 };
        private int totalScore;
    }
}
