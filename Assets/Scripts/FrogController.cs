using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] SpriteRenderer sr;
    [SerializeField] Animator anim;
    [SerializeField] AudioSource aS;
    [SerializeField] AudioClip jump1SFX;
    [SerializeField] AudioClip jump2SFX;
    [SerializeField] AudioClip deathSFX;
    private InputMap keyMap;


    [Header("Status")]
    [SerializeField] private Vector2 spawnPostion;
    [SerializeField] public bool alive = true;
    public bool active = true;
    private float reviveTimer = 0f;
    [Range(0.5f, 2f)] [SerializeField] private float reviveDuration = 1.2f;
    public bool isOnPlatform = false;

    [Header("Movement")]
    [SerializeField] public bool isJumping = false;
    [Range(0.1f, 8f)] [SerializeField] private float jumpStrength = 5f;
    [Range(0.01f, 10f)] [SerializeField] private float jumpSpeed = 0.75f;
    private bool alternateSFX = false;

    public Coroutine jumpCoroutine;




    #region Default Functions

    //Keymap and spawn location setup
    void Awake()
    {
        keyMap = new InputMap();
        spawnPostion = transform.position;
    }
    void OnEnable()
    {
        keyMap.Enable();
    }
    void OnDisable()
    {
        keyMap.Disable();
    }


    void Update()
    {
        if (alive) ReadInput();
        else ReviveTimer();
    }

    #endregion

    #region Movement
    void ReadInput()
    {
        //Movement input
        if(!isJumping && active)
        {
            if (keyMap.c.moveUp.WasPerformedThisFrame()) jumpCoroutine=StartCoroutine(Jump(new Vector2(0, 1), 0));
            if (keyMap.c.moveRight.WasPerformedThisFrame()) jumpCoroutine = StartCoroutine(Jump(new Vector2(1, 0), -90));
            if (keyMap.c.moveDown.WasPerformedThisFrame()) jumpCoroutine = StartCoroutine(Jump(new Vector2(0, -1), 180));
            if (keyMap.c.moveLeft.WasPerformedThisFrame()) jumpCoroutine = StartCoroutine(Jump(new Vector2(-1, 0), 90));
        }
     
        //Cheat codes
        if(GameController.Instance.gameActive)
        {
            if (keyMap.c.restart.WasPerformedThisFrame()) GameController.Instance.StartCoroutine(GameController.Instance.StartLevel(true));
            if (keyMap.c.level1.WasPerformedThisFrame())
            {
                GameController.Instance.levelNumber = 1;
                GameController.Instance.StartCoroutine(GameController.Instance.StartLevel(true));
            }
            if (keyMap.c.level2.WasPerformedThisFrame())
            {
                GameController.Instance.levelNumber = 2;
                GameController.Instance.StartCoroutine(GameController.Instance.StartLevel(true));
            }
            if (keyMap.c.level3.WasPerformedThisFrame())
            {
                GameController.Instance.levelNumber = 3;
                GameController.Instance.StartCoroutine(GameController.Instance.StartLevel(true));
            }
        }
       

    }

    IEnumerator Jump(Vector2 direction, float facing)
    {
        anim.Play("Jump");
        transform.eulerAngles = Vector3.forward * facing;
        isJumping = true;
        if (alternateSFX) aS.clip = jump1SFX;
        else aS.clip = jump2SFX;
        alternateSFX = !alternateSFX;
        aS.Play();
        Vector2 target = new Vector2(transform.position.x + direction.x * jumpStrength, transform.position.y + direction.y * jumpStrength);
        Vector2 pos = transform.position;
        while (pos != target)
        {
            pos = Vector2.MoveTowards(pos, target, Time.deltaTime * jumpSpeed);
            transform.position = pos;
            yield return null;
        }
        isJumping = false;
    }



    #endregion

    #region Status

    public void Death()
    {
        if (alive)
        {
            if(jumpCoroutine!=null) StopCoroutine(jumpCoroutine);
            GameController.Instance.FrogDeath();
            reviveTimer = reviveDuration;
            alive = false;
            isJumping = false;
            anim.Play("Death");
            transform.parent = null;
            aS.clip = deathSFX;
            aS.Play();
        }
    }

    void ReviveTimer()
    {
        if (reviveTimer > 0) reviveTimer -= Time.deltaTime;
        else Respawn();
    }

    public void Respawn()
    {
            if (jumpCoroutine != null) StopCoroutine(jumpCoroutine);
            transform.position = spawnPostion;
            isJumping = false;
            anim.Play("Respawn");
            alive = true;
            transform.eulerAngles = Vector3.forward * 0f;
    }

    #endregion 

}
