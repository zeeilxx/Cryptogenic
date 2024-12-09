using UnityEngine;
using UnityEngine.SceneManagement;

public class BossRoomExit : MonoBehaviour
{
    private bool bossDefeated = false;

    public void SetBossDefeated()
    {
        bossDefeated = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && bossDefeated)
        {
            Debug.Log("Pindah ke scene berikutnya...");
            SceneManager.LoadScene(2); // Ganti dengan scene berikutnya
        }
    }
}
