using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Moving_Cube_yet
{
    class Class_staticsound
    {
        
        public static void bt_click()
        {
            SoundPlayer bt_click = new SoundPlayer();
            bt_click.SoundLocation = "data//sound//Bound01.wav";
            bt_click.Load();
            bt_click.Play();
        }
        public static void bt_click2()
        {
            SoundPlayer bt_click2 = new SoundPlayer();
            bt_click2.SoundLocation = "data//sound//Bound02.wav";
            bt_click2.Load();
            bt_click2.Play();
        }
        public static void bt_click2_sync()
        {
            SoundPlayer bt_click2_sync = new SoundPlayer();
            bt_click2_sync.SoundLocation = "data//sound//Bound02.wav";
            bt_click2_sync.Load();
            bt_click2_sync.PlaySync();
        }
        public static void bt_click3()
        {
            SoundPlayer bt_click3 = new SoundPlayer();
            bt_click3.SoundLocation = "data//sound//button_click.wav";
            bt_click3.Load();
            bt_click3.Play();
        }
    }
}
