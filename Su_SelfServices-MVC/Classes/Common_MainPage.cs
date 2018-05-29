using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class MenuTabs
{
    public int TapId { get; set; }
    public string TapTitle { get; set; }
    public string URL { get; set; }

}

public class SubMenuTaps
{
    public int ParentTap { get; set; }
    public int SubTapId { get; set; }
    public int SubTapTitle { get; set; }
}

public class TapItems
{
    public int TapItemId { get; set; }
    public int TapItemTitle { get; set; }
    public int ParentSubTapId { get; set; }
}
/// <summary>
/// Summary description for Common_MainPage
/// </summary>
public class Common_MainPage
{
    public Common_MainPage()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public List<MenuTabs> GetMainTaps()
    {
        List<MenuTabs> tapList = new List<MenuTabs>();
        tapList.Add(new MenuTabs() { TapId = 1, TapTitle = "Home", URL = @"~/StaticPages/Home.aspx" });
        tapList.Add(new MenuTabs() { TapId = 2, TapTitle = "Student", URL = @"~/StaticPages/Student.aspx" });
        tapList.Add(new MenuTabs() { TapId = 3, TapTitle = "Alumni", URL = @"~/StaticPages/Home.aspx" });
        tapList.Add(new MenuTabs() { TapId = 4, TapTitle = "Employee", URL = @"~/StaticPages/Home.aspx" });
        tapList.Add(new MenuTabs() { TapId = 5, TapTitle = "Academic Staff", URL = @"~/StaticPages/Home.aspx" });
        tapList.Add(new MenuTabs() { TapId = 6, TapTitle = "Applicant", URL = @"~/StaticPages/Home.aspx" });

        return tapList;
    }

    public List<SubMenuTaps> GetSubMenu(int ParentId)
    {
        List<SubMenuTaps> SubList = new List<SubMenuTaps>();
        SubList.Add(new SubMenuTaps() { ParentTap = ParentId });
        return SubList;
    }
}