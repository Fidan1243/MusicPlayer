using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class PauseStage : Stage
    {
        public Player player { get; set; }

        public void ClickPause()
        {
            player.CurrentMelody.Pause();
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
            var stop = new StopStage();
            stop.player = player;
            player.ChangeState(stop);
            player.Stop();
        }
    }
}
