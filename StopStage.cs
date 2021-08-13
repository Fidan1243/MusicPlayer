using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class StopStage : Stage
    {
        public Player player { get; set; }

        public void ClickPause()
        {
            var pause = new PauseStage();
            pause.player = player;
            player.ChangeState(pause);
            player.Pause();
        }

        public void ClickPlay()
        {
            var play = new ReadyState();
            play.player = player;
            player.ChangeState(play);
            player.Play();
        }

        public void ClickStop()
        {
            player.CurrentMelody.Stop();
        }
    }
}
