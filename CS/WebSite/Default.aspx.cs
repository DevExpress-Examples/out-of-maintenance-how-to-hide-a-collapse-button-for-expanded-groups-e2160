using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxGridView;
using System.Drawing;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }
    protected void grid_HtmlRowPrepared(object sender, ASPxGridViewTableRowEventArgs e) {
        if (e.RowType != GridViewRowType.Group)
            return;

        if (!grid.IsRowExpanded(e.VisibleIndex))
            return;

        int level = grid.GetRowLevel(e.VisibleIndex);
        if (e.Row.Cells.Count <= level)
            return;

        ControlCollection controls = e.Row.Cells[level].Controls;
        if (controls.Count > 0)
            controls[0].Visible = false;
    }
}
