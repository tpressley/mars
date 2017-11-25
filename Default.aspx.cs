using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        List<EsiInterface.StarSystem> systems = EsiInterface.EsiInterface.GetAllSystems();
        foreach (EsiInterface.StarSystem system in systems.Where(f => !string.IsNullOrWhiteSpace(f.alliance_id)))
        {
            ListItem systemListItem = new ListItem();
            systemListItem.Text = system.Name + "," + system.alliance_id + "," + system.system_id;
            TaskDebugBox.Items.Add(systemListItem);
        }
    }
}