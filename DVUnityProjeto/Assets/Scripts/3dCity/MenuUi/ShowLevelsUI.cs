using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ShowLevelsUI : MonoBehaviour
{
    [SerializeField] private CanvasBuildScript canvasToShow;

    [SerializeField] private TextMeshProUGUI thownHallLevel;
    [SerializeField] private TextMeshProUGUI farmLevel;
    [SerializeField] private TextMeshProUGUI woodLevel;
    [SerializeField] private TextMeshProUGUI rockLevel;
    [SerializeField] private TextMeshProUGUI portLevel;
    [SerializeField] private TextMeshProUGUI quartelLevel;
    [SerializeField] private TextMeshProUGUI marketLevel;




    private LevelBuilds TownHall;
    private LevelBuilds Farm;
    private LevelBuilds Sawmill;
    private LevelBuilds Mine;
    private LevelBuilds Port;
    private LevelBuilds Quartel;
    private LevelBuilds Market;


    void Awake(){

        //os reset levels serao apagados qunando fizermos a build do jogo

        TownHall = canvasToShow.whatEvolveBuildIs("TownHall").getLevelBuilds();
      //  TownHall.resetLevel();
        Farm = canvasToShow.whatEvolveBuildIs("Farm").getLevelBuilds();
      //  Farm.resetLevel();
        Sawmill = canvasToShow.whatEvolveBuildIs("Sawmill").getLevelBuilds();
      //  Sawmill.resetLevel();
        Mine = canvasToShow.whatEvolveBuildIs("Mine").getLevelBuilds();
        //Mine.resetLevel();
        Port = canvasToShow.whatEvolveBuildIs("Port").getLevelBuilds();
        //Port.resetLevel();
        Quartel = canvasToShow.whatEvolveBuildIs("Quartel").getLevelBuilds();
        //Quartel.resetLevel();
        Market = canvasToShow.whatEvolveBuildIs("Market").getLevelBuilds();
        //Market.resetLevel();

        setLevelBuilds();

    }

    private void OnEnable()
    {
        TownHall.OnBuildLevelChanged += setLevelBuilds;
        Farm.OnBuildLevelChanged += setLevelBuilds;
        Sawmill.OnBuildLevelChanged += setLevelBuilds;
        Mine.OnBuildLevelChanged += setLevelBuilds;
        Port.OnBuildLevelChanged += setLevelBuilds;
        Quartel.OnBuildLevelChanged += setLevelBuilds;
        Market.OnBuildLevelChanged += setLevelBuilds;

    }
    private void OnDisable()
    {
        TownHall.OnBuildLevelChanged -= setLevelBuilds;
        Farm.OnBuildLevelChanged -= setLevelBuilds;
        Sawmill.OnBuildLevelChanged -= setLevelBuilds;
        Mine.OnBuildLevelChanged -= setLevelBuilds;
        Port.OnBuildLevelChanged -= setLevelBuilds;
        Quartel.OnBuildLevelChanged -= setLevelBuilds;
        Market.OnBuildLevelChanged -= setLevelBuilds;

        
    }


    private void setLevelBuilds()
    {
        thownHallLevel.text = TownHall.getNumberLevel().ToString();
        farmLevel.text = Farm.getNumberLevel().ToString();
        woodLevel.text = Sawmill.getNumberLevel().ToString();
        rockLevel.text = Mine.getNumberLevel().ToString();
        portLevel.text = Port.getNumberLevel().ToString();
        quartelLevel.text = Quartel.getNumberLevel().ToString();
        marketLevel.text = Market.getNumberLevel().ToString();
    }





   
}
