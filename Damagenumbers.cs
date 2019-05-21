using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using ModAPI.Attributes;
using TheForest;
using TheForest.Utils;
namespace DamageNumbers
{
    public class DamageIndicator : EnemyHealth
    {

        public IndicatorInfo info;
        protected override void Start()
        {
            base.Start();
            info = gameObject.AddComponent<IndicatorInfo>();
            info.hp = this;
            info.Male = true;

            string n = "";
            if (ai.pale)
            {
                n += "PALE ";
                if (ai.skinned)
                {
                    n = "SKINNED ";
                }
            }
            if (ai.painted)
            {
                n += "PAINTED  ";
            }
            if (ai.male)
            {
                n += "MALE ";
            }
            if (ai.creepy_male)
            {
                n += "ARMSY ";

            }
            if (ai.maleSkinny)
            {
                n += "SKINNY MALE ";

            }
            if (ai.female)
            {
                n += "FEMALE ";
                info.Male = false;
            }
            if (ai.femaleSkinny)
            {
                n += "SKINNY FEMALE ";
                info.Male = false;

            }
            if (ai.creepy)
            {
                n += "VIRGINIA ";
                info.Male = false;

            }
            if (ai.creepy_baby)
            {
                n += "BABY";

            }
            if (ai.creepy_fat)
            {
                n += "FATMAN ";
            }
            if (ai.fireman)
            {
                n += "FIREMAN ";
            }
            if (ai.leader)
            {
                n += "LEADER ";

            }



            info.MutantName = n;
        }

        public override void HitReal(int damage)
        {
            if (info.MaxHealth < Health)
            {
                info.MaxHealth = Health;
            }
            base.HitReal(damage);
            info.CurrentHealth = Health;
            IndicatorDisplay.ChangeTarget(info);
        }


    }
    public class IndicatorInfo : MonoBehaviour
    {
        public EnemyHealth hp;
        public bool Male;
        public int CurrentHealth;
        public int MaxHealth;
        public string MutantName;
        public string PersonName;


        void LateStart()
        {
            CurrentHealth = hp.Health;
            MaxHealth = CurrentHealth;
        }

