using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlowComands : MonoBehaviour
{



    public static GlowComands Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            SceneManager.sceneLoaded += OnSceneLoaded;

            if (SceneManager.GetActiveScene().name != "SampleScene")
            {
                SceneManager.LoadScene("SampleScene");
            }
            else
            {
                OnSceneLoaded(SceneManager.GetActiveScene(), LoadSceneMode.Single);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //------------------------------------------------------------------------------


    private static HashSet<string> initializedScenes = new HashSet<string>();


    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        string sceneName = scene.name;

        if (!initializedScenes.Contains(sceneName))
        {
            initializedScenes.Add(sceneName);

            FirstTimeSceneInit(sceneName);
        }





        if (scene.name == "SampleScene")
        {


            _barF = GameObject.FindWithTag("barF");

            if (_barF != null)
                barF = _barF.transform;
            else
                barF = null;



            //sampleScene
            _darkness.transform.localScale = new Vector3(2f, 1.5f, 0);
            _darkness.transform.position = new Vector3(0.08f, 0.19f, 0);



            if (Day == 1)
            {
                SetSpriteByIndex(SpriteChoices.allInstructions, 12);
                _Information.transform.localScale = new Vector3(1, 1, 1);
                _Information.transform.position = new Vector3(11f, 6.27f, 0);
            }
            if (Day == 2)
            {
                SetSpriteByIndex(SpriteChoices.allInstructions, 13);
                _Information.transform.localScale = new Vector3(1, 1, 1);
                _Information.transform.position = new Vector3(11f, 6.27f, 0);
            }
            if (Day == 3)
            {
                SetSpriteByIndex(SpriteChoices.allInstructions, 14);
                _Information.transform.localScale = new Vector3(1, 1, 1);
                _Information.transform.position = new Vector3(11f, 6.27f, 0);
            }
            if (Day == 4)
            {
                SetSpriteByIndex(SpriteChoices.allInstructions, 15);
                _Information.transform.localScale = new Vector3(1, 1, 1);
                _Information.transform.position = new Vector3(11f, 6.27f, 0);
            }
            if (Day == 5)
            {
                SetSpriteByIndex(SpriteChoices.allInstructions, 16);
                _Information.transform.localScale = new Vector3(1, 1, 1);
                _Information.transform.position = new Vector3(11f, 6.27f, 0);
            }








            _pill1 = GameObject.FindWithTag("GreenPill");
            _pill2 = GameObject.FindWithTag("TealPill");
            _pill3 = GameObject.FindWithTag("PurplePill");

            _TealE = GameObject.FindWithTag("TEmpty");
            _PurpleE = GameObject.FindWithTag("PEmpty");
            _GreenE = GameObject.FindWithTag("GEmpty");

            _shine1 = GameObject.FindWithTag("shine1");
            _shine2 = GameObject.FindWithTag("shine2");
            _shine3 = GameObject.FindWithTag("shine3");


            _hat = GameObject.FindWithTag("hat");
            _shovel = GameObject.FindWithTag("shovel");
            _bear = GameObject.FindWithTag("bear");

            _flower1 = GameObject.FindWithTag("flower1");
            _flower2 = GameObject.FindWithTag("flower2");
            _flower3 = GameObject.FindWithTag("flower3");

            _a1 = GameObject.FindWithTag("a1");
            _b2 = GameObject.FindWithTag("b2");
            _c3 = GameObject.FindWithTag("c3");

            _atb = GameObject.FindWithTag("atb");
            _bh = GameObject.FindWithTag("bh");
            _cs = GameObject.FindWithTag("cs");



            if (IsCurrentSprite(SpriteChoices.Hands, 2) || IsCurrentSprite(SpriteChoices.Hands, 6) || IsCurrentSprite(SpriteChoices.Hands, 10) || IsCurrentSprite(SpriteChoices.Hands, 14) || IsCurrentSprite(SpriteChoices.Hands, 18))
            {
                _TealE.SetActive(true);
                _pill2.SetActive(false);

            }

            if (IsCurrentSprite(SpriteChoices.Hands, 1) || IsCurrentSprite(SpriteChoices.Hands, 5) || IsCurrentSprite(SpriteChoices.Hands, 9) || IsCurrentSprite(SpriteChoices.Hands, 13) || IsCurrentSprite(SpriteChoices.Hands, 17))
            {
                _GreenE.SetActive(true);
                _pill1.SetActive(false);

            }

            if (IsCurrentSprite(SpriteChoices.Hands, 3) || IsCurrentSprite(SpriteChoices.Hands, 7) || IsCurrentSprite(SpriteChoices.Hands, 11) || IsCurrentSprite(SpriteChoices.Hands, 15) || IsCurrentSprite(SpriteChoices.Hands, 19))
            {
                _PurpleE.SetActive(true);
                _pill3.SetActive(false);

            }

            _NextButton = GameObject.FindWithTag("NextButton");

            greenPillMon1 = GameObject.FindWithTag("GreenPillMon1");
            greenPillMon2 = GameObject.FindWithTag("GreenPillMon2");

            tealPillMon1 = GameObject.FindWithTag("TealPillMon1");
            tealPillMon2 = GameObject.FindWithTag("TealPillMon2");
            tealPillMon3 = GameObject.FindWithTag("TealPillMon3");

            purplePillMon1 = GameObject.FindWithTag("PurplePillMon1");

            greenPillTue1 = GameObject.FindWithTag("GreenPillTue1");
            greenPillTue2 = GameObject.FindWithTag("GreenPillTue2");

            tealPillTue1 = GameObject.FindWithTag("TealPillTue1");
            tealPillTue2 = GameObject.FindWithTag("TealPillTue2");
            tealPillTue3 = GameObject.FindWithTag("TealPillTue3");

            purplePillTue1 = GameObject.FindWithTag("PurplePillTue1");

            greenPillWed1 = GameObject.FindWithTag("GreenPillWed1");
            greenPillWed2 = GameObject.FindWithTag("GreenPillWed2");

            tealPillWed1 = GameObject.FindWithTag("TealPillWed1");
            tealPillWed2 = GameObject.FindWithTag("TealPillWed2");
            tealPillWed3 = GameObject.FindWithTag("TealPillWed3");

            purplePillWed1 = GameObject.FindWithTag("PurplePillWed1");

            greenPillThur1 = GameObject.FindWithTag("GreenPillThur1");
            greenPillThur2 = GameObject.FindWithTag("GreenPillThur2");

            tealPillThur1 = GameObject.FindWithTag("TealPillThur1");
            tealPillThur2 = GameObject.FindWithTag("TealPillThur2");
            tealPillThur3 = GameObject.FindWithTag("TealPillThur3");

            purplePillThur1 = GameObject.FindWithTag("PurplePillThur1");

            greenPillFri1 = GameObject.FindWithTag("GreenPillFri1");
            greenPillFri2 = GameObject.FindWithTag("GreenPillFri2");

            tealPillFri1 = GameObject.FindWithTag("TealPillFri1");
            tealPillFri2 = GameObject.FindWithTag("TealPillFri2");
            tealPillFri3 = GameObject.FindWithTag("TealPillFri3");

            purplePillFri1 = GameObject.FindWithTag("PurplePillFri1");

            greenPillSat1 = GameObject.FindWithTag("GreenPillSat1");
            greenPillSat2 = GameObject.FindWithTag("GreenPillSat2");

            tealPillSat1 = GameObject.FindWithTag("TealPillSat1");
            tealPillSat2 = GameObject.FindWithTag("TealPillSat2");
            tealPillSat3 = GameObject.FindWithTag("TealPillSat3");

            purplePillSat1 = GameObject.FindWithTag("PurplePillSat1");

            greenPillSun1 = GameObject.FindWithTag("GreenPillSun1");
            greenPillSun2 = GameObject.FindWithTag("GreenPillSun2");

            tealPillSun1 = GameObject.FindWithTag("TealPillSun1");
            tealPillSun2 = GameObject.FindWithTag("TealPillSun2");
            tealPillSun3 = GameObject.FindWithTag("TealPillSun3");

            purplePillSun1 = GameObject.FindWithTag("PurplePillSun1");

            restartButton = GameObject.FindWithTag("restartButton");

            greenPillMon1 = GameObject.FindWithTag("GreenPillMon1");

            _goalBar1 = GameObject.FindWithTag("goalBar1");
            _goalBar2 = GameObject.FindWithTag("goalBar2");


            startObjects = GameObject.FindWithTag("startObjects");

            _WindowWarning = GameObject.FindWithTag("WindowWarning");
            _WindowWarning.GetComponent<SpriteRenderer>().enabled = false;

        }

        if (scene.name == "RadioScene")
        {
            _barF = GameObject.FindWithTag("barF");

            if (_barF != null)
                barF = _barF.transform;
            else
                barF = null;

            _NextButton = GameObject.FindWithTag("NextButton");

            SetSpriteByIndex(SpriteChoices.allInstructions, 0);
            _Information.transform.localScale = new Vector3(0.8f, 0.8f, 1f);
            _Information.transform.position = new Vector3(-9f, 0f, 0f);


            _barF.transform.localScale = new Vector3(2f, 0f, 1f);



            //radio
            _darkness.transform.localScale = new Vector3(1.1f, 1f, 0);


            _hat = GameObject.FindWithTag("hat");
            _shovel = GameObject.FindWithTag("shovel");
            _bear = GameObject.FindWithTag("bear");

            _flower1 = GameObject.FindWithTag("flower1");
            _flower2 = GameObject.FindWithTag("flower2");
            _flower3 = GameObject.FindWithTag("flower3");

            _a1 = GameObject.FindWithTag("a1");
            _b2 = GameObject.FindWithTag("b2");
            _c3 = GameObject.FindWithTag("c3");

            _atb = GameObject.FindWithTag("atb");
            _bh = GameObject.FindWithTag("bh");
            _cs = GameObject.FindWithTag("cs");



            _pill1 = GameObject.FindWithTag("Placeholder1");
            _pill2 = GameObject.FindWithTag("Placeholder2");
            _pill3 = GameObject.FindWithTag("Placeholder3");

            _TealE = GameObject.FindWithTag("Placeholder4");
            _PurpleE = GameObject.FindWithTag("Placeholder5");
            _GreenE = GameObject.FindWithTag("Placeholder6");

            _shine1 = GameObject.FindWithTag("Placeholder7");
            _shine2 = GameObject.FindWithTag("Placeholder8");
            _shine3 = GameObject.FindWithTag("Placeholder9");

            greenPillMon1 = GameObject.FindWithTag("GreenPillMon1");
            greenPillMon2 = GameObject.FindWithTag("GreenPillMon2");

            tealPillMon1 = GameObject.FindWithTag("TealPillMon1");
            tealPillMon2 = GameObject.FindWithTag("TealPillMon2");
            tealPillMon3 = GameObject.FindWithTag("TealPillMon3");

            purplePillMon1 = GameObject.FindWithTag("PurplePillMon1");

            greenPillTue1 = GameObject.FindWithTag("GreenPillTue1");
            greenPillTue2 = GameObject.FindWithTag("GreenPillTue2");

            tealPillTue1 = GameObject.FindWithTag("TealPillTue1");
            tealPillTue2 = GameObject.FindWithTag("TealPillTue2");
            tealPillTue3 = GameObject.FindWithTag("TealPillTue3");

            purplePillTue1 = GameObject.FindWithTag("PurplePillTue1");

            greenPillWed1 = GameObject.FindWithTag("GreenPillWed1");
            greenPillWed2 = GameObject.FindWithTag("GreenPillWed2");

            tealPillWed1 = GameObject.FindWithTag("TealPillWed1");
            tealPillWed2 = GameObject.FindWithTag("TealPillWed2");
            tealPillWed3 = GameObject.FindWithTag("TealPillWed3");

            purplePillWed1 = GameObject.FindWithTag("PurplePillWed1");

            greenPillThur1 = GameObject.FindWithTag("GreenPillThur1");
            greenPillThur2 = GameObject.FindWithTag("GreenPillThur2");

            tealPillThur1 = GameObject.FindWithTag("TealPillThur1");
            tealPillThur2 = GameObject.FindWithTag("TealPillThur2");
            tealPillThur3 = GameObject.FindWithTag("TealPillThur3");

            purplePillThur1 = GameObject.FindWithTag("PurplePillThur1");

            greenPillFri1 = GameObject.FindWithTag("GreenPillFri1");
            greenPillFri2 = GameObject.FindWithTag("GreenPillFri2");

            tealPillFri1 = GameObject.FindWithTag("TealPillFri1");
            tealPillFri2 = GameObject.FindWithTag("TealPillFri2");
            tealPillFri3 = GameObject.FindWithTag("TealPillFri3");

            purplePillFri1 = GameObject.FindWithTag("PurplePillFri1");

            greenPillSat1 = GameObject.FindWithTag("GreenPillSat1");
            greenPillSat2 = GameObject.FindWithTag("GreenPillSat2");

            tealPillSat1 = GameObject.FindWithTag("TealPillSat1");
            tealPillSat2 = GameObject.FindWithTag("TealPillSat2");
            tealPillSat3 = GameObject.FindWithTag("TealPillSat3");

            purplePillSat1 = GameObject.FindWithTag("PurplePillSat1");

            greenPillSun1 = GameObject.FindWithTag("GreenPillSun1");
            greenPillSun2 = GameObject.FindWithTag("GreenPillSun2");

            tealPillSun1 = GameObject.FindWithTag("TealPillSun1");
            tealPillSun2 = GameObject.FindWithTag("TealPillSun2");
            tealPillSun3 = GameObject.FindWithTag("TealPillSun3");

            purplePillSun1 = GameObject.FindWithTag("PurplePillSun1");

            restartButton = GameObject.FindWithTag("restartButton");

            _goalBar1 = GameObject.FindWithTag("goalBar1");
            _goalBar2 = GameObject.FindWithTag("goalBar2");


            startObjects = GameObject.FindWithTag("startObjects");

            _WindowWarning = GameObject.FindWithTag("WindowWarning");

        }

        if (scene.name == "WindowScene")
        {
            if (Day == 1 || Day == 2 || Day == 3)
            {
                SetSpriteByIndex(SpriteChoices.Hands, 20);
            }


            if (Day == 4 || Day == 5)
            {
                SetSpriteByIndex(SpriteChoices.Hands, 21);
            }


            SetSpriteByIndex(SpriteChoices.allInstructions, 4);
            _Information.transform.localScale = new Vector3(1f, 1f, 1f);
            _Information.transform.position = new Vector3(-8f, -5f, 0f);



            //window
            _darkness.transform.localScale = new Vector3(1.2f, 1f, 0);

            _barF = GameObject.FindWithTag("barF");

            if (_barF != null)
                barF = _barF.transform;
            else
                barF = null;


            _NextButton = GameObject.FindWithTag("NextButton");



            _hat = GameObject.FindWithTag("hat");
            _shovel = GameObject.FindWithTag("shovel");
            _bear = GameObject.FindWithTag("bear");

            _flower1 = GameObject.FindWithTag("flower1");
            _flower2 = GameObject.FindWithTag("flower2");
            _flower3 = GameObject.FindWithTag("flower3");

            _a1 = GameObject.FindWithTag("a1");
            _b2 = GameObject.FindWithTag("b2");
            _c3 = GameObject.FindWithTag("c3");

            _atb = GameObject.FindWithTag("atb");
            _bh = GameObject.FindWithTag("bh");
            _cs = GameObject.FindWithTag("cs");



            _pill1 = GameObject.FindWithTag("Placeholder1");
            _pill2 = GameObject.FindWithTag("Placeholder2");
            _pill3 = GameObject.FindWithTag("Placeholder3");

            _TealE = GameObject.FindWithTag("Placeholder4");
            _PurpleE = GameObject.FindWithTag("Placeholder5");
            _GreenE = GameObject.FindWithTag("Placeholder6");

            _shine1 = GameObject.FindWithTag("Placeholder7");
            _shine2 = GameObject.FindWithTag("Placeholder8");
            _shine3 = GameObject.FindWithTag("Placeholder9");

            greenPillMon1 = GameObject.FindWithTag("GreenPillMon1");
            greenPillMon2 = GameObject.FindWithTag("GreenPillMon2");

            tealPillMon1 = GameObject.FindWithTag("TealPillMon1");
            tealPillMon2 = GameObject.FindWithTag("TealPillMon2");
            tealPillMon3 = GameObject.FindWithTag("TealPillMon3");

            purplePillMon1 = GameObject.FindWithTag("PurplePillMon1");

            greenPillTue1 = GameObject.FindWithTag("GreenPillTue1");
            greenPillTue2 = GameObject.FindWithTag("GreenPillTue2");

            tealPillTue1 = GameObject.FindWithTag("TealPillTue1");
            tealPillTue2 = GameObject.FindWithTag("TealPillTue2");
            tealPillTue3 = GameObject.FindWithTag("TealPillTue3");

            purplePillTue1 = GameObject.FindWithTag("PurplePillTue1");

            greenPillWed1 = GameObject.FindWithTag("GreenPillWed1");
            greenPillWed2 = GameObject.FindWithTag("GreenPillWed2");

            tealPillWed1 = GameObject.FindWithTag("TealPillWed1");
            tealPillWed2 = GameObject.FindWithTag("TealPillWed2");
            tealPillWed3 = GameObject.FindWithTag("TealPillWed3");

            purplePillWed1 = GameObject.FindWithTag("PurplePillWed1");

            greenPillThur1 = GameObject.FindWithTag("GreenPillThur1");
            greenPillThur2 = GameObject.FindWithTag("GreenPillThur2");

            tealPillThur1 = GameObject.FindWithTag("TealPillThur1");
            tealPillThur2 = GameObject.FindWithTag("TealPillThur2");
            tealPillThur3 = GameObject.FindWithTag("TealPillThur3");

            purplePillThur1 = GameObject.FindWithTag("PurplePillThur1");

            greenPillFri1 = GameObject.FindWithTag("GreenPillFri1");
            greenPillFri2 = GameObject.FindWithTag("GreenPillFri2");

            tealPillFri1 = GameObject.FindWithTag("TealPillFri1");
            tealPillFri2 = GameObject.FindWithTag("TealPillFri2");
            tealPillFri3 = GameObject.FindWithTag("TealPillFri3");

            purplePillFri1 = GameObject.FindWithTag("PurplePillFri1");

            greenPillSat1 = GameObject.FindWithTag("GreenPillSat1");
            greenPillSat2 = GameObject.FindWithTag("GreenPillSat2");

            tealPillSat1 = GameObject.FindWithTag("TealPillSat1");
            tealPillSat2 = GameObject.FindWithTag("TealPillSat2");
            tealPillSat3 = GameObject.FindWithTag("TealPillSat3");

            purplePillSat1 = GameObject.FindWithTag("PurplePillSat1");

            greenPillSun1 = GameObject.FindWithTag("GreenPillSun1");
            greenPillSun2 = GameObject.FindWithTag("GreenPillSun2");

            tealPillSun1 = GameObject.FindWithTag("TealPillSun1");
            tealPillSun2 = GameObject.FindWithTag("TealPillSun2");
            tealPillSun3 = GameObject.FindWithTag("TealPillSun3");

            purplePillSun1 = GameObject.FindWithTag("PurplePillSun1");

            restartButton = GameObject.FindWithTag("restartButton");

            _goalBar1 = GameObject.FindWithTag("goalBar1");
            _goalBar2 = GameObject.FindWithTag("goalBar2");


            startObjects = GameObject.FindWithTag("startObjects");

            _WindowWarning = GameObject.FindWithTag("WindowWarning");

        }

        if (scene.name == "pillOrganizerScene")
        {

            //remember, once you click the "next day button" reset the pills



            //pills
            _darkness.transform.localScale = new Vector3(1f, 1f, 0);


            _barF = GameObject.FindWithTag("barF");

            if (_barF != null)
                barF = _barF.transform;
            else
                barF = null;


            if (Day == 1)
            {
                SetSpriteByIndex(SpriteChoices.allInstructions, 7);
                _Information.transform.localScale = new Vector3(0.85f, 0.85f, 1);
                _Information.transform.position = new Vector3(-9.6f, -0.5f, 0);
            }
            if (Day == 2)
            {
                SetSpriteByIndex(SpriteChoices.allInstructions, 8);
                _Information.transform.localScale = new Vector3(0.85f, 0.85f, 1);
                _Information.transform.position = new Vector3(-9.6f, -0.5f, 0);
            }
            if (Day == 3)
            {
                SetSpriteByIndex(SpriteChoices.allInstructions, 9);
                _Information.transform.localScale = new Vector3(0.85f, 0.85f, 1);
                _Information.transform.position = new Vector3(-9.6f, -0.5f, 0);
            }
            if (Day == 4)
            {
                SetSpriteByIndex(SpriteChoices.allInstructions, 10);
                _Information.transform.localScale = new Vector3(0.85f, 0.85f, 1);
                _Information.transform.position = new Vector3(-9.6f, -0.5f, 0);
            }
            if (Day == 5)
            {
                SetSpriteByIndex(SpriteChoices.allInstructions, 11);
                _Information.transform.localScale = new Vector3(0.85f, 0.85f, 1);
                _Information.transform.position = new Vector3(-9.6f, -0.5f, 0);
            }



            _NextButton = GameObject.FindWithTag("NextButton");



            _hat = GameObject.FindWithTag("hat");
            _shovel = GameObject.FindWithTag("shovel");
            _bear = GameObject.FindWithTag("bear");

            _flower1 = GameObject.FindWithTag("flower1");
            _flower2 = GameObject.FindWithTag("flower2");
            _flower3 = GameObject.FindWithTag("flower3");

            _a1 = GameObject.FindWithTag("a1");
            _b2 = GameObject.FindWithTag("b2");
            _c3 = GameObject.FindWithTag("c3");

            _atb = GameObject.FindWithTag("atb");
            _bh = GameObject.FindWithTag("bh");
            _cs = GameObject.FindWithTag("cs");




            _pill1 = GameObject.FindWithTag("Placeholder1");
            _pill2 = GameObject.FindWithTag("Placeholder2");
            _pill3 = GameObject.FindWithTag("Placeholder3");

            _TealE = GameObject.FindWithTag("Placeholder4");
            _PurpleE = GameObject.FindWithTag("Placeholder5");
            _GreenE = GameObject.FindWithTag("Placeholder6");

            _shine1 = GameObject.FindWithTag("Placeholder7");
            _shine2 = GameObject.FindWithTag("Placeholder8");
            _shine3 = GameObject.FindWithTag("Placeholder9");

            greenPillMon1 = GameObject.FindWithTag("GreenPillMon1");
            greenPillMon2 = GameObject.FindWithTag("GreenPillMon2");

            tealPillMon1 = GameObject.FindWithTag("TealPillMon1");
            tealPillMon2 = GameObject.FindWithTag("TealPillMon2");
            tealPillMon3 = GameObject.FindWithTag("TealPillMon3");

            purplePillMon1 = GameObject.FindWithTag("PurplePillMon1");

            greenPillTue1 = GameObject.FindWithTag("GreenPillTue1");
            greenPillTue2 = GameObject.FindWithTag("GreenPillTue2");

            tealPillTue1 = GameObject.FindWithTag("TealPillTue1");
            tealPillTue2 = GameObject.FindWithTag("TealPillTue2");
            tealPillTue3 = GameObject.FindWithTag("TealPillTue3");

            purplePillTue1 = GameObject.FindWithTag("PurplePillTue1");

            greenPillWed1 = GameObject.FindWithTag("GreenPillWed1");
            greenPillWed2 = GameObject.FindWithTag("GreenPillWed2");

            tealPillWed1 = GameObject.FindWithTag("TealPillWed1");
            tealPillWed2 = GameObject.FindWithTag("TealPillWed2");
            tealPillWed3 = GameObject.FindWithTag("TealPillWed3");

            purplePillWed1 = GameObject.FindWithTag("PurplePillWed1");

            greenPillThur1 = GameObject.FindWithTag("GreenPillThur1");
            greenPillThur2 = GameObject.FindWithTag("GreenPillThur2");

            tealPillThur1 = GameObject.FindWithTag("TealPillThur1");
            tealPillThur2 = GameObject.FindWithTag("TealPillThur2");
            tealPillThur3 = GameObject.FindWithTag("TealPillThur3");

            purplePillThur1 = GameObject.FindWithTag("PurplePillThur1");

            greenPillFri1 = GameObject.FindWithTag("GreenPillFri1");
            greenPillFri2 = GameObject.FindWithTag("GreenPillFri2");

            tealPillFri1 = GameObject.FindWithTag("TealPillFri1");
            tealPillFri2 = GameObject.FindWithTag("TealPillFri2");
            tealPillFri3 = GameObject.FindWithTag("TealPillFri3");

            purplePillFri1 = GameObject.FindWithTag("PurplePillFri1");

            greenPillSat1 = GameObject.FindWithTag("GreenPillSat1");
            greenPillSat2 = GameObject.FindWithTag("GreenPillSat2");

            tealPillSat1 = GameObject.FindWithTag("TealPillSat1");
            tealPillSat2 = GameObject.FindWithTag("TealPillSat2");
            tealPillSat3 = GameObject.FindWithTag("TealPillSat3");

            purplePillSat1 = GameObject.FindWithTag("PurplePillSat1");

            greenPillSun1 = GameObject.FindWithTag("GreenPillSun1");
            greenPillSun2 = GameObject.FindWithTag("GreenPillSun2");

            tealPillSun1 = GameObject.FindWithTag("TealPillSun1");
            tealPillSun2 = GameObject.FindWithTag("TealPillSun2");
            tealPillSun3 = GameObject.FindWithTag("TealPillSun3");

            purplePillSun1 = GameObject.FindWithTag("PurplePillSun1");

            restartButton = GameObject.FindWithTag("restartButton");

            _goalBar1 = GameObject.FindWithTag("goalBar1");
            _goalBar2 = GameObject.FindWithTag("goalBar2");


            startObjects = GameObject.FindWithTag("startObjects");


            _WindowWarning = GameObject.FindWithTag("WindowWarning");




            // monPillThingy
            greenPillMon1.GetComponent<SpriteRenderer>().enabled = false;
            greenPillMon2.GetComponent<SpriteRenderer>().enabled = false;

            tealPillMon1.GetComponent<SpriteRenderer>().enabled = false;
            tealPillMon2.GetComponent<SpriteRenderer>().enabled = false;
            tealPillMon3.GetComponent<SpriteRenderer>().enabled = false;

            purplePillMon1.GetComponent<SpriteRenderer>().enabled = false;

            // tuePillThingy
            greenPillTue1.GetComponent<SpriteRenderer>().enabled = false;
            greenPillTue2.GetComponent<SpriteRenderer>().enabled = false;

            tealPillTue1.GetComponent<SpriteRenderer>().enabled = false;
            tealPillTue2.GetComponent<SpriteRenderer>().enabled = false;
            tealPillTue3.GetComponent<SpriteRenderer>().enabled = false;

            purplePillTue1.GetComponent<SpriteRenderer>().enabled = false;

            // wedPillThingy
            greenPillWed1.GetComponent<SpriteRenderer>().enabled = false;
            greenPillWed2.GetComponent<SpriteRenderer>().enabled = false;

            tealPillWed1.GetComponent<SpriteRenderer>().enabled = false;
            tealPillWed2.GetComponent<SpriteRenderer>().enabled = false;
            tealPillWed3.GetComponent<SpriteRenderer>().enabled = false;

            purplePillWed1.GetComponent<SpriteRenderer>().enabled = false;

            // thurPillThingy
            greenPillThur1.GetComponent<SpriteRenderer>().enabled = false;
            greenPillThur2.GetComponent<SpriteRenderer>().enabled = false;

            tealPillThur1.GetComponent<SpriteRenderer>().enabled = false;
            tealPillThur2.GetComponent<SpriteRenderer>().enabled = false;
            tealPillThur3.GetComponent<SpriteRenderer>().enabled = false;

            purplePillThur1.GetComponent<SpriteRenderer>().enabled = false;

            // friPillThingy
            greenPillFri1.GetComponent<SpriteRenderer>().enabled = false;
            greenPillFri2.GetComponent<SpriteRenderer>().enabled = false;

            tealPillFri1.GetComponent<SpriteRenderer>().enabled = false;
            tealPillFri2.GetComponent<SpriteRenderer>().enabled = false;
            tealPillFri3.GetComponent<SpriteRenderer>().enabled = false;

            purplePillFri1.GetComponent<SpriteRenderer>().enabled = false;

            // satPillThingy
            greenPillSat1.GetComponent<SpriteRenderer>().enabled = false;
            greenPillSat2.GetComponent<SpriteRenderer>().enabled = false;

            tealPillSat1.GetComponent<SpriteRenderer>().enabled = false;
            tealPillSat2.GetComponent<SpriteRenderer>().enabled = false;
            tealPillSat3.GetComponent<SpriteRenderer>().enabled = false;

            purplePillSat1.GetComponent<SpriteRenderer>().enabled = false;

            // sunPillThingy
            greenPillSun1.GetComponent<SpriteRenderer>().enabled = false;
            greenPillSun2.GetComponent<SpriteRenderer>().enabled = false;

            tealPillSun1.GetComponent<SpriteRenderer>().enabled = false;
            tealPillSun2.GetComponent<SpriteRenderer>().enabled = false;
            tealPillSun3.GetComponent<SpriteRenderer>().enabled = false;

            purplePillSun1.GetComponent<SpriteRenderer>().enabled = false;




        }

    }


    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    //keep in mind that the days will be set thence forth by nextdaybutton.(pressed to move on.)
    void FirstTimeSceneInit(string sceneName)
    {
        if (sceneName == "SampleScene")
        {
            SampleSceneTutorial = true;
            Day = 1;
            Debug.Log("First time loading SampleScene; playing tutorial and setting Day as 1");
        }

        if (sceneName == "pillOrganizerScene")
        {

            PillTutorial = true;
            Debug.Log("First time loading pillScene; playing tutorial");
        }

        if (sceneName == "RadioScene")
        {
            RadioTutorial = true;
            Debug.Log("First time loading RadioScene; playing tutorial");
        }

        if (sceneName == "WindowScene")
        {
            WindowTutorial = true;
            Debug.Log("First time loading WindowScene; playing tutorial");
        }
    }















    public enum SpriteChoices { Hands, darkness, allInstructions }

    public PolygonCollider2D polyColliderHands;
    public SpriteRenderer spriteRendererHands;
    public Sprite[] spriteOptionsHands;

    public SpriteRenderer spriteRendererDarkness;
    public Sprite[] spriteOptionsDarkness;

    public SpriteRenderer spriteRendererallInstructions;
    public Sprite[] spriteOptionsallInstructions;




    void SetSpriteByIndex(SpriteChoices target, int index)
    {
        switch (target)
        {
            case SpriteChoices.Hands:
                if (index >= 0 && index < spriteOptionsHands.Length)
                    spriteRendererHands.sprite = spriteOptionsHands[index];


                // Reset collider after sprite change
                Destroy(polyColliderHands);
                polyColliderHands = spriteRendererHands.gameObject.AddComponent<PolygonCollider2D>();
                break;

            case SpriteChoices.darkness:
                if (index >= 0 && index < spriteOptionsDarkness.Length)
                    spriteRendererDarkness.sprite = spriteOptionsDarkness[index];
                break;

            case SpriteChoices.allInstructions:
                if (index >= 0 && index < spriteOptionsallInstructions.Length)
                    spriteRendererallInstructions.sprite = spriteOptionsallInstructions[index];
                break;
        }
    }

    bool IsCurrentSprite(SpriteChoices target, int index)
    {
        switch (target)
        {
            case SpriteChoices.Hands:
                if (index >= 0 && index < spriteOptionsHands.Length)
                    return spriteRendererHands.sprite == spriteOptionsHands[index];

                break;

            case SpriteChoices.darkness:
                if (index >= 0 && index < spriteOptionsDarkness.Length)
                    return spriteRendererDarkness.sprite == spriteOptionsDarkness[index];
                break;

            case SpriteChoices.allInstructions:
                if (index >= 0 && index < spriteOptionsallInstructions.Length)
                    return spriteRendererallInstructions.sprite == spriteOptionsallInstructions[index];
                break;
        }

        return false;
    }




    //Pills----->
    int _greenPillMonAmount = 0;
    int _greenPillTueAmount = 0;
    int _greenPillWedAmount = 0;
    int _greenPillThurAmount = 0;
    int _greenPillFriAmount = 0;
    int _greenPillSatAmount = 0;
    int _greenPillSunAmount = 0;

    int _tealPillMonAmount = 0;
    int _tealPillTueAmount = 0;
    int _tealPillWedAmount = 0;
    int _tealPillThurAmount = 0;
    int _tealPillFriAmount = 0;
    int _tealPillSatAmount = 0;
    int _tealPillSunAmount = 0;

    int _purplePillMonAmount = 0;
    int _purplePillTueAmount = 0;
    int _purplePillWedAmount = 0;
    int _purplePillThurAmount = 0;
    int _purplePillFriAmount = 0;
    int _purplePillSatAmount = 0;
    int _purplePillSunAmount = 0;



    bool pleaserRestart = false;
    bool pressedrestartButton = false;

    public bool IsTouchingNextDayButton = false;

    //-------------->
    public bool hasProgressedWin = false;
    public bool hasProgressedRad = false;
    public bool hasProgressedPill = false;


    public int changeSprite = 2;
    public bool isInTealPillTrigger = false;
    public bool isInTealPillEmptyTrigger = false;
    public bool isInGreenPillTrigger = false;
    public bool isInGreenPillEmptyTrigger = false;
    public bool isInPurplePillTrigger = false;
    public bool isInPurplePillEmptyTrigger = false;



    public bool isInRadioTrigger = false;
    public bool isInWindowTrigger = false;
    public bool isInPillThingyTrigger = false;
    public bool isInRadioEmptyTrigger = false;
    public bool isInWindowEmptyTrigger = false;
    public bool isInPillThingyEmptyTrigger = false;

    //---------------------//
    public bool isInNobTrigger = false;
    public bool NobInMotion = false;

    //---------------------//
    public bool isInMonTrigger = false;
    public bool isInTueTrigger = false;
    public bool isInWedTrigger = false;
    public bool isInThurTrigger = false;
    public bool isInFriTrigger = false;
    public bool isInSatTrigger = false;
    public bool isInSunTrigger = false;

    //---------------------//
    public bool isInATrigger = false;
    public bool isInBTrigger = false;
    public bool isInCTrigger = false;



    public bool hasSwitchedThisPress = false;


    public int Day = 0;
    public bool RadioTutorial = false;
    public bool WindowTutorial = false;
    public bool SampleSceneTutorial = false;
    public bool PillTutorial = false;



    public bool failDay1 = false;
    public bool failDay2 = false;
    public bool failDay3 = false;
    public bool failDay4 = false;
    public bool failDay5 = false;

    public int ProgressionProgress = 30;


    // =========================
    // === Pill Counters ======
    // =========================
    public int greenPillCounterMon = 0;
    public int tealPillCounterMon = 0;
    public int purplePillCounterMon = 0;

    public int greenPillCounterTue = 0;
    public int tealPillCounterTue = 0;
    public int purplePillCounterTue = 0;

    public int greenPillCounterWed = 0;
    public int tealPillCounterWed = 0;
    public int purplePillCounterWed = 0;

    public int greenPillCounterThur = 0;
    public int tealPillCounterThur = 0;
    public int purplePillCounterThur = 0;

    public int greenPillCounterFri = 0;
    public int tealPillCounterFri = 0;
    public int purplePillCounterFri = 0;

    public int greenPillCounterSat = 0;
    public int tealPillCounterSat = 0;
    public int purplePillCounterSat = 0;

    public int greenPillCounterSun = 0;
    public int tealPillCounterSun = 0;
    public int purplePillCounterSun = 0;





    //buttons
    bool _isIna1 = false;
    bool _isInb2 = false;
    bool _isInc3 = false;

    bool _isInatb = false;
    bool _isInbh = false;
    bool _isIncs = false;



    bool _isIna1Yes = false;
    bool _isInb2Yes = false;
    bool _isInc3Yes = false;

    bool _isInatbYes = false;
    bool _isInbhYes = false;
    bool _isIncsYes = false;




    // =========================
    // === pills in thingy ======
    // =========================
    [SerializeField] GameObject greenPillMon1;
    [SerializeField] GameObject greenPillMon2;

    [SerializeField] GameObject tealPillMon1;
    [SerializeField] GameObject tealPillMon2;
    [SerializeField] GameObject tealPillMon3;

    [SerializeField] GameObject purplePillMon1;

    [SerializeField] GameObject greenPillTue1;
    [SerializeField] GameObject greenPillTue2;

    [SerializeField] GameObject tealPillTue1;
    [SerializeField] GameObject tealPillTue2;
    [SerializeField] GameObject tealPillTue3;

    [SerializeField] GameObject purplePillTue1;

    [SerializeField] GameObject greenPillWed1;
    [SerializeField] GameObject greenPillWed2;

    [SerializeField] GameObject tealPillWed1;
    [SerializeField] GameObject tealPillWed2;
    [SerializeField] GameObject tealPillWed3;

    [SerializeField] GameObject purplePillWed1;

    [SerializeField] GameObject greenPillThur1;
    [SerializeField] GameObject greenPillThur2;

    [SerializeField] GameObject tealPillThur1;
    [SerializeField] GameObject tealPillThur2;
    [SerializeField] GameObject tealPillThur3;

    [SerializeField] GameObject purplePillThur1;

    [SerializeField] GameObject greenPillFri1;
    [SerializeField] GameObject greenPillFri2;

    [SerializeField] GameObject tealPillFri1;
    [SerializeField] GameObject tealPillFri2;
    [SerializeField] GameObject tealPillFri3;

    [SerializeField] GameObject purplePillFri1;

    [SerializeField] GameObject greenPillSat1;
    [SerializeField] GameObject greenPillSat2;

    [SerializeField] GameObject tealPillSat1;
    [SerializeField] GameObject tealPillSat2;
    [SerializeField] GameObject tealPillSat3;

    [SerializeField] GameObject purplePillSat1;

    [SerializeField] GameObject greenPillSun1;
    [SerializeField] GameObject greenPillSun2;

    [SerializeField] GameObject tealPillSun1;
    [SerializeField] GameObject tealPillSun2;
    [SerializeField] GameObject tealPillSun3;

    [SerializeField] GameObject purplePillSun1;





    [SerializeField] GameObject restartButton;


    [SerializeField] GameObject _NextButton;

    [SerializeField] GameObject _goalBar1;
    [SerializeField] GameObject _goalBar2;

    //->
    [SerializeField] GameObject _bear;
    [SerializeField] GameObject _shovel;
    [SerializeField] GameObject _hat;

    [SerializeField] GameObject _flower1;
    [SerializeField] GameObject _flower2;
    [SerializeField] GameObject _flower3;

    //--->

    [SerializeField] GameObject _a1;
    [SerializeField] GameObject _b2;
    [SerializeField] GameObject _c3;

    [SerializeField] GameObject _atb;
    [SerializeField] GameObject _bh;
    [SerializeField] GameObject _cs;

    SpriteRenderer _a1Sprite;
    SpriteRenderer _b2Sprite;
    SpriteRenderer _c3Sprite;

    SpriteRenderer _atbSprite;
    SpriteRenderer _bhSprite;
    SpriteRenderer _csSprite;


    [SerializeField] GameObject _allInformation;
    public Transform _Information;

    [SerializeField] GameObject _WindowWarning;




    [SerializeField] private Camera maincamera;

    [SerializeField] GameObject _barF;

    [SerializeField] GameObject _pill1;
    [SerializeField] GameObject _pill2;
    [SerializeField] GameObject _pill3;

    [SerializeField] GameObject _TealE;
    [SerializeField] GameObject _PurpleE;
    [SerializeField] GameObject _GreenE;

    [SerializeField] GameObject _shine1;
    [SerializeField] GameObject _shine2;
    [SerializeField] GameObject _shine3;

    [SerializeField] GameObject _hand;

    [SerializeField] GameObject _darkness;


    [SerializeField] GameObject startObjects;
    private bool hasStarted;



    public float freezeAtYScale = 5f;     // manipulate at random
    private bool isFrozen = false;

    public Transform barF;


    public float scaleSen = 0.01f;
    public float minY = 0.1f;
    public float maxY = 10f;

    private float lastMouseX;


    public Transform _camera;
    Vector3 camOriginalPos;

    void Start()
    {
        Day = 1;
        hasStarted = false;
        SetSpriteByIndex(SpriteChoices.Hands, 0);
        // ProgressionProgress = 30;
    }



    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.B) && startObjects.activeSelf)
        {
            startObjects.SetActive(false);
            hasStarted = true;
        }

        if (hasStarted == true)
        {
            startObjects.SetActive(false);
        }

        if (Day == 1)
        {
            SetSpriteByIndex(SpriteChoices.darkness, 0);
        }

        if (Day == 2)
        {
            SetSpriteByIndex(SpriteChoices.darkness, 1);
        }

        if (Day == 3)
        {
            SetSpriteByIndex(SpriteChoices.darkness, 2);
        }

        if (Day == 4)
        {
            SetSpriteByIndex(SpriteChoices.darkness, 3);
        }

        if (Day == 5)
        {
            SetSpriteByIndex(SpriteChoices.darkness, 4);
        }









        //start/opening should just be a static PNG that says (press b to start)




        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        int _greenPillMonAmount = greenPillCounterMon;
        int _greenPillTueAmount = greenPillCounterTue;
        int _greenPillWedAmount = greenPillCounterWed;
        int _greenPillThurAmount = greenPillCounterThur;
        int _greenPillFriAmount = greenPillCounterFri;
        int _greenPillSatAmount = greenPillCounterSat;
        int _greenPillSunAmount = greenPillCounterSun;

        int _tealPillMonAmount = tealPillCounterMon;
        int _tealPillTueAmount = tealPillCounterTue;
        int _tealPillWedAmount = tealPillCounterWed;
        int _tealPillThurAmount = tealPillCounterThur;
        int _tealPillFriAmount = tealPillCounterFri;
        int _tealPillSatAmount = tealPillCounterSat;
        int _tealPillSunAmount = tealPillCounterSun;

        int _purplePillMonAmount = purplePillCounterMon;
        int _purplePillTueAmount = purplePillCounterTue;
        int _purplePillWedAmount = purplePillCounterWed;
        int _purplePillThurAmount = purplePillCounterThur;
        int _purplePillFriAmount = purplePillCounterFri;
        int _purplePillSatAmount = purplePillCounterSat;
        int _purplePillSunAmount = purplePillCounterSun;






        //monPillThingy
        //greens
        if (_greenPillMonAmount == 1)
        {
            greenPillMon1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_greenPillMonAmount == 2)
        {
            greenPillMon1.GetComponent<SpriteRenderer>().enabled = true;
            greenPillMon2.GetComponent<SpriteRenderer>().enabled = true;
        }


        //teals
        if (_tealPillMonAmount == 1)
        {
            tealPillMon1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillMonAmount == 2)
        {
            tealPillMon1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillMon2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillMonAmount == 3)
        {
            tealPillMon1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillMon2.GetComponent<SpriteRenderer>().enabled = true;
            tealPillMon3.GetComponent<SpriteRenderer>().enabled = true;
        }


        //Purples
        if (_purplePillMonAmount == 1)
        {
            purplePillMon1.GetComponent<SpriteRenderer>().enabled = true;
        }







        //tuePillThingy
        //greens
        if (_greenPillTueAmount == 1)
        {
            greenPillTue1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_greenPillTueAmount == 2)
        {
            greenPillTue1.GetComponent<SpriteRenderer>().enabled = true;
            greenPillTue2.GetComponent<SpriteRenderer>().enabled = true;
        }

        //teals
        if (_tealPillTueAmount == 1)
        {
            tealPillTue1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillTueAmount == 2)
        {
            tealPillTue1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillTue2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillTueAmount == 3)
        {
            tealPillTue1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillTue2.GetComponent<SpriteRenderer>().enabled = true;
            tealPillTue3.GetComponent<SpriteRenderer>().enabled = true;
        }

        //Purples
        if (_purplePillTueAmount == 1)
        {
            purplePillTue1.GetComponent<SpriteRenderer>().enabled = true;
        }







        //wedPillThingy
        //greens
        if (_greenPillWedAmount == 1)
        {
            greenPillWed1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_greenPillWedAmount == 2)
        {
            greenPillWed1.GetComponent<SpriteRenderer>().enabled = true;
            greenPillWed2.GetComponent<SpriteRenderer>().enabled = true;
        }

        //teals
        if (_tealPillWedAmount == 1)
        {
            tealPillWed1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillWedAmount == 2)
        {
            tealPillWed1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillWed2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillWedAmount == 3)
        {
            tealPillWed1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillWed2.GetComponent<SpriteRenderer>().enabled = true;
            tealPillWed3.GetComponent<SpriteRenderer>().enabled = true;
        }

        //Purples
        if (_purplePillWedAmount == 1)
        {
            purplePillWed1.GetComponent<SpriteRenderer>().enabled = true;
        }







        //thurPillThingy
        //greens
        if (_greenPillThurAmount == 1)
        {
            greenPillThur1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_greenPillThurAmount == 2)
        {
            greenPillThur1.GetComponent<SpriteRenderer>().enabled = true;
            greenPillThur2.GetComponent<SpriteRenderer>().enabled = true;
        }

        //teals
        if (_tealPillThurAmount == 1)
        {
            tealPillThur1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillThurAmount == 2)
        {
            tealPillThur1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillThur2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillThurAmount == 3)
        {
            tealPillThur1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillThur2.GetComponent<SpriteRenderer>().enabled = true;
            tealPillThur3.GetComponent<SpriteRenderer>().enabled = true;
        }

        //Purples
        if (_purplePillThurAmount == 1)
        {
            purplePillThur1.GetComponent<SpriteRenderer>().enabled = true;
        }






        //friPillThingy
        //greens
        if (_greenPillFriAmount == 1)
        {
            greenPillFri1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_greenPillFriAmount == 2)
        {
            greenPillFri1.GetComponent<SpriteRenderer>().enabled = true;
            greenPillFri2.GetComponent<SpriteRenderer>().enabled = true;
        }

        //teals
        if (_tealPillFriAmount == 1)
        {
            tealPillFri1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillFriAmount == 2)
        {
            tealPillFri1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillFri2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillFriAmount == 3)
        {
            tealPillFri1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillFri2.GetComponent<SpriteRenderer>().enabled = true;
            tealPillFri3.GetComponent<SpriteRenderer>().enabled = true;
        }

        //Purples
        if (_purplePillFriAmount == 1)
        {
            purplePillFri1.GetComponent<SpriteRenderer>().enabled = true;
        }






        //satPillThingy
        //greens
        if (_greenPillSatAmount == 1)
        {
            greenPillSat1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_greenPillSatAmount == 2)
        {
            greenPillSat1.GetComponent<SpriteRenderer>().enabled = true;
            greenPillSat2.GetComponent<SpriteRenderer>().enabled = true;
        }

        //teals
        if (_tealPillSatAmount == 1)
        {
            tealPillSat1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillSatAmount == 2)
        {
            tealPillSat1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillSat2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillSatAmount == 3)
        {
            tealPillSat1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillSat2.GetComponent<SpriteRenderer>().enabled = true;
            tealPillSat3.GetComponent<SpriteRenderer>().enabled = true;
        }

        //Purples
        if (_purplePillSatAmount == 1)
        {
            purplePillSat1.GetComponent<SpriteRenderer>().enabled = true;
        }






        //sunPillThingy
        //greens
        if (_greenPillSunAmount == 1)
        {
            greenPillSun1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_greenPillSunAmount == 2)
        {
            greenPillSun1.GetComponent<SpriteRenderer>().enabled = true;
            greenPillSun2.GetComponent<SpriteRenderer>().enabled = true;
        }

        //teals
        if (_tealPillSunAmount == 1)
        {
            tealPillSun1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillSunAmount == 2)
        {
            tealPillSun1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillSun2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (_tealPillSunAmount == 3)
        {
            tealPillSun1.GetComponent<SpriteRenderer>().enabled = true;
            tealPillSun2.GetComponent<SpriteRenderer>().enabled = true;
            tealPillSun3.GetComponent<SpriteRenderer>().enabled = true;
        }

        //Purples
        if (_purplePillSunAmount == 1)
        {
            purplePillSun1.GetComponent<SpriteRenderer>().enabled = true;
        }














        //debounce these

        if (IsTouchingNextDayButton == true && Day == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            if (hasProgressedWin == true && hasProgressedRad == true && hasProgressedPill == true)
            {
                Day = 2;
                ResetProgression();
            }
        }


        if (IsTouchingNextDayButton == true && Day == 2 && Input.GetKeyDown(KeyCode.Space))
        {
            if (hasProgressedWin == true && hasProgressedRad == true && hasProgressedPill == true)
            {
                Day = 3;
                ResetProgression();
            }

        }


        if (IsTouchingNextDayButton == true && Day == 3 && Input.GetKeyDown(KeyCode.Space))
        {
            if (hasProgressedWin == true && hasProgressedRad == true && hasProgressedPill == true)
            {
                Day = 4;
                ResetProgression();
            }
        }


        if (IsTouchingNextDayButton == true && Day == 4 && Input.GetKeyDown(KeyCode.Space))
        {
            if (hasProgressedWin == true && hasProgressedRad == true && hasProgressedPill == true)
            {
                Day = 5;
                ResetProgression();
            }
        }


        if (IsTouchingNextDayButton == true && Day == 5 && Input.GetKeyDown(KeyCode.Space))
        {
            if (hasProgressedWin == true && hasProgressedRad == true && hasProgressedPill == true)
            {
                Day = 6;
                ResetProgression();
            }
        }




        if (Day == 6)
        {
            //end screen and thank you + infomation
        }















        bool IsValid(GameObject obj)
        {
            return obj != null && !obj.Equals(null);
        }




        Rigidbody2D rb = GetComponent<Rigidbody2D>();




        if (RadioTutorial == true)
        {
            //dispay scene and momentarily lock hand position until clicked though presenation
        }

        if (WindowTutorial == true)
        {
            //dispay scene and momentarily lock hand position until clicked though presenation
        }

        if (PillTutorial == true)
        {
            //dispay scene and momentarily lock hand position until clicked though presenation
        }

        if (SampleSceneTutorial == true)
        {
            //dispay scene and momentarily lock hand position until clicked though presenation
        }






        //-------------------------------Hand_Switching_+_All_Days------------------------------------------------------

        if (Day == 1)
        {


            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("CLICKED");
            }



            if (IsCurrentSprite(SpriteChoices.Hands, 0))
            {

                //probably will need to give it something to do if it is touching multiple at a time. maybe = if everythig else is false then -
                _TealE.SetActive(false);
                _GreenE.SetActive(false);
                _PurpleE.SetActive(false);

                if (isInTealPillTrigger == true)
                {
                    //this here just if I want nothing there at all ->
                    // collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _TealE.SetActive(true);
                        _pill2.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 2);

                    }
                }

                if (isInGreenPillTrigger == true)
                {

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _GreenE.SetActive(true);
                        _pill1.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 1);

                    }
                }

                if (isInPurplePillTrigger == true)
                {

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _PurpleE.SetActive(true);
                        _pill3.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 3);

                    }
                }

            }


            if (IsCurrentSprite(SpriteChoices.Hands, 2))
            {
                if (isInTealPillEmptyTrigger == true)
                {
                    //this here just if I want nothing there at all ->
                    // collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _TealE.SetActive(false);
                        _pill2.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 0);

                    }
                }
            }

            if (IsCurrentSprite(SpriteChoices.Hands, 1))
            {
                if (isInGreenPillEmptyTrigger == true)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _GreenE.SetActive(false);
                        _pill1.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 0);

                    }
                }
            }

            if (IsCurrentSprite(SpriteChoices.Hands, 3))
            {
                if (isInPurplePillEmptyTrigger == true)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _PurpleE.SetActive(false);
                        _pill3.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 0);

                    }
                }

            }
        }

        //-----------------------------------

        //4-netrual 5-green 6-teal 7-purple
        if (Day == 2 || Day == 3)
        {
            if (IsCurrentSprite(SpriteChoices.Hands, 0) || IsCurrentSprite(SpriteChoices.Hands, 1) || IsCurrentSprite(SpriteChoices.Hands, 2) || IsCurrentSprite(SpriteChoices.Hands, 3))
            {
                SetSpriteByIndex(SpriteChoices.Hands, 4);
            }


            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("CLICKED");
            }



            if (IsCurrentSprite(SpriteChoices.Hands, 4))
            {

                //probably will need to give it something to do if it is touching multiple at a time. maybe = if everythig else is false then -
                _TealE.SetActive(false);
                _GreenE.SetActive(false);
                _PurpleE.SetActive(false);

                if (isInTealPillTrigger == true)
                {
                    //this here just if I want nothing there at all ->
                    // collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _TealE.SetActive(true);
                        _pill2.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 6);

                    }
                }

                if (isInGreenPillTrigger == true)
                {

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _GreenE.SetActive(true);
                        _pill1.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 5);

                    }
                }

                if (isInPurplePillTrigger == true)
                {

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _PurpleE.SetActive(true);
                        _pill3.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 7);

                    }
                }

            }


            if (IsCurrentSprite(SpriteChoices.Hands, 6))
            {
                if (isInTealPillEmptyTrigger == true)
                {
                    //this here just if I want nothing there at all ->
                    // collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _TealE.SetActive(false);
                        _pill2.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 4);

                    }
                }
            }

            if (IsCurrentSprite(SpriteChoices.Hands, 5))
            {
                if (isInGreenPillEmptyTrigger == true)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _GreenE.SetActive(false);
                        _pill1.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 4);

                    }
                }
            }

            if (IsCurrentSprite(SpriteChoices.Hands, 7))
            {
                if (isInPurplePillEmptyTrigger == true)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _PurpleE.SetActive(false);
                        _pill3.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 4);

                    }
                }

            }

        }

        //It REALLY doesn't like when your index has multiples pieces given to the same sprite so either keep it like this, or make a different sprite


        //12-netrual 13-green 14-teal 15-purple
        if (Day == 4)
        {

            //if (IsCurrentSprite(SpriteChoices.Hands, 8))
            // {
            //     SetSpriteByIndex(SpriteChoices.Hands, 12);
            // }



            if (IsCurrentSprite(SpriteChoices.Hands, 4) || IsCurrentSprite(SpriteChoices.Hands, 5) || IsCurrentSprite(SpriteChoices.Hands, 6) || IsCurrentSprite(SpriteChoices.Hands, 7))
            {
                SetSpriteByIndex(SpriteChoices.Hands, 12);
            }


            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("CLICKED");
            }




            if (IsCurrentSprite(SpriteChoices.Hands, 12))
            {

                //probably will need to give it something to do if it is touching multiple at a time. maybe = if everythig else is false then -
                _TealE.SetActive(false);
                _GreenE.SetActive(false);
                _PurpleE.SetActive(false);

                if (isInTealPillTrigger == true)
                {
                    //this here just if I want nothing there at all ->
                    // collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _TealE.SetActive(true);
                        _pill2.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 14);

                    }
                }

                if (isInGreenPillTrigger == true)
                {

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _GreenE.SetActive(true);
                        _pill1.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 13);

                    }
                }

                if (isInPurplePillTrigger == true)
                {

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _PurpleE.SetActive(true);
                        _pill3.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 15);

                    }
                }

            }


            if (IsCurrentSprite(SpriteChoices.Hands, 14))
            {
                if (isInTealPillEmptyTrigger == true)
                {
                    //this here just if I want nothing there at all ->
                    // collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _TealE.SetActive(false);
                        _pill2.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 12);

                    }
                }
            }

            if (IsCurrentSprite(SpriteChoices.Hands, 13))
            {
                if (isInGreenPillEmptyTrigger == true)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _GreenE.SetActive(false);
                        _pill1.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 12);

                    }
                }
            }

            if (IsCurrentSprite(SpriteChoices.Hands, 15))
            {
                if (isInPurplePillEmptyTrigger == true)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _PurpleE.SetActive(false);
                        _pill3.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 12);

                    }
                }

            }
        }




        //16-netrual 17-green 18-teal 19-purple
        if (Day == 5)
        {

            if (IsCurrentSprite(SpriteChoices.Hands, 12) || IsCurrentSprite(SpriteChoices.Hands, 13) || IsCurrentSprite(SpriteChoices.Hands, 14) || IsCurrentSprite(SpriteChoices.Hands, 15))
            {
                SetSpriteByIndex(SpriteChoices.Hands, 16);
            }


            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("CLICKED");
            }




            if (IsCurrentSprite(SpriteChoices.Hands, 16))
            {

                //probably will need to give it something to do if it is touching multiple at a time. maybe = if everythig else is false then -
                _TealE.SetActive(false);
                _GreenE.SetActive(false);
                _PurpleE.SetActive(false);

                if (isInTealPillTrigger == true)
                {
                    //this here just if I want nothing there at all ->
                    // collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _TealE.SetActive(true);
                        _pill2.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 18);

                    }
                }

                if (isInGreenPillTrigger == true)
                {

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _GreenE.SetActive(true);
                        _pill1.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 17);

                    }
                }

                if (isInPurplePillTrigger == true)
                {

                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _PurpleE.SetActive(true);
                        _pill3.SetActive(false);
                        SetSpriteByIndex(SpriteChoices.Hands, 19);

                    }
                }

            }


            if (IsCurrentSprite(SpriteChoices.Hands, 18))
            {
                if (isInTealPillEmptyTrigger == true)
                {
                    //this here just if I want nothing there at all ->
                    // collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _TealE.SetActive(false);
                        _pill2.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 16);

                    }
                }
            }

            if (IsCurrentSprite(SpriteChoices.Hands, 17))
            {
                if (isInGreenPillEmptyTrigger == true)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _GreenE.SetActive(false);
                        _pill1.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 16);

                    }
                }
            }

            if (IsCurrentSprite(SpriteChoices.Hands, 19))
            {
                if (isInPurplePillEmptyTrigger == true)
                {
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        _PurpleE.SetActive(false);
                        _pill3.SetActive(true);
                        SetSpriteByIndex(SpriteChoices.Hands, 16);

                    }
                }

            }
        }






        //SceneSwitching-------------------------------------------------------->

        if (isInRadioTrigger == true)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("RadioScene", LoadSceneMode.Single);

            }


        }

        if (isInWindowTrigger == true)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 0) || IsCurrentSprite(SpriteChoices.Hands, 4) || IsCurrentSprite(SpriteChoices.Hands, 8) || IsCurrentSprite(SpriteChoices.Hands, 12) || IsCurrentSprite(SpriteChoices.Hands, 16))
                {
                    SceneManager.LoadScene("WindowScene", LoadSceneMode.Single);
                }
                else
                {
                    //warning to clear hand appears

                    _WindowWarning.GetComponent<SpriteRenderer>().enabled = true;
                }
            }


        }

        if (isInPillThingyTrigger == true)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("pillOrganizerScene", LoadSceneMode.Single);

            }


        }



        if (isInRadioEmptyTrigger == true)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);



            }


        }

        if (isInWindowEmptyTrigger == true)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {

                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

                if (Day == 1)
                {
                    SetSpriteByIndex(SpriteChoices.Hands, 0);
                }

                if (Day == 2)
                {
                    SetSpriteByIndex(SpriteChoices.Hands, 4);
                }

                if (Day == 3)
                {
                    SetSpriteByIndex(SpriteChoices.Hands, 8);
                }

                if (Day == 4)
                {
                    SetSpriteByIndex(SpriteChoices.Hands, 12);
                }

                if (Day == 5)
                {
                    SetSpriteByIndex(SpriteChoices.Hands, 16);
                }

            }


        }

        if (isInPillThingyEmptyTrigger == true)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);




            }


        }

        //-----------------------------------------------------------------------------------
        //WINDOW_SCENE_QUESTIONS_AND_STUFF---------------------------------------------------
        _a1Sprite = _a1.GetComponent<SpriteRenderer>();
        _b2Sprite = _b2.GetComponent<SpriteRenderer>();
        _c3Sprite = _c3.GetComponent<SpriteRenderer>();
        _atbSprite = _atb.GetComponent<SpriteRenderer>();
        _bhSprite = _bh.GetComponent<SpriteRenderer>();
        _csSprite = _cs.GetComponent<SpriteRenderer>();


        if (Day == 1)
        {
            _flower1.GetComponent<SpriteRenderer>().enabled = true;
            _flower2.GetComponent<SpriteRenderer>().enabled = false;
            _flower3.GetComponent<SpriteRenderer>().enabled = false;

            _hat.GetComponent<SpriteRenderer>().enabled = false;
            _shovel.GetComponent<SpriteRenderer>().enabled = true;
            _bear.GetComponent<SpriteRenderer>().enabled = false;

            if (_isInb2Yes == true || _isInc3Yes == true || _isInbhYes == true || _isInatbYes == true)
            {
                Debug.Log("Clicked wrong button.");
                //No message or smt
            }



            if (_isIna1Yes == true && _isIncsYes == true)
            {
                hasProgressedWin = true;
                Debug.Log("Window done!");
            }



            if (Input.GetKeyDown(KeyCode.Space) && _isIna1 == true)
            {
                _a1Sprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isIna1Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInb2 == true)
            {
                _b2Sprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInb2Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInc3 == true)
            {
                _c3Sprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInc3Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInatb == true)
            {
                _atbSprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInatbYes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInbh == true)
            {
                _bhSprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInbhYes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isIncs == true)
            {
                _csSprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isIncsYes = true;
            }
        }



        if (Day == 2)
        {
            _flower1.GetComponent<SpriteRenderer>().enabled = true;
            _flower2.GetComponent<SpriteRenderer>().enabled = true;
            _flower3.GetComponent<SpriteRenderer>().enabled = false;

            _hat.GetComponent<SpriteRenderer>().enabled = true;
            _shovel.GetComponent<SpriteRenderer>().enabled = false;
            _bear.GetComponent<SpriteRenderer>().enabled = false;

            if (_isIna1Yes == true || _isInc3Yes == true || _isInatbYes == true || _isIncsYes == true)
            {
                Debug.Log("Clicked wrong button.");
                //No message or smt
            }



            if (_isInb2Yes == true && _isInbhYes == true)
            {
                hasProgressedWin = true;
                Debug.Log("Window done!");
            }



            if (Input.GetKeyDown(KeyCode.Space) && _isIna1 == true)
            {
                _a1Sprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isIna1Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInb2 == true)
            {
                _b2Sprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isInb2Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInc3 == true)
            {
                _c3Sprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInc3Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInatb == true)
            {
                _atbSprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInatbYes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInbh == true)
            {
                _bhSprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isInbhYes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isIncs == true)
            {
                _csSprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isIncsYes = true;
            }

        }

        if (Day == 3)
        {
            _flower1.GetComponent<SpriteRenderer>().enabled = true;
            _flower2.GetComponent<SpriteRenderer>().enabled = true;
            _flower3.GetComponent<SpriteRenderer>().enabled = true;

            _hat.GetComponent<SpriteRenderer>().enabled = false;
            _shovel.GetComponent<SpriteRenderer>().enabled = false;
            _bear.GetComponent<SpriteRenderer>().enabled = true;

            if (_isIna1Yes == true || _isInb2Yes == true || _isInbhYes == true || _isIncsYes == true)
            {
                Debug.Log("Clicked wrong button.");
                //No message or smt
            }



            if (_isInc3Yes == true && _isInatbYes == true)
            {
                hasProgressedWin = true;
                Debug.Log("Window done!");
            }



            if (Input.GetKeyDown(KeyCode.Space) && _isIna1 == true)
            {
                _a1Sprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isIna1Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInb2 == true)
            {
                _b2Sprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInb2Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInc3 == true)
            {
                _c3Sprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isInc3Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInatb == true)
            {
                _atbSprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isInatbYes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInbh == true)
            {
                _bhSprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInbhYes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isIncs == true)
            {
                _csSprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isIncsYes = true;
            }

        }

        if (Day == 4)
        {
            _flower1.GetComponent<SpriteRenderer>().enabled = false;
            _flower2.GetComponent<SpriteRenderer>().enabled = true;
            _flower3.GetComponent<SpriteRenderer>().enabled = true;

            _hat.GetComponent<SpriteRenderer>().enabled = true;
            _shovel.GetComponent<SpriteRenderer>().enabled = true;
            _bear.GetComponent<SpriteRenderer>().enabled = false;

            if (_isIna1Yes == true || _isInc3Yes == true || _isInatbYes == true)
            {
                Debug.Log("Clicked wrong button.");
                //No message or smt
            }



            if (_isInb2Yes == true && _isInbhYes == true && _isIncsYes == true)
            {
                hasProgressedWin = true;
                Debug.Log("Window done!");
            }



            if (Input.GetKeyDown(KeyCode.Space) && _isIna1 == true)
            {
                _a1Sprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isIna1Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInb2 == true)
            {
                _b2Sprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isInb2Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInc3 == true)
            {
                _c3Sprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInc3Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInatb == true)
            {
                _atbSprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInatbYes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInbh == true)
            {
                _bhSprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isInbhYes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isIncs == true)
            {
                _csSprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isIncsYes = true;
            }

        }


        if (Day == 5)
        {
            _flower1.GetComponent<SpriteRenderer>().enabled = false;
            _flower2.GetComponent<SpriteRenderer>().enabled = false;
            _flower3.GetComponent<SpriteRenderer>().enabled = true;

            _hat.GetComponent<SpriteRenderer>().enabled = true;
            _shovel.GetComponent<SpriteRenderer>().enabled = true;
            _bear.GetComponent<SpriteRenderer>().enabled = true;

            if (_isInb2Yes == true || _isInc3Yes == true)
            {
                Debug.Log("Clicked wrong button.");
                //No message or smt
            }



            if (_isIna1Yes == true && _isInbhYes == true && _isIncsYes == true && _isInatbYes == true)
            {
                hasProgressedWin = true;
                Debug.Log("Window done!");

            }



            if (Input.GetKeyDown(KeyCode.Space) && _isIna1 == true)
            {
                _a1Sprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isIna1Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInb2 == true)
            {
                _b2Sprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInb2Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInc3 == true)
            {
                _c3Sprite.color = new Color(46f / 255f, 45f / 255f, 43f / 255f, 1f);
                _isInc3Yes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInatb == true)
            {
                _atbSprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isInatbYes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isInbh == true)
            {
                _bhSprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isInbhYes = true;
            }
            if (Input.GetKeyDown(KeyCode.Space) && _isIncs == true)
            {
                _csSprite.color = new Color(0f / 255f, 1f, 19f / 255f, 1f);
                _isIncsYes = true;
            }

        }




        //Nob_Movement---------------------------------------------->

        if (isInNobTrigger == true && Input.GetKeyDown(KeyCode.Space))
        {
            if (IsCurrentSprite(SpriteChoices.Hands, 0) || IsCurrentSprite(SpriteChoices.Hands, 4) || IsCurrentSprite(SpriteChoices.Hands, 8) || IsCurrentSprite(SpriteChoices.Hands, 12) || IsCurrentSprite(SpriteChoices.Hands, 16))
            {
                NobInMotion = true;
                lastMouseX = Input.mousePosition.x;
                rb.constraints = RigidbodyConstraints2D.FreezeAll;
            }

        }

        if (isInNobTrigger == true && Input.GetKeyDown(KeyCode.Return))
        {
            if (IsCurrentSprite(SpriteChoices.Hands, 0) || IsCurrentSprite(SpriteChoices.Hands, 4) || IsCurrentSprite(SpriteChoices.Hands, 8) || IsCurrentSprite(SpriteChoices.Hands, 12) || IsCurrentSprite(SpriteChoices.Hands, 16))
            {
                NobInMotion = false;
                isInNobTrigger = false;
            }
            //set hand position back so it doesn't jump
        }



        if (NobInMotion == true)
        {
            float currentMouseX = Input.mousePosition.x;
            float deltaX = currentMouseX - lastMouseX;
            float scaleY = deltaX * scaleSen;
            Vector3 currentScaleNob = barF.localScale;

            currentScaleNob.y = Mathf.Clamp(currentScaleNob.y + scaleY, minY, maxY);
            barF.localScale = currentScaleNob;

            lastMouseX = currentMouseX;


            if (currentScaleNob.y >= freezeAtYScale)
            {
                currentScaleNob.y = freezeAtYScale;
                isFrozen = true;
            }

        }

      


        if (Day == 1)
        {
            _goalBar1.transform.position = new Vector3(-3.6f, 1.5f, 0);
            _goalBar2.transform.position = new Vector3(-3.6f, -0.4f, 0);

            if (_barF.transform.localScale == new Vector3(2f, 2f, 1f) || _barF.transform.localScale == new Vector3(2f, 1f, 1f))
            {
                hasProgressedRad = true;
                Debug.Log("Radio done!");
            }

            //set hand back at nob so it doesn't jump still
        }

        if (Day == 2)
        {
            _goalBar1.transform.position = new Vector3(-3.6f, 2, 0);
            _goalBar2.transform.position = new Vector3(-3.6f, -0.9f, 0);

            if (_barF.transform.localScale == new Vector3(2f, 3f, 1f) || _barF.transform.localScale == new Vector3(2f, 2.5f, 1f))
            {
                hasProgressedRad = true;
                Debug.Log("Radio done!");
            }

            //set hand back at nob so it doesn't jump still
        }

        if (Day == 3)
        {
            _goalBar1.transform.position = new Vector3(-3.6f, 3, 0);
            _goalBar2.transform.position = new Vector3(-3.6f, -1.9f, 0);

            if (_barF.transform.localScale == new Vector3(2f, 5f, 1f) || _barF.transform.localScale == new Vector3(2f, 4.5f, 1f))
            {
                hasProgressedRad = true;
                Debug.Log("Radio done!");
            }

            //set hand back at nob so it doesn't jump still
        }

        if (Day == 4)
        {
            _goalBar1.transform.position = new Vector3(-3.6f, 4, 0);
            _goalBar2.transform.position = new Vector3(-3.6f, -2.9f, 0);

            if (_barF.transform.localScale == new Vector3(2f, 7f, 1f) || _barF.transform.localScale == new Vector3(2f, 6.5f, 1f))
            {
                hasProgressedRad = true;
                Debug.Log("Radio done!");
            }

            //set hand back at nob so it doesn't jump still
        }

        if (Day == 5)
        {
            _goalBar1.transform.position = new Vector3(-3.6f, 5.6f, 0);
            _goalBar2.transform.position = new Vector3(-3.6f, -4.44f, 0);

            if (_barF.transform.localScale == new Vector3(2f, 10f, 1f) || _barF.transform.localScale == new Vector3(2f, 9.5f, 1f))
            {
                hasProgressedRad = true;
                Debug.Log("Radio done!");
            }

            //set hand back at nob so it doesn't jump still
        }



        //end of game psa info?


        //Pill_placement_in_thingy-------------------------------------------------------------------------------------------------

        //okay, - day 1 = pill for hearing every other day
        //        day 2 = pill for hearing every day + shaking every other day
        //        day 3 = pill for hearing every day (twice on wednesday) + shaking everyday + sight every other day
        //        day 4 = pill for hearing one and then two + shaking twice a day + sight everyday
        //        day 5 = pill for hearing twice a day + shaking three times a day + sight everyday

        //   make sure you make another index for these instructions to pop up!

        //1=green(hearing) / 2=teal(shaking) / 3=purple(sight)
        //(new) 1=green(shaking) / 2=teal(hearing) / 3=purple(sight)




        if (Input.GetKeyDown(KeyCode.Space) && pressedrestartButton == true && pleaserRestart == true)
        {
            ResetAllPills();
        }

        if (Day == 1)
        {


            //display correct instructions


            if (greenPillCounterMon == 1 && greenPillCounterFri == 1 && greenPillCounterWed == 1)
            {
                pleaserRestart = false;

                hasProgressedPill = true;
                Debug.Log("progressionProgress - 2");
            }
            else
            {
                pleaserRestart = true;

            }





            // === MONDAY ===
            if (isInMonTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 1) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterMon == 0 && IsValid(greenPillMon1))
                    {
                        greenPillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterMon++;
                    }
                    else if (greenPillCounterMon == 1 && IsValid(greenPillMon2))
                    {
                        greenPillMon2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterMon++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 2) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterMon == 0 && IsValid(tealPillMon1))
                    {
                        tealPillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                    else if (tealPillCounterMon == 1 && IsValid(tealPillMon2))
                    {
                        tealPillMon2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                    else if (tealPillCounterMon == 2 && IsValid(tealPillMon3))
                    {
                        tealPillMon3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 3) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterMon == 0 && IsValid(purplePillMon1))
                    {
                        purplePillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterMon++;
                    }
                }
            }

            // === TUESDAY ===
            if (isInTueTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 1) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterTue == 0 && IsValid(greenPillTue1))
                    {
                        greenPillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterTue++;
                    }
                    else if (greenPillCounterTue == 1 && IsValid(greenPillTue2))
                    {
                        greenPillTue2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterTue++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 2) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterTue == 0 && IsValid(tealPillTue1))
                    {
                        tealPillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                    else if (tealPillCounterTue == 1 && IsValid(tealPillTue2))
                    {
                        tealPillTue2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                    else if (tealPillCounterTue == 2 && IsValid(tealPillTue3))
                    {
                        tealPillTue3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 3) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterTue == 0 && IsValid(purplePillTue1))
                    {
                        purplePillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterTue++;
                    }
                }
            }

            // === WEDNESDAY ===
            if (isInWedTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 1) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterWed == 0 && IsValid(greenPillWed1))
                    {
                        greenPillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterWed++;
                    }
                    else if (greenPillCounterWed == 1 && IsValid(greenPillWed2))
                    {
                        greenPillWed2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterWed++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 2) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterWed == 0 && IsValid(tealPillWed1))
                    {
                        tealPillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                    else if (tealPillCounterWed == 1 && IsValid(tealPillWed2))
                    {
                        tealPillWed2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                    else if (tealPillCounterWed == 2 && IsValid(tealPillWed3))
                    {
                        tealPillWed3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 3) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterWed == 0 && IsValid(purplePillWed1))
                    {
                        purplePillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterWed++;
                    }
                }
            }

            // === THURSDAY ===
            if (isInThurTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 1) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterThur == 0 && IsValid(greenPillThur1))
                    {
                        greenPillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterThur++;
                    }
                    else if (greenPillCounterThur == 1 && IsValid(greenPillThur2))
                    {
                        greenPillThur2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterThur++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 2) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterThur == 0 && IsValid(tealPillThur1))
                    {
                        tealPillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                    else if (tealPillCounterThur == 1 && IsValid(tealPillThur2))
                    {
                        tealPillThur2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                    else if (tealPillCounterThur == 2 && IsValid(tealPillThur3))
                    {
                        tealPillThur3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 3) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterThur == 0 && IsValid(purplePillThur1))
                    {
                        purplePillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterThur++;
                    }
                }
            }

            // === FRIDAY ===
            if (isInFriTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 1) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterFri == 0 && IsValid(greenPillFri1))
                    {
                        greenPillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterFri++;
                    }
                    else if (greenPillCounterFri == 1 && IsValid(greenPillFri2))
                    {
                        greenPillFri2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterFri++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 2) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterFri == 0 && IsValid(tealPillFri1))
                    {
                        tealPillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                    else if (tealPillCounterFri == 1 && IsValid(tealPillFri2))
                    {
                        tealPillFri2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                    else if (tealPillCounterFri == 2 && IsValid(tealPillFri3))
                    {
                        tealPillFri3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 3) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterFri == 0 && IsValid(purplePillFri1))
                    {
                        purplePillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterFri++;
                    }
                }
            }

            // === SATURDAY ===
            if (isInSatTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 1) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterSat == 0 && IsValid(greenPillSat1))
                    {
                        greenPillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSat++;
                    }
                    else if (greenPillCounterSat == 1 && IsValid(greenPillSat2))
                    {
                        greenPillSat2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSat++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 2) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterSat == 0 && IsValid(tealPillSat1))
                    {
                        tealPillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                    else if (tealPillCounterSat == 1 && IsValid(tealPillSat2))
                    {
                        tealPillSat2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                    else if (tealPillCounterSat == 2 && IsValid(tealPillSat3))
                    {
                        tealPillSat3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 3) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterSat == 0 && IsValid(purplePillSat1))
                    {
                        purplePillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterSat++;
                    }
                }
            }


            //---------------------------------------------------------------------------------
            // === SUNDAY ===
            if (isInSunTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 1) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterSun == 0 && IsValid(greenPillSun1))
                    {
                        greenPillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSun++;
                    }
                    else if (greenPillCounterSun == 1 && IsValid(greenPillSun2))
                    {
                        greenPillSun2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSun++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 2) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterSun == 0 && IsValid(tealPillSun1))
                    {
                        tealPillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                    else if (tealPillCounterSun == 1 && IsValid(tealPillSun2))
                    {
                        tealPillSun2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                    else if (tealPillCounterSun == 2 && IsValid(tealPillSun3))
                    {
                        tealPillSun3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                }
                if (IsCurrentSprite(SpriteChoices.Hands, 3) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterSun == 0 && IsValid(purplePillSun1))
                    {
                        purplePillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterSun++;
                    }

                }
            }


        }








        if (Day == 2)
        {
            //display correct instructions





            if (greenPillCounterMon == 1 && greenPillCounterTue == 1 && greenPillCounterWed == 1 && greenPillCounterThur == 1 && greenPillCounterFri == 1 && greenPillCounterSat == 1 && greenPillCounterSun == 1 && tealPillCounterMon == 1 && tealPillCounterFri == 1 && tealPillCounterWed == 1)
            {
                pleaserRestart = false;
                hasProgressedPill = true;
                Debug.Log("progressionProgress - 2");
            }
            else
            {
                pleaserRestart = true;

            }







            // === MONDAY ===
            if (isInMonTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 5) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterMon == 0 && IsValid(greenPillMon1))
                    {
                        greenPillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterMon++;
                    }
                    else if (greenPillCounterMon == 1 && IsValid(greenPillMon2))
                    {
                        greenPillMon2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterMon++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 6) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterMon == 0 && IsValid(tealPillMon1))
                    {
                        tealPillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                    else if (tealPillCounterMon == 1 && IsValid(tealPillMon2))
                    {
                        tealPillMon2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                    else if (tealPillCounterMon == 2 && IsValid(tealPillMon3))
                    {
                        tealPillMon3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 7) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterMon == 0 && IsValid(purplePillMon1))
                    {
                        purplePillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterMon++;
                    }
                }
            }

            // === TUESDAY ===
            if (isInTueTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 5) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterTue == 0 && IsValid(greenPillTue1))
                    {
                        greenPillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterTue++;
                    }
                    else if (greenPillCounterTue == 1 && IsValid(greenPillTue2))
                    {
                        greenPillTue2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterTue++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 6) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterTue == 0 && IsValid(tealPillTue1))
                    {
                        tealPillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                    else if (tealPillCounterTue == 1 && IsValid(tealPillTue2))
                    {
                        tealPillTue2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                    else if (tealPillCounterTue == 2 && IsValid(tealPillTue3))
                    {
                        tealPillTue3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 7) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterTue == 0 && IsValid(purplePillTue1))
                    {
                        purplePillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterTue++;
                    }
                }
            }

            // === WEDNESDAY ===
            if (isInWedTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 5) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterWed == 0 && IsValid(greenPillWed1))
                    {
                        greenPillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterWed++;
                    }
                    else if (greenPillCounterWed == 1 && IsValid(greenPillWed2))
                    {
                        greenPillWed2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterWed++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 6) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterWed == 0 && IsValid(tealPillWed1))
                    {
                        tealPillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                    else if (tealPillCounterWed == 1 && IsValid(tealPillWed2))
                    {
                        tealPillWed2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                    else if (tealPillCounterWed == 2 && IsValid(tealPillWed3))
                    {
                        tealPillWed3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 7) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterWed == 0 && IsValid(purplePillWed1))
                    {
                        purplePillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterWed++;
                    }
                }
            }

            // === THURSDAY ===
            if (isInThurTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 5) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterThur == 0 && IsValid(greenPillThur1))
                    {
                        greenPillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterThur++;
                    }
                    else if (greenPillCounterThur == 1 && IsValid(greenPillThur2))
                    {
                        greenPillThur2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterThur++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 6) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterThur == 0 && IsValid(tealPillThur1))
                    {
                        tealPillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                    else if (tealPillCounterThur == 1 && IsValid(tealPillThur2))
                    {
                        tealPillThur2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                    else if (tealPillCounterThur == 2 && IsValid(tealPillThur3))
                    {
                        tealPillThur3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 7) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterThur == 0 && IsValid(purplePillThur1))
                    {
                        purplePillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterThur++;
                    }
                }
            }

            // === FRIDAY ===
            if (isInFriTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 5) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterFri == 0 && IsValid(greenPillFri1))
                    {
                        greenPillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterFri++;
                    }
                    else if (greenPillCounterFri == 1 && IsValid(greenPillFri2))
                    {
                        greenPillFri2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterFri++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 6) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterFri == 0 && IsValid(tealPillFri1))
                    {
                        tealPillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                    else if (tealPillCounterFri == 1 && IsValid(tealPillFri2))
                    {
                        tealPillFri2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                    else if (tealPillCounterFri == 2 && IsValid(tealPillFri3))
                    {
                        tealPillFri3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 7) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterFri == 0 && IsValid(purplePillFri1))
                    {
                        purplePillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterFri++;
                    }
                }
            }

            // === SATURDAY ===
            if (isInSatTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 5) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterSat == 0 && IsValid(greenPillSat1))
                    {
                        greenPillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSat++;
                    }
                    else if (greenPillCounterSat == 1 && IsValid(greenPillSat2))
                    {
                        greenPillSat2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSat++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 6) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterSat == 0 && IsValid(tealPillSat1))
                    {
                        tealPillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                    else if (tealPillCounterSat == 1 && IsValid(tealPillSat2))
                    {
                        tealPillSat2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                    else if (tealPillCounterSat == 2 && IsValid(tealPillSat3))
                    {
                        tealPillSat3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 7) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterSat == 0 && IsValid(purplePillSat1))
                    {
                        purplePillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterSat++;
                    }
                }
            }

            // === SUNDAY ===
            if (isInSunTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 5) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterSun == 0 && IsValid(greenPillSun1))
                    {
                        greenPillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSun++;
                    }
                    else if (greenPillCounterSun == 1 && IsValid(greenPillSun2))
                    {
                        greenPillSun2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSun++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 6) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterSun == 0 && IsValid(tealPillSun1))
                    {
                        tealPillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                    else if (tealPillCounterSun == 1 && IsValid(tealPillSun2))
                    {
                        tealPillSun2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                    else if (tealPillCounterSun == 2 && IsValid(tealPillSun3))
                    {
                        tealPillSun3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 7) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterSun == 0 && IsValid(purplePillSun1))
                    {
                        purplePillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterSun++;
                    }
                }
            }


        }






        if (Day == 3)
        {
            //display correct instructions



            if (greenPillCounterMon == 1 && greenPillCounterTue == 1 && greenPillCounterWed == 2 && greenPillCounterThur == 1 && greenPillCounterFri == 1 && greenPillCounterSat == 1 && greenPillCounterSun == 1 && tealPillCounterMon == 1 && tealPillCounterTue == 1 && tealPillCounterWed == 2 && tealPillCounterThur == 1 && tealPillCounterFri == 1 && tealPillCounterSat == 1 && tealPillCounterSun == 1 && purplePillCounterMon == 1 && tealPillCounterWed == 1 && tealPillCounterFri == 1)
            {
                pleaserRestart = false;
                hasProgressedPill = true;
                Debug.Log("progressionProgress - 2");
            }
            else
            {
                pleaserRestart = true;

            }







            // === MONDAY ===
            if (isInMonTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 9) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterMon == 0 && IsValid(greenPillMon1))
                    {
                        greenPillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterMon++;
                    }
                    else if (greenPillCounterMon == 1 && IsValid(greenPillMon2))
                    {
                        greenPillMon2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterMon++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 10) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterMon == 0 && IsValid(tealPillMon1))
                    {
                        tealPillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                    else if (tealPillCounterMon == 1 && IsValid(tealPillMon2))
                    {
                        tealPillMon2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                    else if (tealPillCounterMon == 2 && IsValid(tealPillMon3))
                    {
                        tealPillMon3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 11) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterMon == 0 && IsValid(purplePillMon1))
                    {
                        purplePillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterMon++;
                    }
                }
            }

            // === TUESDAY ===
            if (isInTueTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 9) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterTue == 0 && IsValid(greenPillTue1))
                    {
                        greenPillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterTue++;
                    }
                    else if (greenPillCounterTue == 1 && IsValid(greenPillTue2))
                    {
                        greenPillTue2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterTue++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 10) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterTue == 0 && IsValid(tealPillTue1))
                    {
                        tealPillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                    else if (tealPillCounterTue == 1 && IsValid(tealPillTue2))
                    {
                        tealPillTue2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                    else if (tealPillCounterTue == 2 && IsValid(tealPillTue3))
                    {
                        tealPillTue3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 11) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterTue == 0 && IsValid(purplePillTue1))
                    {
                        purplePillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterTue++;
                    }
                }
            }

            // === WEDNESDAY ===
            if (isInWedTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 9) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterWed == 0 && IsValid(greenPillWed1))
                    {
                        greenPillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterWed++;
                    }
                    else if (greenPillCounterWed == 1 && IsValid(greenPillWed2))
                    {
                        greenPillWed2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterWed++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 10) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterWed == 0 && IsValid(tealPillWed1))
                    {
                        tealPillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                    else if (tealPillCounterWed == 1 && IsValid(tealPillWed2))
                    {
                        tealPillWed2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                    else if (tealPillCounterWed == 2 && IsValid(tealPillWed3))
                    {
                        tealPillWed3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 11) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterWed == 0 && IsValid(purplePillWed1))
                    {
                        purplePillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterWed++;
                    }
                }
            }

            // === THURSDAY ===
            if (isInThurTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 9) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterThur == 0 && IsValid(greenPillThur1))
                    {
                        greenPillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterThur++;
                    }
                    else if (greenPillCounterThur == 1 && IsValid(greenPillThur2))
                    {
                        greenPillThur2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterThur++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 10) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterThur == 0 && IsValid(tealPillThur1))
                    {
                        tealPillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                    else if (tealPillCounterThur == 1 && IsValid(tealPillThur2))
                    {
                        tealPillThur2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                    else if (tealPillCounterThur == 2 && IsValid(tealPillThur3))
                    {
                        tealPillThur3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 11) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterThur == 0 && IsValid(purplePillThur1))
                    {
                        purplePillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterThur++;
                    }
                }
            }

            // === FRIDAY ===
            if (isInFriTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 9) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterFri == 0 && IsValid(greenPillFri1))
                    {
                        greenPillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterFri++;
                    }
                    else if (greenPillCounterFri == 1 && IsValid(greenPillFri2))
                    {
                        greenPillFri2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterFri++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 10) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterFri == 0 && IsValid(tealPillFri1))
                    {
                        tealPillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                    else if (tealPillCounterFri == 1 && IsValid(tealPillFri2))
                    {
                        tealPillFri2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                    else if (tealPillCounterFri == 2 && IsValid(tealPillFri3))
                    {
                        tealPillFri3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 11) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterFri == 0 && IsValid(purplePillFri1))
                    {
                        purplePillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterFri++;
                    }
                }
            }

            // === SATURDAY ===
            if (isInSatTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 9) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterSat == 0 && IsValid(greenPillSat1))
                    {
                        greenPillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSat++;
                    }
                    else if (greenPillCounterSat == 1 && IsValid(greenPillSat2))
                    {
                        greenPillSat2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSat++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 10) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterSat == 0 && IsValid(tealPillSat1))
                    {
                        tealPillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                    else if (tealPillCounterSat == 1 && IsValid(tealPillSat2))
                    {
                        tealPillSat2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                    else if (tealPillCounterSat == 2 && IsValid(tealPillSat3))
                    {
                        tealPillSat3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 11) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterSat == 0 && IsValid(purplePillSat1))
                    {
                        purplePillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterSat++;
                    }
                }
            }

            // === SUNDAY ===
            if (isInSunTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 9) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterSun == 0 && IsValid(greenPillSun1))
                    {
                        greenPillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSun++;
                    }
                    else if (greenPillCounterSun == 1 && IsValid(greenPillSun2))
                    {
                        greenPillSun2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSun++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 10) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterSun == 0 && IsValid(tealPillSun1))
                    {
                        tealPillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                    else if (tealPillCounterSun == 1 && IsValid(tealPillSun2))
                    {
                        tealPillSun2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                    else if (tealPillCounterSun == 2 && IsValid(tealPillSun3))
                    {
                        tealPillSun3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 11) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterSun == 0 && IsValid(purplePillSun1))
                    {
                        purplePillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterSun++;
                    }
                }
            }


        }




        if (Day == 4)
        {
            //display correct instructions



            if (greenPillCounterMon == 2 && greenPillCounterTue == 1 && greenPillCounterWed == 2 && greenPillCounterThur == 1 && greenPillCounterFri == 2 && greenPillCounterSat == 1 && greenPillCounterSun == 2 && tealPillCounterMon == 2 && tealPillCounterTue == 2 && tealPillCounterWed == 2 && tealPillCounterThur == 2 && tealPillCounterFri == 2 && tealPillCounterSat == 2 && tealPillCounterSun == 2 && purplePillCounterMon == 1 && purplePillCounterTue == 1 && purplePillCounterWed == 1 && purplePillCounterSat == 1 && purplePillCounterSun == 1 && purplePillCounterThur == 1 && purplePillCounterFri == 1)
            {
                pleaserRestart = false;
                hasProgressedPill = true;
                Debug.Log("progressionProgress - 2");
            }
            else
            {
                pleaserRestart = true;

            }




            // === MONDAY ===
            if (isInMonTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 13) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterMon == 0 && IsValid(greenPillMon1))
                    {
                        greenPillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterMon++;
                    }
                    else if (greenPillCounterMon == 1 && IsValid(greenPillMon2))
                    {
                        greenPillMon2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterMon++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 14) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterMon == 0 && IsValid(tealPillMon1))
                    {
                        tealPillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                    else if (tealPillCounterMon == 1 && IsValid(tealPillMon2))
                    {
                        tealPillMon2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                    else if (tealPillCounterMon == 2 && IsValid(tealPillMon3))
                    {
                        tealPillMon3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 15) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterMon == 0 && IsValid(purplePillMon1))
                    {
                        purplePillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterMon++;
                    }
                }
            }

            // === TUESDAY ===
            if (isInTueTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 13) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterTue == 0 && IsValid(greenPillTue1))
                    {
                        greenPillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterTue++;
                    }
                    else if (greenPillCounterTue == 1 && IsValid(greenPillTue2))
                    {
                        greenPillTue2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterTue++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 14) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterTue == 0 && IsValid(tealPillTue1))
                    {
                        tealPillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                    else if (tealPillCounterTue == 1 && IsValid(tealPillTue2))
                    {
                        tealPillTue2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                    else if (tealPillCounterTue == 2 && IsValid(tealPillTue3))
                    {
                        tealPillTue3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 15) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterTue == 0 && IsValid(purplePillTue1))
                    {
                        purplePillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterTue++;
                    }
                }
            }

            // === WEDNESDAY ===
            if (isInWedTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 13) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterWed == 0 && IsValid(greenPillWed1))
                    {
                        greenPillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterWed++;
                    }
                    else if (greenPillCounterWed == 1 && IsValid(greenPillWed2))
                    {
                        greenPillWed2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterWed++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 14) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterWed == 0 && IsValid(tealPillWed1))
                    {
                        tealPillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                    else if (tealPillCounterWed == 1 && IsValid(tealPillWed2))
                    {
                        tealPillWed2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                    else if (tealPillCounterWed == 2 && IsValid(tealPillWed3))
                    {
                        tealPillWed3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 15) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterWed == 0 && IsValid(purplePillWed1))
                    {
                        purplePillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterWed++;
                    }
                }
            }

            // === THURSDAY ===
            if (isInThurTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 13) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterThur == 0 && IsValid(greenPillThur1))
                    {
                        greenPillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterThur++;
                    }
                    else if (greenPillCounterThur == 1 && IsValid(greenPillThur2))
                    {
                        greenPillThur2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterThur++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 14) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterThur == 0 && IsValid(tealPillThur1))
                    {
                        tealPillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                    else if (tealPillCounterThur == 1 && IsValid(tealPillThur2))
                    {
                        tealPillThur2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                    else if (tealPillCounterThur == 2 && IsValid(tealPillThur3))
                    {
                        tealPillThur3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 15) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterThur == 0 && IsValid(purplePillThur1))
                    {
                        purplePillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterThur++;
                    }
                }
            }

            // === FRIDAY ===
            if (isInFriTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 13) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterFri == 0 && IsValid(greenPillFri1))
                    {
                        greenPillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterFri++;
                    }
                    else if (greenPillCounterFri == 1 && IsValid(greenPillFri2))
                    {
                        greenPillFri2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterFri++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 14) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterFri == 0 && IsValid(tealPillFri1))
                    {
                        tealPillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                    else if (tealPillCounterFri == 1 && IsValid(tealPillFri2))
                    {
                        tealPillFri2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                    else if (tealPillCounterFri == 2 && IsValid(tealPillFri3))
                    {
                        tealPillFri3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 15) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterFri == 0 && IsValid(purplePillFri1))
                    {
                        purplePillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterFri++;
                    }
                }
            }

            // === SATURDAY ===
            if (isInSatTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 13) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterSat == 0 && IsValid(greenPillSat1))
                    {
                        greenPillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSat++;
                    }
                    else if (greenPillCounterSat == 1 && IsValid(greenPillSat2))
                    {
                        greenPillSat2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSat++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 14) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterSat == 0 && IsValid(tealPillSat1))
                    {
                        tealPillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                    else if (tealPillCounterSat == 1 && IsValid(tealPillSat2))
                    {
                        tealPillSat2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                    else if (tealPillCounterSat == 2 && IsValid(tealPillSat3))
                    {
                        tealPillSat3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 15) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterSat == 0 && IsValid(purplePillSat1))
                    {
                        purplePillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterSat++;
                    }
                }
            }

            // === SUNDAY ===
            if (isInSunTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 13) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterSun == 0 && IsValid(greenPillSun1))
                    {
                        greenPillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSun++;
                    }
                    else if (greenPillCounterSun == 1 && IsValid(greenPillSun2))
                    {
                        greenPillSun2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSun++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 14) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterSun == 0 && IsValid(tealPillSun1))
                    {
                        tealPillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                    else if (tealPillCounterSun == 1 && IsValid(tealPillSun2))
                    {
                        tealPillSun2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                    else if (tealPillCounterSun == 2 && IsValid(tealPillSun3))
                    {
                        tealPillSun3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 15) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterSun == 0 && IsValid(purplePillSun1))
                    {
                        purplePillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterSun++;
                    }
                }
            }
        }








        if (Day == 5)
        {
            //display correct instructions




            if (greenPillCounterMon == 2 && greenPillCounterTue == 2 && greenPillCounterWed == 2 && greenPillCounterThur == 2 && greenPillCounterFri == 2 && greenPillCounterSat == 2 && greenPillCounterSun == 2 && tealPillCounterMon == 3 && tealPillCounterTue == 3 && tealPillCounterWed == 3 && tealPillCounterThur == 3 && tealPillCounterFri == 3 && tealPillCounterSat == 3 && tealPillCounterSun == 3 && purplePillCounterMon == 1 && purplePillCounterTue == 1 && purplePillCounterWed == 1 && purplePillCounterSat == 1 && purplePillCounterSun == 1 && purplePillCounterThur == 1 && purplePillCounterFri == 1)
            {
                pleaserRestart = false;
                hasProgressedPill = true;
                Debug.Log("progressionProgress - 2");
            }
            else
            {
                pleaserRestart = true;

            }






            // === MONDAY ===
            if (isInMonTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 17) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterMon == 0 && IsValid(greenPillMon1))
                    {
                        greenPillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterMon++;
                    }
                    else if (greenPillCounterMon == 1 && IsValid(greenPillMon2))
                    {
                        greenPillMon2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterMon++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 18) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterMon == 0 && IsValid(tealPillMon1))
                    {
                        tealPillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                    else if (tealPillCounterMon == 1 && IsValid(tealPillMon2))
                    {
                        tealPillMon2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                    else if (tealPillCounterMon == 2 && IsValid(tealPillMon3))
                    {
                        tealPillMon3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterMon++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 19) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterMon == 0 && IsValid(purplePillMon1))
                    {
                        purplePillMon1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterMon++;
                    }
                }
            }

            // === TUESDAY ===
            if (isInTueTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 17) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterTue == 0 && IsValid(greenPillTue1))
                    {
                        greenPillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterTue++;
                    }
                    else if (greenPillCounterTue == 1 && IsValid(greenPillTue2))
                    {
                        greenPillTue2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterTue++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 18) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterTue == 0 && IsValid(tealPillTue1))
                    {
                        tealPillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                    else if (tealPillCounterTue == 1 && IsValid(tealPillTue2))
                    {
                        tealPillTue2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                    else if (tealPillCounterTue == 2 && IsValid(tealPillTue3))
                    {
                        tealPillTue3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterTue++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 19) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterTue == 0 && IsValid(purplePillTue1))
                    {
                        purplePillTue1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterTue++;
                    }
                }
            }

            // === WEDNESDAY ===
            if (isInWedTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 17) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterWed == 0 && IsValid(greenPillWed1))
                    {
                        greenPillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterWed++;
                    }
                    else if (greenPillCounterWed == 1 && IsValid(greenPillWed2))
                    {
                        greenPillWed2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterWed++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 18) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterWed == 0 && IsValid(tealPillWed1))
                    {
                        tealPillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                    else if (tealPillCounterWed == 1 && IsValid(tealPillWed2))
                    {
                        tealPillWed2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                    else if (tealPillCounterWed == 2 && IsValid(tealPillWed3))
                    {
                        tealPillWed3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterWed++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 19) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterWed == 0 && IsValid(purplePillWed1))
                    {
                        purplePillWed1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterWed++;
                    }
                }
            }

            // === THURSDAY ===
            if (isInThurTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 17) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterThur == 0 && IsValid(greenPillThur1))
                    {
                        greenPillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterThur++;
                    }
                    else if (greenPillCounterThur == 1 && IsValid(greenPillThur2))
                    {
                        greenPillThur2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterThur++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 18) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterThur == 0 && IsValid(tealPillThur1))
                    {
                        tealPillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                    else if (tealPillCounterThur == 1 && IsValid(tealPillThur2))
                    {
                        tealPillThur2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                    else if (tealPillCounterThur == 2 && IsValid(tealPillThur3))
                    {
                        tealPillThur3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterThur++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 19) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterThur == 0 && IsValid(purplePillThur1))
                    {
                        purplePillThur1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterThur++;
                    }
                }
            }

            // === FRIDAY ===
            if (isInFriTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 17) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterFri == 0 && IsValid(greenPillFri1))
                    {
                        greenPillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterFri++;
                    }
                    else if (greenPillCounterFri == 1 && IsValid(greenPillFri2))
                    {
                        greenPillFri2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterFri++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 18) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterFri == 0 && IsValid(tealPillFri1))
                    {
                        tealPillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                    else if (tealPillCounterFri == 1 && IsValid(tealPillFri2))
                    {
                        tealPillFri2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                    else if (tealPillCounterFri == 2 && IsValid(tealPillFri3))
                    {
                        tealPillFri3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterFri++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 19) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterFri == 0 && IsValid(purplePillFri1))
                    {
                        purplePillFri1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterFri++;
                    }
                }
            }

            // === SATURDAY ===
            if (isInSatTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 17) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterSat == 0 && IsValid(greenPillSat1))
                    {
                        greenPillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSat++;
                    }
                    else if (greenPillCounterSat == 1 && IsValid(greenPillSat2))
                    {
                        greenPillSat2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSat++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 18) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterSat == 0 && IsValid(tealPillSat1))
                    {
                        tealPillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                    else if (tealPillCounterSat == 1 && IsValid(tealPillSat2))
                    {
                        tealPillSat2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                    else if (tealPillCounterSat == 2 && IsValid(tealPillSat3))
                    {
                        tealPillSat3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSat++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 19) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterSat == 0 && IsValid(purplePillSat1))
                    {
                        purplePillSat1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterSat++;
                    }
                }
            }

            // === SUNDAY ===
            if (isInSunTrigger == true)
            {
                if (IsCurrentSprite(SpriteChoices.Hands, 17) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (greenPillCounterSun == 0 && IsValid(greenPillSun1))
                    {
                        greenPillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSun++;
                    }
                    else if (greenPillCounterSun == 1 && IsValid(greenPillSun2))
                    {
                        greenPillSun2.GetComponent<SpriteRenderer>().enabled = true;
                        greenPillCounterSun++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 18) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (tealPillCounterSun == 0 && IsValid(tealPillSun1))
                    {
                        tealPillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                    else if (tealPillCounterSun == 1 && IsValid(tealPillSun2))
                    {
                        tealPillSun2.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                    else if (tealPillCounterSun == 2 && IsValid(tealPillSun3))
                    {
                        tealPillSun3.GetComponent<SpriteRenderer>().enabled = true;
                        tealPillCounterSun++;
                    }
                }

                if (IsCurrentSprite(SpriteChoices.Hands, 19) && Input.GetKeyDown(KeyCode.Space))
                {
                    if (purplePillCounterSun == 0 && IsValid(purplePillSun1))
                    {
                        purplePillSun1.GetComponent<SpriteRenderer>().enabled = true;
                        purplePillCounterSun++;
                    }
                }
            }


        }




        //end of update
    }









    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shine1")
        {
            // _shine1.SetActive(true);
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (collision.gameObject.tag == "shine2")
        {
            // _shine2.SetActive(true);
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (collision.gameObject.tag == "shine3")
        {
            //_shine3.SetActive(true);
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }

        //tealpill
        if (collision.gameObject.tag == "TealPill")
        {

            isInTealPillTrigger = true;

        }

        if (collision.gameObject.tag == "TEmpty")
        {
            isInTealPillEmptyTrigger = true;
        }

        //greenpill
        if (collision.gameObject.tag == "GreenPill")
        {

            isInGreenPillTrigger = true;

        }

        if (collision.gameObject.tag == "GEmpty")
        {
            isInGreenPillEmptyTrigger = true;
        }

        //purplepill
        if (collision.gameObject.tag == "PurplePill")
        {

            isInPurplePillTrigger = true;

        }

        if (collision.gameObject.tag == "PEmpty")
        {
            isInPurplePillEmptyTrigger = true;
        }


        //button
        if (collision.gameObject.tag == "NextButton")
        {
            IsTouchingNextDayButton = true;
        }


        //Environment---

        //Radio
        if (collision.gameObject.tag == "Radio")
        {

            isInRadioTrigger = true;

        }

        if (collision.gameObject.tag == "ExitRadioMini")
        {
            isInRadioEmptyTrigger = true;
        }

        //PillThingy
        if (collision.gameObject.tag == "PillThingy")
        {

            isInPillThingyTrigger = true;

        }

        if (collision.gameObject.tag == "ExitPillThingyMini")
        {
            isInPillThingyEmptyTrigger = true;
        }

        //Window
        if (collision.gameObject.tag == "Window")
        {

            isInWindowTrigger = true;

        }

        if (collision.gameObject.tag == "ExitWindowMini")
        {
            isInWindowEmptyTrigger = true;
        }





        //nob
        if (collision.gameObject.tag == "nob")
        {
            isInNobTrigger = true;
        }

        //restartButton
        if (collision.gameObject.tag == "restartButton")
        {
            pressedrestartButton = true;
        }




        //pill_holes_thing
        if (collision.gameObject.tag == "monday")
        {
            isInMonTrigger = true;
        }

        if (collision.gameObject.tag == "tuesday")
        {
            isInTueTrigger = true;
        }

        if (collision.gameObject.tag == "wednesday")
        {
            isInWedTrigger = true;
        }

        if (collision.gameObject.tag == "thursday")
        {
            isInThurTrigger = true;
        }

        if (collision.gameObject.tag == "friday")
        {
            isInFriTrigger = true;
        }

        if (collision.gameObject.tag == "saturday")
        {
            isInSatTrigger = true;
        }

        if (collision.gameObject.tag == "sunday")
        {
            isInSunTrigger = true;
        }


        //buttons/questions_for_window

        if (collision.gameObject.tag == "a1")
        {
            _isIna1 = true;
        }
        if (collision.gameObject.tag == "b2")
        {
            _isInb2 = true;
        }
        if (collision.gameObject.tag == "c3")
        {
            _isInc3 = true;
        }


        if (collision.gameObject.tag == "atb")
        {
            _isInatb = true;
        }
        if (collision.gameObject.tag == "bh")
        {
            _isInbh = true;
        }
        if (collision.gameObject.tag == "cs")
        {
            _isIncs = true;
        }
    }




    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "shine1")
        {
            //_shine1.SetActive(false);
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (collision.gameObject.tag == "shine2")
        {
            // _shine2.SetActive(false);
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (collision.gameObject.tag == "shine3")
        {
            //_shine3.SetActive(false);
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

        //tealpill
        if (collision.gameObject.tag == "TealPill")
        {

            isInTealPillTrigger = false;

        }

        if (collision.gameObject.tag == "TEmpty")
        {
            isInTealPillEmptyTrigger = false;
        }

        //greenpill
        if (collision.gameObject.tag == "GreenPill")
        {

            isInGreenPillTrigger = false;

        }

        if (collision.gameObject.tag == "GEmpty")
        {
            isInGreenPillEmptyTrigger = false;
        }

        //purplepill
        if (collision.gameObject.tag == "PurplePill")
        {

            isInPurplePillTrigger = false;

        }

        if (collision.gameObject.tag == "PEmpty")
        {
            isInPurplePillEmptyTrigger = false;
        }




        //button
        if (collision.gameObject.tag == "NextButton")
        {
            IsTouchingNextDayButton = false;
        }




        //Environment---

        //Radio
        if (collision.gameObject.tag == "Radio")
        {

            isInRadioTrigger = false;

        }

        if (collision.gameObject.tag == "ExitRadioMini")
        {
            isInRadioEmptyTrigger = false;
        }

        //PillThingy
        if (collision.gameObject.tag == "PillThingy")
        {

            isInPillThingyTrigger = false;

        }

        if (collision.gameObject.tag == "ExitPillThingyMini")
        {
            isInPillThingyEmptyTrigger = false;
        }

        //Window
        if (collision.gameObject.tag == "Window")
        {

            isInWindowTrigger = false;

        }

        if (collision.gameObject.tag == "ExitWindowMini")
        {
            isInWindowEmptyTrigger = false;
        }




        //nob
        if (collision.gameObject.tag == "nob")
        {
            isInNobTrigger = false;
        }

        //restartButton
        if (collision.gameObject.tag == "restartButton")
        {
            pressedrestartButton = false;
        }



        //pill_holes_thing
        if (collision.gameObject.tag == "monday")
        {
            isInMonTrigger = false;
        }

        if (collision.gameObject.tag == "tuesday")
        {
            isInTueTrigger = false;
        }

        if (collision.gameObject.tag == "wednesday")
        {
            isInWedTrigger = false;
        }

        if (collision.gameObject.tag == "thursday")
        {
            isInThurTrigger = false;
        }

        if (collision.gameObject.tag == "friday")
        {
            isInFriTrigger = false;
        }

        if (collision.gameObject.tag == "saturday")
        {
            isInSatTrigger = false;
        }

        if (collision.gameObject.tag == "sunday")
        {
            isInSunTrigger = false;
        }



        //buttons/questions_for_window

        if (collision.gameObject.tag == "a1")
        {
            _isIna1 = false;
        }
        if (collision.gameObject.tag == "b2")
        {
            _isInb2 = false;
        }
        if (collision.gameObject.tag == "c3")
        {
            _isInc3 = false;
        }


        if (collision.gameObject.tag == "atb")
        {
            _isInatb = false;
        }
        if (collision.gameObject.tag == "bh")
        {
            _isInbh = false;
        }
        if (collision.gameObject.tag == "cs")
        {
            _isIncs = false;
        }
    }







    void ResetProgression()
    {

        hasProgressedWin = false;
        hasProgressedRad = false;
        hasProgressedPill = false;

    }





    void ResetAllPills()
    {
        // Reset counters
        greenPillCounterMon = 0;
        greenPillCounterTue = 0;
        greenPillCounterWed = 0;
        greenPillCounterThur = 0;
        greenPillCounterFri = 0;
        greenPillCounterSat = 0;
        greenPillCounterSun = 0;

        tealPillCounterMon = 0;
        tealPillCounterTue = 0;
        tealPillCounterWed = 0;
        tealPillCounterThur = 0;
        tealPillCounterFri = 0;
        tealPillCounterSat = 0;
        tealPillCounterSun = 0;

        purplePillCounterMon = 0;
        purplePillCounterTue = 0;
        purplePillCounterWed = 0;
        purplePillCounterThur = 0;
        purplePillCounterFri = 0;
        purplePillCounterSat = 0;
        purplePillCounterSun = 0;

        // Deactivate all pill GameObjects by disabling their SpriteRenderer
        // === MONDAY ===
        greenPillMon1.GetComponent<SpriteRenderer>().enabled = false;
        greenPillMon2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillMon1.GetComponent<SpriteRenderer>().enabled = false;
        tealPillMon2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillMon3.GetComponent<SpriteRenderer>().enabled = false;
        purplePillMon1.GetComponent<SpriteRenderer>().enabled = false;

        // === TUESDAY ===
        greenPillTue1.GetComponent<SpriteRenderer>().enabled = false;
        greenPillTue2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillTue1.GetComponent<SpriteRenderer>().enabled = false;
        tealPillTue2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillTue3.GetComponent<SpriteRenderer>().enabled = false;
        purplePillTue1.GetComponent<SpriteRenderer>().enabled = false;

        // === WEDNESDAY ===
        greenPillWed1.GetComponent<SpriteRenderer>().enabled = false;
        greenPillWed2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillWed1.GetComponent<SpriteRenderer>().enabled = false;
        tealPillWed2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillWed3.GetComponent<SpriteRenderer>().enabled = false;
        purplePillWed1.GetComponent<SpriteRenderer>().enabled = false;

        // === THURSDAY ===
        greenPillThur1.GetComponent<SpriteRenderer>().enabled = false;
        greenPillThur2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillThur1.GetComponent<SpriteRenderer>().enabled = false;
        tealPillThur2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillThur3.GetComponent<SpriteRenderer>().enabled = false;
        purplePillThur1.GetComponent<SpriteRenderer>().enabled = false;

        // === FRIDAY ===
        greenPillFri1.GetComponent<SpriteRenderer>().enabled = false;
        greenPillFri2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillFri1.GetComponent<SpriteRenderer>().enabled = false;
        tealPillFri2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillFri3.GetComponent<SpriteRenderer>().enabled = false;
        purplePillFri1.GetComponent<SpriteRenderer>().enabled = false;

        // === SATURDAY ===
        greenPillSat1.GetComponent<SpriteRenderer>().enabled = false;
        greenPillSat2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillSat1.GetComponent<SpriteRenderer>().enabled = false;
        tealPillSat2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillSat3.GetComponent<SpriteRenderer>().enabled = false;
        purplePillSat1.GetComponent<SpriteRenderer>().enabled = false;

        // === SUNDAY ===
        greenPillSun1.GetComponent<SpriteRenderer>().enabled = false;
        greenPillSun2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillSun1.GetComponent<SpriteRenderer>().enabled = false;
        tealPillSun2.GetComponent<SpriteRenderer>().enabled = false;
        tealPillSun3.GetComponent<SpriteRenderer>().enabled = false;
        purplePillSun1.GetComponent<SpriteRenderer>().enabled = false;


        Debug.Log("Pills have been reset!");
    }


}
