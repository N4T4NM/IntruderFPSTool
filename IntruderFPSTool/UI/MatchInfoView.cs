using IntruderFPSTool.API;
using IntruderFPSTool.API.Objects;
using IntruderFPSTool.API.Rest;
using IntruderFPSTool.Utils;
using System.Diagnostics;

namespace IntruderFPSTool.UI
{
    public partial class MatchInfoView : UserControl
    {
        public MatchInfoView()
        {
            InitializeComponent();
        }

        public RoomInfoView? RoomView { get; init; }
        public MatchInfoView(RoomInfoView view)
        {
            InitializeComponent();
            RoomView = view;
            view.RoomUpdated += OnRoomUpdated;

        }

        private void MatchInfoView_Load(object sender, EventArgs e) => UpdateRoom();

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(RoomView!);
            Dispose();
        }

        private void updateRoom_Click(object sender, EventArgs e) => UpdateRoom();

        void UpdateRoom()
        {
            this.Enabled = false;
            backButton.Enabled = false;
            updateRoom.Enabled = false;
            RoomView!.UpdateRoom();
        }

        private void OnRoomUpdated(Room room, bool success)
        {
            if (!success)
            {
                Dispose();
                return;
            }

            currentMapLnk.Text = $"Current Map: {room.CurrentMap.Name}";
            mapsList.Items.Clear();
            foreach (Map map in room.Maps)
            {
                ListViewItem item = new(map.Name);
                item.SubItems.Add(map.Author.Name);
                item.Tag = map;

                mapsList.Items.Add(item);
            }

            agentsInfoBox.Text = $"Agents Info ( {room.AgentCount}/{room.MaxAgents} )";
            roomCreatorLnk.Text = $"Room Creator: {room.Creator.Name}";
            agentsList.Items.Clear();

            this.Enabled = true;
            this.DispatchAsyncTask(UpdateAgentsAsync(), OnAgentsUpdated);
            SetScores();
        }

        private async Task<IReadOnlyList<(Agent, Stats)>> UpdateAgentsAsync()
        {
            APIResponse<IReadOnlyList<Agent>> agents = await new GetAgents(RoomView!.Room!.Id).SendAsync();
            List<(Agent, Stats)> result = new();

            int i = 0;
            while(i < agents.Response!.Count)
            {
                Agent agent = agents.Response![i];
                APIResponse<Stats> stats = await new GetAgentStats(agent.SteamId).SendAsync();
                result.Add((agent, stats.Response!));
                i++;
            }

            return result;
        }

        void OnAgentsUpdated(IReadOnlyList<(Agent agent, Stats stats)> data)
        {
            agentsList.Items.Clear();
            foreach((Agent agent, Stats stats) item in data)
            {
                ListViewItem lvi = new(item.agent.Name);
                lvi.SubItems.Add(item.stats.Level.ToString());
                lvi.SubItems.Add($"{item.stats.LevelXp}/{item.stats.LevelXpRequired}");
                lvi.Tag = item.agent;

                agentsList.Items.Add(lvi);
            }

            updateRoom.Enabled = true;
            backButton.Enabled = true;
        }


        void SetScores()
        {
            scoresList.Items.Clear();

            int guards = 0;
            int intruders = 0;

            if (RoomView!.Room!.Scores != null)
            {
                for(int i=0; i < RoomView!.Room!.Scores.Count; i++)
                {
                    SetScore set = RoomView!.Room!.Scores[i];

                    ListViewItem item = new(i.ToString());
                    item.SubItems.Add(set.Guards.ToString());
                    item.SubItems.Add(set.Intruders.ToString());

                    if(set.Guards == set.Intruders)
                        item.ForeColor = Color.Black;
                    else if(set.Guards > set.Intruders)
                    {
                        guards++;
                        item.ForeColor = Color.DarkBlue;
                    } else
                    {
                        intruders++;
                        item.ForeColor = Color.DarkOrange;
                    }

                    scoresList.Items.Add(item);
                    roundsInfoGroup.Text = $"Rounds Info ( Guards => {guards} x {intruders} <= Intruders )";
                }
            }
            else roundsInfoGroup.Text = $"Rounds Info ( Not Avaiable )";
        }
       
        private void currentMap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!RoomView!.Room!.CurrentMap.IsMapMakerMap) return;

            string url = $"https://steamcommunity.com/sharedfiles/filedetails/?id={RoomView!.Room!.CurrentMap.Id}";
            Process.Start("cmd", $"/C start {url}");
        }

        private void roomCreatorLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = $"https://intruderfps.com/agents/{RoomView!.Room!.Creator.SteamId}";
            Process.Start("cmd", $"/C start {url}");
        }

        private void mapsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (mapsList.SelectedItems.Count != 1) return;

            Map map = (Map)mapsList.SelectedItems[0].Tag;
            if (!map.IsMapMakerMap) return;

            string url = $"https://steamcommunity.com/sharedfiles/filedetails/?id={map.Id}";
            Process.Start("cmd", $"/C start {url}");
        }

        private void agentsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (agentsList.SelectedItems.Count != 1) return;

            Agent agent = (Agent)agentsList.SelectedItems[0].Tag;

            string url = $"https://intruderfps.com/agents/{agent.SteamId}";
            Process.Start("cmd", $"/C start {url}");
        }
    }
}
