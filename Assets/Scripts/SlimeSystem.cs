using UnityEngine;

namespace KID
{
    /// <summary>
    /// 史萊姆物件系統：碰撞處理
    /// </summary>
    public class SlimeSystem : MonoBehaviour
    {
        [Header("史萊姆編號"), Range(0, 7)]
        public int index;

        private void Awake()
        {
            Vector2 a = new Vector2(1, 1);
            Vector2 b = new Vector2(100, 100);
            print(Vector2.Lerp(a, b, 0.5f));

        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (index == 7) return;
            print($"<color=#f69>碰到的物件 {collision.gameObject.name}</color>");

            // 如果 碰到物件的名稱 與 這個物件的名稱 相同
            // 就 合成 (刪除、爆炸特效、升級後的史萊姆)
            // 等於 ==
            // gameObject 此物件
            if (collision.gameObject.name == gameObject.name)
            {
                print($"<color=#69f>要生出的史萊姆編號{index + 1}</color>");
                Vector2 pointA = transform.position;
                Vector2 pointB = collision.transform.position;
                Vector2 result = Vector2.Lerp(pointA, pointB, 0.5f);
                MergeSystem.instance.Merge(index + 1, result);
                // 刪除物件(要刪除的物件)
                Destroy(gameObject);
            }
           
        }
    }
}
