using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataPersistScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static DataPersistScript Instance;


    public string[] loadout1 = new string[4];
    public string[] loadout2 = new string[4];

    public string loadoutA1;
    public string loadoutA2;
    public string loadoutA3;
    public string loadoutA4;
    public string loadoutB1;
    public string loadoutB2;
    public string loadoutB3;
    public string loadoutB4;


    public int[] highscoresarray = new int[5];

    public int highscore1;
    public int highscore2;
    public int highscore3;
    public int highscore4;
    public int highscore5;

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public string loadoutA1;
        public string loadoutA2;
        public string loadoutA3;
        public string loadoutA4;
        public string loadoutB1;
        public string loadoutB2;
        public string loadoutB3;
        public string loadoutB4;

        public int highscore1;
        public int highscore2;
        public int highscore3;
        public int highscore4;
        public int highscore5;

    }

    public void SaveLoadOut()
    {
        SaveData data = new SaveData();
        data.loadoutA1 = loadout1[0];
        data.loadoutA2 = loadout1[1];
        data.loadoutA3 = loadout1[2];
        data.loadoutA4 = loadout1[3];

        data.loadoutB1 = loadout2[0];
        data.loadoutB2 = loadout2[1];
        data.loadoutB3 = loadout2[2];
        data.loadoutB4 = loadout2[3];

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefileLoadOut.json", json);
    }

    public void SaveScore()
    {
        SaveData dataHighScore = new SaveData();
        dataHighScore.highscore1 = highscore1;
        dataHighScore.highscore1 = highscore2;
        dataHighScore.highscore1 = highscore3;
        dataHighScore.highscore1 = highscore4;
        dataHighScore.highscore1 = highscore5;

        string json = JsonUtility.ToJson(dataHighScore);

        File.WriteAllText(Application.persistentDataPath + "/savefileHighScores.json", json);
    }

    public void LoadHighScoreData()
    {
        string path = Application.persistentDataPath + "/savefileHighScores.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData dataHighScore = JsonUtility.FromJson<SaveData>(json);

            highscore1 = dataHighScore.highscore1;
            highscore2 = dataHighScore.highscore2;
            highscore3 = dataHighScore.highscore3;
            highscore4 = dataHighScore.highscore4;
            highscore5 = dataHighScore.highscore5;

            highscoresarray[0] = highscore1;
            highscoresarray[1] = highscore2;
            highscoresarray[2] = highscore3;
            highscoresarray[3] = highscore4;
            highscoresarray[4] = highscore5;
        }
    }

    public void DeleteJsonFile()
    {
        string path = Application.persistentDataPath + "/savefileHighScores.json";
        File.Delete(path);

        for(int i = 0; i < highscoresarray.Length; i++)
        {
            highscoresarray[i] = 999999999;
        }

        highscore1 = 999999999;
        highscore2 = 999999999;
        highscore3 = 999999999;
        highscore4 = 999999999;
        highscore5 = 999999999;

    }
}
