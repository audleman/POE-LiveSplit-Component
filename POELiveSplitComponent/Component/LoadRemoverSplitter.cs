using System;
using LiveSplit.Model;
using System.Collections.Generic;

namespace POELiveSplitComponent.Component
{
    class LoadRemoverSplitter
    {
        // Zone that lab runners must enter before the lab. Unique zone name.
        private LiveSplitState state;
        private ComponentSettings settings;
        private TimerModel timer;
        private long loadTimes = 0;
        private long? startTimestamp;
        private HashSet<int> encounteredLevels = new HashSet<int>();
        private IZone previousZone;

        public LoadRemoverSplitter(LiveSplitState state, ComponentSettings settings)
        {
            this.state = state;
            this.settings = settings;
            timer = new TimerModel();
            timer.CurrentState = state;
            state.OnStart += HandleResetRuns;
        }

        public void HandleLevelUp(int level)
        {
            //while (timer.CurrentState.CurrentSplitIndex < level)
            //{
            timer.Split();
            //}
        }

        private void HandleResetRuns(object sender, EventArgs e)
        {
            loadTimes = 0;
            startTimestamp = null;
            encounteredLevels = new HashSet<int>();
        }
    }
}