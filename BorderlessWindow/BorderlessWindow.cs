using MelonLoader;
using UnityEngine;

[assembly: MelonGame()]
[assembly: MelonInfo(typeof(BorderlessWindow.BorderlessWindow), "BorderlessWindow", null, "xKiraiChan#8315", "github.com/xKiraiChan/BorderlessWindow")]

namespace BorderlessWindow
{
    public class BorderlessWindow : MelonMod
    {
        public override void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.F11))
                Screen.SetResolution(int.MaxValue, int.MaxValue, true);
        }
    }
}