        void Start()
        {
            Invoke("LateStart", 2);

            string[] Femalenames = new string[]
            {
                "Megan",
                "Moritzka",
                "Tatsumaki",
                "Laura",
                "LizzPlays",
                "Mia",
                "Mona Lisa",
                "Lydia",
                "Sasha",
                "Eva",
                "Eve",
                "Chick",
                "Gloria Borger",
                "Helga",
                "Nevaeh",
                "Schartzmugel",
                "Boomquifa",
                "Sweden",
                "Samara",
                "Hitler",
                "China",
                "Isis",
                "Miku",
                "Yo fat momma",
                "Poppy",
                "Thot",
                "Feminazist",
                "Wolfskull",
                "Kitty",
                "Caustic",
            };

            string[] Malenames = new string[] {
                "Moritz",
                "Hazard",
                "Kutie",
                "Farket",
                "Saladass",
                "SoulDr!nker",
                "SixxKillur",
                "Alex Armsy",
                "Broadbent",
                "Bob",
                "Fetid",
                "Fooster",
                "Chris AKA Axt",
                "Steve",
                "Pepe",
                "Shrek",
                "Kim John Oof",
                "Trump",
                "Geralt from Rivia",
                "Typical Russian pub",
                "Yoshi",
                "Mario",
                "Luigi",
                "Not Waluigi",
                "Dad",
                "Timmy",
                "German",
                "Bob Ross",
                "SampleText",
                "_Bottom_Text_",
                "Meme",
                "John Wick",
                "Frank",
                "Vsauce, Michael here",
                "Vsauce, Jake here",
                "IDubbz",
                "Saitama",
                "DNL",
                "Smokey",
                "Admin",
                "Elon Musk",
                "Donald",
                "Dr.Tursko",
                "Thanos",
                "BOY",
                "Kratos",
                "Jabba",
                "Sonic",
                "_xX_Pu$$yD3str0y3r_Xx",
                "Hodor",
                "John Snow",
                "Franklin",
                "George Washington",
                "James Bond",
                "Indiana Johnes",
                "Boris",
                "Tupac",
                "Dragonborn",
                "Jesus",
                "Jack Sparrow",
                "Linus",
                "PewDiePie",
                "Flash",
                "Phoenix",
                "Diesel",
                "Neo",
                "Breaker",
                "Pudge",
                "Gaylord",
                "Dick",
                "Satan",
                "Cannon",
                "Seaman",
                "Elmo",
                "Wolfgang",
                "Osama",
                "Justin Biebier",
                "Gaylon",
                "Mustafa",
                "Billy",
                "Donkey",
                "Pinocchio",
                "Reddit",
                "CJ",
                "Damn Train",
                "Rick Harrison",
                "Ali",
                "Kaspito",
                "Luis Fonsi",
                "Jojo",
                "Metamoth741",
                "Matt",
                "White lynx",
                "Phoenix",
                "Bananafalls",

            };

            string[] suffixes = new string[]
            {
                "",
                "with huge fuckin' anime tiddies",
                "on a bike",
                "and he is angry",
                "that gay dipshit",
                "who hasn't got a bonus meme for a month",
                "the scammer",
                "the retard",
                "the ninja",
                "the pro",
                "the boar vessel 500 to 600 BC Etruskan ceramic",
                "the forest gump",
                "the wizard",
                "the next president",
                "the shitposter",
                  "the normie",
                   "the dank",
                     "the deepfried",
                     "the modder",
                     "the admin",
                     "the haxor",
                     "the best dud evr",
                     "the mega gay",
                     "the trap",
                     "the loli",
                     "the lolipop",
                     "the lolicon",
                     "the hentai star",
                     "the one with PornHub premium",
                     "the fortnite youtuber",
                     "the good youtuber",
                     "the pirate",
                     "the absolute unit",
                     "the shitty bot",
                     "the iron man",
                     "the reaper",
                     "the bear",
                     "the paladin",
                     "the Emperor",
                     "the mad lad",
                     "the Feminazist",
                     "the hedgehog",
                     "the twitch thot",
                     "the hoe",
                     "the fat pig",
                     "the fat cunt",
                     "the absolute beauty",
                     "the god",
                     "the frickin alien",
                     "the interdimensional traveller",
                     "the memelord",
                     "the banned",
                     "the salesman",
                     "the one who spilld beans",
                     "the familiar",
                     "the clone",
                     ", your fanboy",
                     "the stalker",
                     "the one",
                     "the mutant",
                     "the creepy",
                     "the bullyhunter77",
                     "the bully",
                     "the guy who took your virginity",
                     "the griefer",
                     "the already dead",
                     "the anime star",
                     "the weeb",
                     "the twitch streamer",
                     "the pro minecraft player",
                     "the pro roblox player",
                     "the Grand Master of Unity",
                     "the son of owner of Microsoft",
                     "the chairman",
                     "the toilet lady",
                     "the Enemy",
                     "the spy",
                     "the shitty soundcloud rapper",
                     "the lord of forest",
                     "the nazi",
                     "the real nigga",
                     "the fat fricking fag",
                     "the communist",
                     "who does quick mafs",
                     "the homosexual",
                     "the straightn't",
                     "the automod",
                     "lives fast and eats ass",
                     "the raw sauce",
                     "the libtard",
                     "and this is my pawn shop",
                    "the nugget",
                    ",you... nugget",
                    "the Börgarfjörður",
                    "the nerfed to the ground",
                    "the over powered",
                    "the guy who made this mod",
                    "the party girl",
                    "the cat",
                    "the pussy",
                    "the immune to MAGIC!",
                    "the WEEBZARD",
                    "who has the only weakness of damage",
                    "with a six pack",
                    "with a huge dick",
                    "with a small dick",
                    "without a dick",
                    "the communist",
                    "the arab",
                    "the Polish guy",
                    "V2",
                    ": global offensive",
                    "2",
                    "the famous",
                    "the twitch thot",
                    "the decent at killing players",
                    "the one who will die second",
                    "the borb",
                    "who faps to loli",
                    "who can breathe underwater for the rest of his life",
                    "the Yeetus",
                    "the peepo",
                    "the forest dev",
                    "who is into BDSM",
            };
            string[] prefixes = new string[]
            {
                "",
                "Tilted",
                "Slightly stronger",
                "Dirty",
                "DJ",
                "",
                "Pale",
                "Overpowered",
                "Undefeated",
                "Filthy",
                "Funny",
                "Weakend",
                "STD having",
                "Aussie",
                "Big",
                "Massive",
                "Fat",
                "Weeabo",
                "Toxic",
                "Very angry",
                "Grandma",
                "Grandpa",
                "Brother",
                "Thicc",
                "Gargantuan",
                "Master",
                "Prince",
                "King",
                "Shitty",
                "Lil'",
                "Small",
                "Alpha",
                "Enslaved",
                "Mr.",
                "Long",
                "Fearful",
                "Rebel",
                "Thin",
                "Loli",
                "Sloppy",
                "Ruthless",
                "Horny",
                "Always wet",
                "Crazy",
                "Old",
                "Elder",
                "Chief",
                "Darth",
                "I'm",
                "Desperate",
                "Despacito",
                "Acustic",
                "Autistic",
                "Nazi",
                "( ͡° ͜ʖ ͡°)",
                "Deepfried",
                "Dank",
                "Edgy",
                "NSFW",
                "Goth",
                "Big tiddy",
                "Mega thicc",
                "Honest",
                "Erect for 4hrs straight",
                "Erect",
                "Pissed",
                "Unerect",
                "Slutty",
                "Horny",
                "THIRSTY",
                "Smoking",
                "Lit AF",
                "Grown up",
                "Retarded",
                "Crippled",
                "Depressed",
                "Very sad",
                "Randy",
                "Underaged",
                "Not yet legal",
                "Swolo",
                "Overrated",
                "Numskulled",
                "Meaty",
                "Swollen",
                "Oversized",
                "Enraged",
                "Insulted",
            };
            int pref = Random.Range(0, prefixes.Length);



            PersonName = prefixes[pref];
            if (Male)
            {
                int nameindex = Random.Range(0, Malenames.Length);
                PersonName += " "+Malenames[nameindex];
            }
            else
            {
                int nameindex = Random.Range(0, Femalenames.Length);
                PersonName += " " + Femalenames[nameindex];
            }
            int suff= Random.Range(0, suffixes.Length);
            PersonName +=" "+ suffixes[suff];
        }

    }
    public class IndicatorDisplay : MonoBehaviour
    {
        private static IndicatorDisplay instance;

