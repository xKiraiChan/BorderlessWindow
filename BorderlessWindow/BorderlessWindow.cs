using MelonLoader;
using UnityEngine;

[assembly: MelonGame()]
[assembly: MelonInfo(typeof(BorderlessWindow.BorderlessWindow), "BorderlessWindow", "0", "xKiraiChan#8315", "github.com/xKiraiChan/BorderlessWindow")]

namespace BorderlessWindow
{
    public class BorderlessWindow : MelonMod
    {
        public override void OnApplicationStart()
        {
            Screen.SetResolution(int.MaxValue, int.MaxValue, true);
        }
    }
}
