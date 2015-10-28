using System;
using System.IO;
using LeagueSharp;
using LeagueSharp.Common;

namespace NiceGuySharp
{
    internal class FileHandler
    {
        public static string Folder = Config.LeagueSharpDirectory + @"\NiceGuySharp\";


        public static string OnGameStartTxt;
        public static string OnDeathTxt;
        public static string OnGameEndTxt;

        public static string OnKillTxt;
        public static string OnDoubleTxt;
        public static string OnTripleTxt;
        public static string OnQuadraTxt;
        public static string OnPentaTxt;

        public static string OnAllyKillTxt;
        public static string OnAllyDeathTxt;
        public static string OnAllyDoubleTxt;
        public static string OnAllyTripleTxt;
        public static string OnAllyQuadraTxt;
        public static string OnAllyPentaTxt;

        public static string OnEnemyKillTxt;
        public static string OnEnemyDoubleTxt;
        public static string OnEnemyTripleTxt;
        public static string OnEnemyQuadraTxt;
        public static string OnEnemyPentaTxt;

        public static string[] ParseFile(Type file)
        {
            if (file != null)
            {

            }
            return new string[1];
        }

        public static void DoChecks()
        {
            OnGameStartTxt = Folder + "OnGameStart.txt";
            OnGameEndTxt = Folder + "OnGameEnd.txt";

            OnKillTxt = Folder + "OnKill.txt";
            OnDeathTxt = Folder + "OnDeath.txt";
            OnDoubleTxt = Folder + "OnDouble.txt";
            OnTripleTxt = Folder + "OnTriple.txt";
            OnQuadraTxt = Folder + "OnQuadra.txt";
            OnPentaTxt = Folder + "OnPenta.txt";

            OnAllyKillTxt = Folder + "OnAllyKill.txt";
            OnAllyDeathTxt = Folder + "OnAllyDeath.txt";
            OnAllyDoubleTxt = Folder + "OnAllyDouble.txt";
            OnAllyTripleTxt = Folder + "OnAllyTriple.txt";
            OnAllyQuadraTxt = Folder + "OnAllyQuadra.txt";
            OnAllyPentaTxt = Folder + "OnAllyPenta.txt";

            OnEnemyKillTxt = Folder + "OnEnemyKill.txt";
            OnEnemyDoubleTxt = Folder + "OnEnemyDouble.txt";
            OnEnemyTripleTxt = Folder + "OnEnemyTriple.txt";
            OnEnemyQuadraTxt = Folder + "OnEnemyQuadra.txt";
            OnEnemyPentaTxt = Folder + "OnEnemyPenta.txt";

            if (!Directory.Exists(Folder))
            {
                Game.PrintChat("You have ran Nice-Guy Sharp for the first time");
                Game.PrintChat("Please add your phrases here:");
                Game.PrintChat(Folder);
                Game.PrintChat("and reload the assembly.");
                Directory.CreateDirectory(Folder);
            }
            if (!File.Exists(OnGameStartTxt))
            {
                var newfile = File.Create(OnGameStartTxt);
                newfile.Close();
                const string content = "glhf\ngl hf\ngalingan niyo po\ngoodluck po mga idol\nhello mga master haha";
                var separator = new[] { "\n" };
                string[] lines = content.Split(separator, StringSplitOptions.None);
                File.WriteAllLines(OnGameStartTxt, lines);
            }
            if (!File.Exists(OnDeathTxt))
            {
                var newfile = File.Create(OnDeathTxt);
                newfile.Close();
                const string content = "lag";
                var separator = new[] { "\n" };
                string[] lines = content.Split(separator, StringSplitOptions.None);
                File.WriteAllLines(OnDeathTxt, lines);
            }
            if (!File.Exists(OnGameEndTxt))
            {
                var newfile = File.Create(OnGameEndTxt);
                newfile.Close();
                const string content = "pa HONOR po thanks\nHonor nalang!";
                var separator = new[] { "\n" };
                string[] lines = content.Split(separator, StringSplitOptions.None);
                File.WriteAllLines(OnGameEndTxt, lines);
            }
            if (!File.Exists(OnKillTxt))
            {
                var newfile = File.Create(OnKillTxt);
                newfile.Close();
                const string content = " wtf\nnays wan\nlol\nlakas\nidol\nhaha\nn1\nnice one\ngj\nnice\naydul\nlakas naman niyan\nlokosh oh!\nmaster!\ngg";
                var separator = new[] { "\n" };
                string[] lines = content.Split(separator, StringSplitOptions.None);
                File.WriteAllLines(OnKillTxt, lines);
            }
            if (!File.Exists(OnDoubleTxt))
            {
                var newfile = File.Create(OnDoubleTxt);
                newfile.Close();
                const string content = "lakas mo master\ngaling!\nhaha lakas!\ngg";
                var separator = new[] { "\n" };
                string[] lines = content.Split(separator, StringSplitOptions.None);
                File.WriteAllLines(OnDoubleTxt, lines);
            }
            if (!File.Exists(OnTripleTxt))
            {
                var newfile = File.Create(OnTripleTxt);
                newfile.Close();
                const string content = "master!\nidol!";
                var separator = new[] { "\n" };
                string[] lines = content.Split(separator, StringSplitOptions.None);
                File.WriteAllLines(OnTripleTxt, lines);
            }
            if (!File.Exists(OnQuadraTxt))
            {
                var newfile = File.Create(OnQuadraTxt);
                newfile.Close();
                const string content = "penta\nidol ko yan!\nmaster ko yan!\nlakas mo men!";
                var separator = new[] { "\n" };
                string[] lines = content.Split(separator, StringSplitOptions.None);
                File.WriteAllLines(OnQuadraTxt, lines);
            }
            if (!File.Exists(OnPentaTxt))
            {
                var newfile = File.Create(OnPentaTxt);
                newfile.Close();
                const string content = "iloveyou master!\niloveyou idol!\nhahahaha tangina idol\nPenta <3";
                var separator = new[] { "\n" };
                string[] lines = content.Split(separator, StringSplitOptions.None);
                File.WriteAllLines(OnPentaTxt, lines);
            }
            if (!File.Exists(OnAllyKillTxt))
            {
                var newfile = File.Create(OnAllyKillTxt);
                newfile.Close();
            } 
            if (!File.Exists(OnAllyDeathTxt))
            {
                var newfile = File.Create(OnAllyDeathTxt);
                newfile.Close();
            }
            if (!File.Exists(OnAllyDoubleTxt))
            {
                var newfile = File.Create(OnAllyDoubleTxt);
                newfile.Close();
            }
            if (!File.Exists(OnAllyTripleTxt))
            {
                var newfile = File.Create(OnAllyTripleTxt);
                newfile.Close();
            }
            if (!File.Exists(OnAllyQuadraTxt))
            {
                var newfile = File.Create(OnAllyQuadraTxt);
                newfile.Close();
            }
            if (!File.Exists(OnAllyPentaTxt))
            {
                var newfile = File.Create(OnAllyPentaTxt);
                newfile.Close();
            }
            if (!File.Exists(OnEnemyKillTxt))
            {
                var newfile = File.Create(OnEnemyKillTxt);
                newfile.Close();
            }
            if (!File.Exists(OnEnemyDoubleTxt))
            {
                var newfile = File.Create(OnEnemyDoubleTxt);
                newfile.Close();
            }
            if (!File.Exists(OnEnemyTripleTxt))
            {
                var newfile = File.Create(OnEnemyTripleTxt);
                newfile.Close();
            }
            if (!File.Exists(OnEnemyQuadraTxt))
            {
                var newfile = File.Create(OnEnemyQuadraTxt);
                newfile.Close();
            }
            if (!File.Exists(OnEnemyPentaTxt))
            {
                var newfile = File.Create(OnEnemyPentaTxt);
                newfile.Close();
            }
        }
    }
}
