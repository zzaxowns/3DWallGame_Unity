using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpPower;
    private AudioSource audio;
    public AudioClip jumpSound;

    // 처음 한번만 실행 되는 함수
    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.jumpSound;
        this.audio.loop = false;
    }

    // 매 frame마다 실행 되는 함수
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            this.audio.Play(); // 또는 this.audio.PlayOneShot(this.jumpSound);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("Main"); // 맨 처음 모습으로 돌아옴

    }
}
