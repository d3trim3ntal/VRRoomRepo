using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class TVCaptions : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public TextMeshProUGUI subtitleText;
    public List<Subtitle> subtitles;
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.prepareCompleted += PrepareCompleted;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentIndex < subtitles.Count && videoPlayer.time >= subtitles[currentIndex].startTime)
        {
            subtitleText.text = subtitles[currentIndex].text;
            currentIndex++;
        }
    }

    void PrepareCompleted(VideoPlayer vp)
    {
        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(VideoPlayer vp)
    {
        subtitleText.text = "";
        currentIndex = 0;
    }
    [System.Serializable]
    public class Subtitle
    {
        public double startTime;
        public string text;
    }
}