        private IndicatorInfo info;

        private Font customFont;

        private Texture2D HPBG;
        private Texture2D HPF;
        private GUIStyle nameStyle;
        private GUIStyle JKnameStyle;

        private float UpperRectHeight;
        private float LowerRectPosY;
        private Rect rect;
        private Rect NameRect;
        private Rect HealthTotalRect;
        private Rect JokeNameRect;

        private bool CustomizationOpen;



        [ExecuteOnGameStart]
        public static void Init()
        {
            if(instance==null)
            instance=new GameObject("IndicatorDisplayManager").AddComponent<IndicatorDisplay>();
        }

        //Called only once upon creating the object
        void Start()
        {
             if (IndicatorDisplaySettings.Load())
            {
                IndicatorDisplaySettings.instance = new IndicatorDisplaySettings();
            }
            Invoke("LateStart", 4);

          
            CustomizationOpen = false;

        }

        // Hitting any enemy will trigger this and change the current display, the display will last 20 seconds then it will disappear
        public static void ChangeTarget(IndicatorInfo newinfo)
        {
            instance.info = newinfo;
            instance.ClearTarget();
        }


        public void ClearTarget()
        {
            CancelInvoke("ClearTargetLate");
            Invoke("ClearTargetLate", 20);
        }


        public void ClearTargetLate()
        {
            info = null;    //Setting display to target to null so OnGUI is stopped
        }

        void LateStart()
        {
            ChangeFont(IndicatorDisplaySettings.instance.FontName);
            SetDesign();
            IndicatorDisplaySettings.Save();

        }


