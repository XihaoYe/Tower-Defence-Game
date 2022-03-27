using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {
        bgm = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void audio()
    {
        bgm.loop = true;
        bgm.Play();
    }
}
