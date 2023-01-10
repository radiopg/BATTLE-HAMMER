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

<<<<<<< Updated upstream
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
=======
        File.WriteAllText(Application.persistentDataPath + "/savefileLoadOut.json", json);
    }

    public void SaveScore()
    {
        SaveData dataHighScore = new SaveData();
        dataHighScore.highscore1 = highscore1;
        dataHighScore.highscore2 = highscore2;
        dataHighScore.highscore3 = highscore3;
        dataHighScore.highscore4 = highscore4;
        dataHighScore.highscore5 = highscore5;

        string json = JsonUtility.ToJson(dataHighScore);

        File.WriteAllText(Application.persistentDataPath + "/savefileHighScores.json", json);
>>>>>>> Stashed changes
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            loadoutA1 = data.loadoutA1;
            loadoutA2 = data.loadoutA2;
            loadoutA3 = data.loadoutA3;
            loadoutA4 = data.loadoutA4;

            loadoutB1 = data.loadoutB1;
            loadoutB2 = data.loadoutB2;
            loadoutB3 = data.loadoutB3;
            loadoutB4 = data.loadoutB4;

            loadout1[0] = loadoutA1;
            loadout1[1] = loadoutA2;
            loadout1[2] = loadoutA3;
            loadout1[3] = loadoutA4;

            loadout2[0] = loadoutB1;
            loadout2[1] = loadoutB2;
            loadout2[2] = loadoutB3;
            loadout2[3] = loadoutB4;
        }
    }

    public void DeleteJsonFile()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        File.Delete(path);

        for(int i = 0; i < loadout1.Length; i++)
        {
            loadout1[i] = null;
            loadout2[i] = null;
        }

        loadoutA1 = null;
        loadoutA2 = null;
        loadoutA3 = null;
        loadoutA4 = null;

        loadoutB1 = null;
        loadoutB2 = null;
        loadoutB3 = null;
        loadoutB4 = null;


    }
}