        // Assigning variables only when they need to be assigned
        void SetDesign()
        {

            switch (IndicatorDisplaySettings.instance.displayMode)
            {
                case IndicatorDisplaySettings.DisplayMode.BottomCenter:
                    rect = new Rect(Screen.width / 2 - IndicatorDisplaySettings.instance.Width / 2 + IndicatorDisplaySettings.instance.offsetX,
                        Screen.height + IndicatorDisplaySettings.instance.offsetY,
                        IndicatorDisplaySettings.instance.Width,
                        IndicatorDisplaySettings.instance.Height);
                    break;
                case IndicatorDisplaySettings.DisplayMode.BottomLeft:
                    rect = new Rect(IndicatorDisplaySettings.instance.offsetX,
                        Screen.height + IndicatorDisplaySettings.instance.offsetY,
                        IndicatorDisplaySettings.instance.Width,
                        IndicatorDisplaySettings.instance.Height);
                    break;
                case IndicatorDisplaySettings.DisplayMode.BottomRight:
                    rect = new Rect(IndicatorDisplaySettings.instance.offsetX + Screen.width - IndicatorDisplaySettings.instance.Width,
                        Screen.height + IndicatorDisplaySettings.instance.offsetY,
                        IndicatorDisplaySettings.instance.Width,
                        IndicatorDisplaySettings.instance.Height);
                    break;
                case IndicatorDisplaySettings.DisplayMode.MiddleCenter:
                    rect = new Rect(0, 0, IndicatorDisplaySettings.instance.Width, IndicatorDisplaySettings.instance.Height);
                    rect.center = new Vector2(Screen.width / 2 + IndicatorDisplaySettings.instance.offsetX, Screen.height / 2 + IndicatorDisplaySettings.instance.offsetY);
                    break;
                case IndicatorDisplaySettings.DisplayMode.MiddleLeft:
                    rect = new Rect(IndicatorDisplaySettings.instance.offsetX, Screen.height / 2 - IndicatorDisplaySettings.instance.Height / 2 + IndicatorDisplaySettings.instance.offsetY, IndicatorDisplaySettings.instance.Width, IndicatorDisplaySettings.instance.Height);
                    break;
                case IndicatorDisplaySettings.DisplayMode.MiddleRight:
                    rect = new Rect(IndicatorDisplaySettings.instance.offsetX + Screen.width - IndicatorDisplaySettings.instance.Width, Screen.height / 2 - IndicatorDisplaySettings.instance.Height / 2 + IndicatorDisplaySettings.instance.offsetY, IndicatorDisplaySettings.instance.Width, IndicatorDisplaySettings.instance.Height);
                    break;
                case IndicatorDisplaySettings.DisplayMode.TopCenter:
                    rect = new Rect(Screen.width / 2 - IndicatorDisplaySettings.instance.Width / 2 + IndicatorDisplaySettings.instance.offsetX, IndicatorDisplaySettings.instance.offsetY, IndicatorDisplaySettings.instance.Width, IndicatorDisplaySettings.instance.Height);
                    break;
                case IndicatorDisplaySettings.DisplayMode.TopLeft:
                    rect = new Rect(IndicatorDisplaySettings.instance.offsetX, IndicatorDisplaySettings.instance.offsetY, IndicatorDisplaySettings.instance.Width, IndicatorDisplaySettings.instance.Height);
                    break;
                case IndicatorDisplaySettings.DisplayMode.TopRight:
                    rect = new Rect(IndicatorDisplaySettings.instance.offsetX + Screen.width - IndicatorDisplaySettings.instance.Width, IndicatorDisplaySettings.instance.offsetY, IndicatorDisplaySettings.instance.Width, IndicatorDisplaySettings.instance.Height);
                    break;
            }

            JKnameStyle = new GUIStyle(ModAPI.Interface.Skin.label);
            nameStyle = new GUIStyle(ModAPI.Interface.Skin.label);
            nameStyle.fontSize = IndicatorDisplaySettings.instance.FontSize;
            nameStyle.alignment = TextAnchor.MiddleCenter;
            nameStyle.font = customFont;
            nameStyle.richText = true;
            JKnameStyle.fontSize = IndicatorDisplaySettings.instance.FontSize;
            JKnameStyle.alignment = TextAnchor.UpperCenter;
            JKnameStyle.font = customFont;
            JKnameStyle.fontStyle = FontStyle.Italic;
            JKnameStyle.overflow = new RectOffset(1000, 1000, 0, 10);
            LowerRectPosY = rect.yMax;

            UpperRectHeight = rect.height * IndicatorDisplaySettings.instance.HealthToNameRatio;
            JokeNameRect = new Rect(rect.x, rect.y + IndicatorDisplaySettings.instance.FontSize - 500, rect.width + 1000, UpperRectHeight);
            NameRect = new Rect(rect.x, rect.y, rect.width, UpperRectHeight);
           LowerRectPosY-= rect.height * (1-IndicatorDisplaySettings.instance.HealthToNameRatio);


            HealthTotalRect = new Rect(rect.x + 3, LowerRectPosY + 3, rect.width - 6, rect.height - UpperRectHeight);
            HPBG = new Texture2D(10, 10);
            for (int x = 0; x < HPBG.width; x++)
            {
                for (int y = 0; y < HPBG.height; y++)
                {
                    HPBG.SetPixel(x, y, new Color(IndicatorDisplaySettings.instance.HealthBarBackgroundR, IndicatorDisplaySettings.instance.HealthBarBackgroundG, IndicatorDisplaySettings.instance.HealthBarBackgroundB));

                }
            }
            HPBG.Apply();

            HPF = new Texture2D(10, 10);

            for (int x = 0; x < HPBG.width; x++)
            {
                for (int y = 0; y < HPBG.height; y++)
                {
                    HPF.SetPixel(x, y, new Color(IndicatorDisplaySettings.instance.HealthBarR, IndicatorDisplaySettings.instance.HealthBarG, IndicatorDisplaySettings.instance.HealthBarB));

                }

            }
            HPF.Apply();
        }
            public void ChangeFont(string s)
        {
            customFont = Font.CreateDynamicFontFromOSFont(s, 20);
            if (customFont == null)
            {

                customFont = Font.CreateDynamicFontFromOSFont("Arial", 20);
                ModAPI.Console.Write("Incorrect font please input another one");
            }
        }


