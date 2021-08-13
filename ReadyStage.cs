using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class ReadyState : Stage
    {
        public Player player { get; set; }

        public void ClickPlay()
        {
            player.CurrentMelody.Play();
        }

        public void ClickStop()
        {
            var stop = new StopStage();
            stop.player = player;
            player.ChangeState(stop);
            player.Stop();
        }

        public void ClickPause()
        {
            var pause = new PauseStage();
            pause.player = player;
            player.ChangeState(pause);
            player.Pause();
        }
    }
}
