using HarmonyLib;
using VRage.Plugins;

namespace SEPluginTemplate
{
    public class Main : IPlugin
    {
        /// <summary>
        /// Optional, is not required.
        /// </summary>
        public void Startup()
        {

        }

        /// <summary>
        /// This method is required regardless if you are using it or not. If you are not using it, then just don't put anything in the method.
        /// </summary>
        public void Dispose()
        {
            
        }

        /// <summary>
        /// This method is required regardless if you are using it or not. If you are not using it, then just don't put anything in the method.
        /// </summary>
        public void Init(object gameInstance)
        {
            //Use the code below in this method if you are planning on using Harmony to modify existing game methods. Optional, is not required. You may need to put this code in the other methods shown if Harmony does not seem to work. For more info about how harmony works, go to https://harmony.pardeike.net/

            // Starts an instance of Harmony
            Harmony harmony = new Harmony("SEPluginTemplate");
            // Patches all patches in the plugin.
            harmony.PatchAll();
        }

        /// <summary>
        /// This method is required regardless if you are using it or not. If you are not using it, then just don't put anything in the method.
        /// </summary>
        public void Update()
        {
            
        }
    }
}