        void Update()
        {
            if (ModAPI.Input.GetButtonDown("OpenCustomization"))
            {

                CustomizationOpen = !CustomizationOpen;
            }
        }


        void MoritzIsFunny()
        {
            new Mario();



           // MarioMaker someMario = new MarioMaker();
           // someMario.Start();
        }


        // Drawing all the ui elements
        void OnGUI()
        {

            if (CustomizationOpen)
            {
                GUI.Label(new Rect(200, 0, 200, 20), "Offset X = " + IndicatorDisplaySettings.instance.offsetX);
                IndicatorDisplaySettings.instance.offsetX = Mathf.RoundToInt(GUI.HorizontalSlider(new Rect(0, 0, 200, 20), IndicatorDisplaySettings.instance.offsetX, 0, Screen.width));
                GUI.Label(new Rect(200, 30, 200, 20), "Offset Y = " + IndicatorDisplaySettings.instance.offsetY);
                IndicatorDisplaySettings.instance.offsetY = Mathf.RoundToInt(GUI.HorizontalSlider(new Rect(0, 30, 200, 20), IndicatorDisplaySettings.instance.offsetY, 0, Screen.height));
                GUI.Label(new Rect(200, 60, 200, 20), "Width = " + IndicatorDisplaySettings.instance.Width);
                IndicatorDisplaySettings.instance.Width = Mathf.RoundToInt(GUI.HorizontalSlider(new Rect(0, 60, 200, 20), IndicatorDisplaySettings.instance.Width, 0, Screen.width));
                GUI.Label(new Rect(200, 90, 200, 20), "Height = " + IndicatorDisplaySettings.instance.Height);
                IndicatorDisplaySettings.instance.Height = Mathf.RoundToInt(GUI.HorizontalSlider(new Rect(0, 90, 200, 20), IndicatorDisplaySettings.instance.Height, 0, Screen.height));

                GUI.Label(new Rect(200, 140, 200, 20), "Healthbar To Name Ratio = " + IndicatorDisplaySettings.instance.HealthToNameRatio);
                IndicatorDisplaySettings.instance.HealthToNameRatio = GUI.HorizontalSlider(new Rect(0, 140, 200, 20), IndicatorDisplaySettings.instance.HealthToNameRatio, 0, 1);

                GUI.Label(new Rect(0, 190, 200, 20), "Anchor = " + IndicatorDisplaySettings.instance.displayMode.ToString());
                if (GUI.Button(new Rect(0, 210, 30, 30), "TOP L"))
                {
                    IndicatorDisplaySettings.instance.displayMode = IndicatorDisplaySettings.DisplayMode.TopLeft;
                }
                if (GUI.Button(new Rect(30, 210, 30, 30), "TOP M"))
                {
                    IndicatorDisplaySettings.instance.displayMode = IndicatorDisplaySettings.DisplayMode.TopCenter;

                }
                if (GUI.Button(new Rect(60, 210, 30, 30), "TOP R"))
                {
                    IndicatorDisplaySettings.instance.displayMode = IndicatorDisplaySettings.DisplayMode.TopRight;

                }
                if (GUI.Button(new Rect(0, 240, 30, 30), "MID L"))
                {
                    IndicatorDisplaySettings.instance.displayMode = IndicatorDisplaySettings.DisplayMode.MiddleLeft;

                }
                if (GUI.Button(new Rect(30, 240, 30, 30), "MID M"))
                {
                    IndicatorDisplaySettings.instance.displayMode = IndicatorDisplaySettings.DisplayMode.MiddleCenter;

                }
                if (GUI.Button(new Rect(60, 240, 30, 30), "MID R"))
                {
                    IndicatorDisplaySettings.instance.displayMode = IndicatorDisplaySettings.DisplayMode.MiddleRight;

                }
                if (GUI.Button(new Rect(0, 270, 30, 30), "BOT L"))
                {
                    IndicatorDisplaySettings.instance.displayMode = IndicatorDisplaySettings.DisplayMode.BottomLeft;

                }
                if (GUI.Button(new Rect(30, 270, 30, 30), "BOT M"))
                {
                    IndicatorDisplaySettings.instance.displayMode = IndicatorDisplaySettings.DisplayMode.BottomCenter;

                }
                if (GUI.Button(new Rect(60, 270, 30, 30), "BOT R"))
                {
                    IndicatorDisplaySettings.instance.displayMode = IndicatorDisplaySettings.DisplayMode.BottomRight;

                }
                GUI.Label(new Rect(200, 300, 200, 30), "Custom font name");
                IndicatorDisplaySettings.instance.FontName = GUI.TextField(new Rect(0, 300, 200, 30), IndicatorDisplaySettings.instance.FontName);
                GUIStyle samplestyle = new GUIStyle(GUI.skin.label);
                samplestyle.font = customFont;
                samplestyle.fontSize = IndicatorDisplaySettings.instance.FontSize;
                GUI.Label(new Rect(400, 300, 200, 100), "AaBbCcDdEeFfGgHh 1234567890", samplestyle);
                IndicatorDisplaySettings.instance.FontSize = Mathf.RoundToInt(GUI.HorizontalSlider(new Rect(200, 330, 200, 30), IndicatorDisplaySettings.instance.FontSize, 4, 40));

                int i = 370;
                IndicatorDisplaySettings.instance.HealthBarBackgroundR = GUI.HorizontalSlider(new Rect(0, i, 200, 30), IndicatorDisplaySettings.instance.HealthBarBackgroundR, 0, 1);
                GUI.Label(new Rect(200, i, 200, 30), "Background Red ");
                i += 30;
                IndicatorDisplaySettings.instance.HealthBarBackgroundG = GUI.HorizontalSlider(new Rect(0, i, 200, 30), IndicatorDisplaySettings.instance.HealthBarBackgroundG, 0, 1);
                GUI.Label(new Rect(200, i, 200, 30), "Background Green ");
                i += 30;
                IndicatorDisplaySettings.instance.HealthBarBackgroundB = GUI.HorizontalSlider(new Rect(0, i, 200, 30), IndicatorDisplaySettings.instance.HealthBarBackgroundB, 0, 1);
                GUI.Label(new Rect(200, i, 200, 30), "Background Blue ");
                i += 60;
                IndicatorDisplaySettings.instance.HealthBarR = GUI.HorizontalSlider(new Rect(0, i, 200, 30), IndicatorDisplaySettings.instance.HealthBarR, 0, 1);
                GUI.Label(new Rect(200, i, 200, 30), "Foreground Red ");
                i += 30;
                IndicatorDisplaySettings.instance.HealthBarG = GUI.HorizontalSlider(new Rect(0, i, 200, 30), IndicatorDisplaySettings.instance.HealthBarG, 0, 1);
                GUI.Label(new Rect(200, i, 200, 30), "Foreground Green ");
                i += 30;
                IndicatorDisplaySettings.instance.HealthBarB = GUI.HorizontalSlider(new Rect(0, i, 200, 30), IndicatorDisplaySettings.instance.HealthBarB, 0, 1);
                GUI.Label(new Rect(200, i, 200, 30), "Foreground Blue ");
                i += 50;
                if (GUI.Button(new Rect(20, i, 250, 40), "SAVE AND UPDATE CHANGES"))
                {
                    IndicatorDisplaySettings.Save();
                    ChangeFont(IndicatorDisplaySettings.instance.FontName);
                    SetDesign();
                }

                i += 50;

                //if (GUI.Button(new Rect(20, i, 250, 40), "Mario?")){
                //    MoritzIsFunny();
                //}
            }
            else
            {












                // if there isnt a target to display return out of this method to save processing power
                // otherwise continue 

                if (info == null)
                {
                  return;
                }

                // drawing a simple background with predefined texture
                GUI.Box(rect, "");
                // following calls from GUI class will be displayed on top of previous one


                float f = (float)info.CurrentHealth / info.MaxHealth;
                f = Mathf.Clamp(f, 0, 1);

                Rect HealthCurrentRect = new Rect(HealthTotalRect);

                HealthCurrentRect.width *= f;
               


                Rect BGrect = new Rect(HealthTotalRect.x + HealthCurrentRect.width, HealthTotalRect.y, HealthTotalRect.width * (1-f), HealthTotalRect.height);

                string currhealthtext = info.CurrentHealth + "  /  " + info.MaxHealth;


                GUI.Label(NameRect, info.PersonName, nameStyle);

                GUI.DrawTexture(BGrect, HPBG);

                GUI.DrawTexture(HealthCurrentRect, HPF);
                GUI.Label(NameRect, info.PersonName, nameStyle);

                GUI.Label(HealthTotalRect, currhealthtext, nameStyle);
            }
        }
    }










