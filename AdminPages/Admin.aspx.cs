using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;
public partial class AdminPages_Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void AddFriendly_Click(object sender, EventArgs e)
    {

    }

    protected void AddHostile_Click(object sender, EventArgs e)
    {

    }

    public void AddEntryToCsv(string file,string text)
    {
        File.AppendAllText(file,text);
    }
}