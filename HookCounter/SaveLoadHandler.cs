using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookCounter
{
    /// <summary>
    /// Used to manage saving and loading user settings and keybinds in a readily accessible place.
    /// </summary>
    public static class SaveLoadHandler
    {
        /// <summary>
        /// Saves user settings and keybinds to a specified file path.
        /// This path refers to a folder, meaning this is also used to save settings to profiles as well.
        /// </summary>
        /// <param name="path">The path to the folder in which the files are to be saved.</param>
        /// <param name="settingsValues">A dictionary of all of the values for base settings to be saved to path.</param>
        /// <param name="keybindValues">A dictionary of all of the values for user keybinds to be saved to path.</param>
        public static void SaveSettings(string path, Dictionary<string, string> settingsValues, Dictionary<string, string> keybindValues)
        {
            string settingsPath = path + @"\Settings.txt",
                   keybindsPath = path + @"\Keybinds.txt"; //Set paths to start
            List<string> settingsLines = new List<string>();
            List<string> keybindLines = new List<string>();
            
            //Saving settings
            foreach(var keyPair in settingsValues) {
                settingsLines.Add(keyPair.Key + "=" + keyPair.Value);
            }

            //Saving keybinds
            foreach(var keyPair in keybindValues) {
                keybindLines.Add(keyPair.Key + "=" + keyPair.Value);
            }

            //Create files if they did not exist before.
            if (!File.Exists(settingsPath)) {
                FileStream create = File.Create(settingsPath);
                create.Close();
                Console.WriteLine("No settings path existed! Created it instead!");
            }
            if (!File.Exists(keybindsPath)) {
                FileStream create = File.Create(keybindsPath);
                create.Close();
                Console.WriteLine("No keybinds path existed! Created it instead!");
            }

            //Writing all lines to the files.
            File.WriteAllLines(settingsPath, settingsLines);
            File.WriteAllLines(keybindsPath, keybindLines);
        }

        public static void SetDefaultSettings() {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\HookCounter";
            
            Dictionary<string, string> defaultBaseValues = new Dictionary<string, string>() {
                { "OverridenHookSizeX", "50" },
                { "OverridenHookSizeY", "102" },
                { "SurvivorPadding", "130" },
                { "ChromaR", "0" },
                { "ChromaG", "255" },
                { "ChromaB", "0" }
            };

            Dictionary<string, string> defaultKeybinds = new Dictionary<string, string>() {
                { "SurvivorOneKey", "NumPad1" },
                { "SurvivorTwoKey", "NumPad2" },
                { "SurvivorThreeKey", "NumPad3" },
                { "SurvivorFourKey", "NumPad4" },
                { "ResetAllSurvivors", "NumPad0" },
                { "SendCounterDataKey", "NumPad8" },
                { "Exit", "NumPad7" },
                { "Help", "NumPad9" }
            };

            SaveSettings(path, defaultBaseValues, defaultKeybinds);
        }
    }
}