    // Current setting data container class 
    public class IndicatorDisplaySettings
    {
        public static IndicatorDisplaySettings instance;
        private const string Path = "IndicatorSettings.json";
        public enum DisplayMode
        {
            TopLeft,
            TopCenter,
            TopRight,
            MiddleLeft,
            MiddleCenter,
            MiddleRight,
            BottomLeft,
            BottomCenter,
            BottomRight,

        }
        // anchor, the position from which the offset will be calculated
        public DisplayMode displayMode = DisplayMode.TopLeft;
        //box offset
        public int offsetX = 0;
        public int offsetY = 0;

        //font settings
        public string FontName = "Arial";
        public int FontSize = 20;

        // box size
        public int Width = 300;
        public int Height = 80;


        //slider - values from 0 to 1
        public float HealthToNameRatio = 0.6f;

        // Color of background 
        public float HealthBarBackgroundR = 0.3f;
        public float HealthBarBackgroundG = 0.3f;
        public float HealthBarBackgroundB = 0.3f;
        // Color of foreground
        public float HealthBarR = 0.1f;
        public float HealthBarG = 1f;
        public float HealthBarB = 0.1f;



        //static methods for save load
        public static void Save()
        {

            string json = JsonUtility.ToJson(instance);
            File.WriteAllText(Path, json);
        }

        public static bool Load()
        {
            if (File.Exists(Path))
            {
                string json = File.ReadAllText(Path);
                if (!string.IsNullOrEmpty(json))
                {
                    instance = JsonUtility.FromJson<IndicatorDisplaySettings>(json);
                    return false;
                }
            }
            return true;
        }

    }
}
