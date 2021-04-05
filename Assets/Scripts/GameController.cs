using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    [Header("Singleton")]
    private static GameController _instance;
    public static GameController Instance { get { return _instance; } }

    [Header("Components")]
    public List<Zone> zones = new List<Zone>();
    public List<Station> stations = new List<Station>();
    [SerializeField] FrogController frog;
    [SerializeField] public Animator fadeAnim;
    [SerializeField] Animator levelAnim;
    [SerializeField] Animator scoreAnim;
    [SerializeField] private TextMeshProUGUI level;
    [SerializeField] private TextMeshProUGUI frogsLeft;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI score2;
    [SerializeField] LevelTimer levelTimer;
    [SerializeField] LevelSetter levelSetter;
    [SerializeField] AudioSource aS;
    [SerializeField] AudioClip victorySFX;
    [SerializeField] AudioClip defeatSFX;




    [Header("Status")]
    public bool gameActive = false;
    private float points = 0;
    public int levelNumber = 1;
    public int livesTotal = 3;
    public int livesCurrent = 5;
    public int stationsClaimed = 0;
    [Range(7f, 250f)] [SerializeField] private float timerDuration = 110f;
    [Range(1f, 25f)] [SerializeField] private float timerPointMultiplier = 2f;
    [Range(1, 10)] [SerializeField] private int frogsRescuedToForWin = 3;  
    private float timer = 0f;





    #region Default Functions

     void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }


    void Start()
    {
        StartCoroutine(StartLevel(false));
    }

    void Update()
    {
        Timer();
    }

    #endregion

    #region Game Status

    public IEnumerator StartLevel(bool restart)
    {
        frog.active = false;
        gameActive = false;
     
        if (!restart)
        {
            fadeAnim.Play("fadeOut");
        }
        else
        {

            fadeAnim.Play("fadeIn");
            yield return new WaitForSeconds(0.4f);
            fadeAnim.Play("fadeOut");
        }

        //Remove current obstacles and create new ones according to level data.
        levelSetter.LoadLevel(levelNumber);
        foreach (Zone zone in zones)
        {
            zone.pointClaimed = false;
            if (zone.spawn != null)
            {
                zone.spawn.DestroyObjects();
                zone.spawn.CreateObjects();
            }

        }
        //Resets station claims
        foreach (Station station in stations) station.Reset();
        frog.Respawn();
        level.text = "Level "+ levelNumber;
        levelAnim.Play("showLevel");
        yield return new WaitForSeconds(0.2f);
        //Reset level status values to defualt
        livesCurrent = livesTotal;
        frogsLeft.text = livesCurrent.ToString();
        points = 0;
        stationsClaimed = 0;
        score.text = points.ToString();
        timer = timerDuration;
        levelTimer.maxTimerValue = timerDuration;
        frog.active = true;
        gameActive = true;

    }

    void GameOver(string msg, string blink, AudioClip audio)
    {
        frog.active = false;
        gameActive = false;
        fadeAnim.Play(blink);
        level.text = msg;
        levelAnim.Play("showLevel");
        score2.text =  points.ToString();
        scoreAnim.Play("pop");
        aS.clip = audio;
        aS.Play();
    }

    IEnumerator Victory()
    {
        GameOver("Victory!", "yellowBlink", victorySFX);
        yield return new WaitForSeconds(3f);
        fadeAnim.Play("fadeIn");
        yield return new WaitForSeconds(1.4f);
        levelNumber++;
        StartCoroutine(StartLevel(false));
    }

    IEnumerator Defeat()
    {
        GameOver("Defeat!", "redBlink", defeatSFX);
        yield return new WaitForSeconds(3f);
        fadeAnim.Play("fadeIn");
        yield return new WaitForSeconds(1.4f);
        StartCoroutine(StartLevel(false));
    }

    private void Timer()
    {
        if (gameActive)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
                levelTimer.adjust(timer);
            }
            else frog.Death();
        }
    }




    #endregion

    #region UI

    public void GrantPoints(float amount)
    {
        points+= (int)amount;
        score.text = points.ToString();
    }

    public void FrogDeath()
    {
        fadeAnim.Play("redBlink");
        foreach (Zone zone in zones) zone.pointClaimed = false;
        livesCurrent--;
        timer = timerDuration;
        frogsLeft.text = livesCurrent.ToString();
        if (livesCurrent <= 0) StartCoroutine(Defeat());
    }

    public void StationCleared()
    {
        stationsClaimed++;
        foreach (Zone zone in zones) zone.pointClaimed = false;
        //Add points based on time left and then reset the timer
        GrantPoints(timer * timerPointMultiplier);
        timer = timerDuration;
        if (stationsClaimed >= frogsRescuedToForWin) StartCoroutine(Victory());
    }

    #endregion

}
