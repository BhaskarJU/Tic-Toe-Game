using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Drawing;

namespace firstWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {               
            }
            else
            {
                if (ViewState["Clicks"] != null)
                {
                    ClicksCount = (int)ViewState["Clicks"] + 1;
                }
                ViewState["Clicks"] = ClicksCount;               
            }
        }

        protected void cell1_Click(object sender, EventArgs e)
        {
            if (ViewState["move"].ToString() == "p1" && ((int)ViewState["Clicks"]) % 2 != 0)
            {
                cell1.Text = "X";

            }
            else
            {
                cell1.Text = "O";
            }
            string temp;
            if (ViewState["row1"] == null)
            {
                ViewState["row1"] = cell1.Text;
            }
            else
            {
                temp = ViewState["row1"].ToString();
                temp += cell1.Text;
                ViewState["row1"] = temp;
            }
            if (ViewState["diag1"] == null)
            {
                ViewState["diag1"] = cell1.Text;
            }
            else
            {
                temp = ViewState["diag1"].ToString();
                temp += cell1.Text;
                ViewState["diag1"] = temp;
            }
            if (ViewState["col1"] == null)
            {
                ViewState["col1"] = cell1.Text;
            }
            else
            {
                temp = ViewState["col1"].ToString();
                temp += cell1.Text;
                ViewState["col1"] = temp;
            }
            cell1.Enabled = false;
            cell1.ToolTip = "Can not Click";
            call();
        }

        protected void cell2_Click(object sender, EventArgs e)
        {
            if (ViewState["move"].ToString() == "p1" && ((int)ViewState["Clicks"]) % 2 != 0)
            {
                cell2.Text = "X";
            }
            else
            {
                cell2.Text = "O";
            }
            string temp;
            if (ViewState["row1"] == null)
            {
                ViewState["row1"] = cell2.Text;
            }
            else
            {
                temp = ViewState["row1"].ToString();
                temp += cell2.Text;
                ViewState["row1"] = temp;
            }
            if (ViewState["col2"] == null)
            {
                ViewState["col2"] = cell2.Text;
            }
            else
            {
                temp = ViewState["col2"].ToString();
                temp += cell2.Text;
                ViewState["col2"] = temp;
            }
            cell2.Enabled = false;
            cell2.ToolTip = "Can not Click";
            call();
        }

        protected void cell3_Click(object sender, EventArgs e)
        {
            if (ViewState["move"].ToString() == "p1" && ((int)ViewState["Clicks"]) % 2 != 0)
            {
                cell3.Text = "X";
            }
            else
            {
                cell3.Text = "O";
            }
            string temp;
            if (ViewState["row1"] == null)
            {
                ViewState["row1"] = cell3.Text;
            }
            else
            {
                temp = ViewState["row1"].ToString();
                temp += cell3.Text;
                ViewState["row1"] = temp;
            }
            if (ViewState["diag2"] == null)
            {
                ViewState["diag2"] = cell3.Text;
            }
            else
            {
                temp = ViewState["diag2"].ToString();
                temp += cell3.Text;
                ViewState["diag2"] = temp;
            }
            if (ViewState["col3"] == null)
            {
                ViewState["col3"] = cell3.Text;
            }
            else
            {
                temp = ViewState["col3"].ToString();
                temp += cell3.Text;
                ViewState["col3"] = temp;
            }
            cell3.Enabled = false;
            cell3.ToolTip = "Can not Click";
            call();
        }

        protected void cell4_Click(object sender, EventArgs e)
        {
            if (ViewState["move"].ToString() == "p1" && ((int)ViewState["Clicks"]) % 2 != 0)
            {
                cell4.Text = "X";
            }
            else
            {
                cell4.Text = "O";
            }
            string temp;
            if (ViewState["row2"] == null)
            {
                ViewState["row2"] = cell4.Text;
            }
            else
            {
                temp = ViewState["row2"].ToString();
                temp += cell4.Text;
                ViewState["row2"] = temp;
            }
            if (ViewState["col1"] == null)
            {
                ViewState["col1"] = cell4.Text;
            }
            else
            {
                temp = ViewState["col1"].ToString();
                temp += cell4.Text;
                ViewState["col1"] = temp;
            }
            cell4.Enabled = false;
            cell4.ToolTip = "Can not Click";
            call();
        }

        protected void cell5_Click(object sender, EventArgs e)
        {
            if (ViewState["move"].ToString() == "p1" && ((int)ViewState["Clicks"]) % 2 != 0)
            {
                cell5.Text = "X";
            }
            else
            {
                cell5.Text = "O";
            }
            string temp;
            if (ViewState["row2"] == null)
            {
                ViewState["row2"] = cell5.Text;
            }
            else
            {
                temp = ViewState["row2"].ToString();
                temp += cell5.Text;
                ViewState["row2"] = temp;
            }
            if (ViewState["diag1"] == null)
            {
                ViewState["diag1"] = cell5.Text;
            }
            else
            {
                temp = ViewState["diag1"].ToString();
                temp += cell5.Text;
                ViewState["diag1"] = temp;
            }
            if (ViewState["diag2"] == null)
            {
                ViewState["diag2"] = cell5.Text;
            }
            else
            {
                temp = ViewState["diag2"].ToString();
                temp += cell5.Text;
                ViewState["diag2"] = temp;
            }
            if (ViewState["col2"] == null)
            {
                ViewState["col2"] = cell5.Text;
            }
            else
            {
                temp = ViewState["col2"].ToString();
                temp += cell5.Text;
                ViewState["col2"] = temp;
            }
            cell5.Enabled = false;
            cell5.ToolTip = "Can not Click";
            call();
        }

        protected void cell6_Click(object sender, EventArgs e)
        {
            if (ViewState["move"].ToString() == "p1" && ((int)ViewState["Clicks"]) % 2 != 0)
            {
                cell6.Text = "X";
            }
            else
            {
                cell6.Text = "O";
            }
            string temp;
            if (ViewState["row2"] == null)
            {
                ViewState["row2"] = cell6.Text;
            }
            else
            {
                temp = ViewState["row2"].ToString();
                temp += cell6.Text;
                ViewState["row2"] = temp;
            }
            if (ViewState["col3"] == null)
            {
                ViewState["col3"] = cell6.Text;
            }
            else
            {
                temp = ViewState["col3"].ToString();
                temp += cell6.Text;
                ViewState["col3"] = temp;
            }
            cell6.Enabled = false;
            cell6.ToolTip = "Can not Click";
            call();
        }

        protected void cell7_Click(object sender, EventArgs e)
        {
            if (ViewState["move"].ToString() == "p1" && ((int)ViewState["Clicks"]) % 2 != 0)
            {
                cell7.Text = "X";
            }
            else
            {
                cell7.Text = "O";
            }
            string temp;
            if (ViewState["row3"] == null)
            {
                ViewState["row3"] = cell7.Text;
            }
            else
            {
                temp = ViewState["row3"].ToString();
                temp += cell7.Text;
                ViewState["row3"] = temp;
            }
            if (ViewState["diag2"] == null)
            {
                ViewState["diag2"] = cell7.Text;
            }
            else
            {
                temp = ViewState["diag2"].ToString();
                temp += cell7.Text;
                ViewState["diag2"] = temp;
            }
            if (ViewState["col1"] == null)
            {
                ViewState["col1"] = cell7.Text;
            }
            else
            {
                temp = ViewState["col1"].ToString();
                temp += cell7.Text;
                ViewState["col1"] = temp;
            }
            cell7.Enabled = false;
            cell7.ToolTip = "Can not Click";
            call();
        }

        protected void cell8_Click(object sender, EventArgs e)
        {
            if (ViewState["move"].ToString() == "p1" && ((int)ViewState["Clicks"]) % 2 != 0)
            {
                cell8.Text = "X";
            }
            else
            {
                cell8.Text = "O";
            }
            string temp;
            if (ViewState["row3"] == null)
            {
                ViewState["row3"] = cell8.Text;
            }
            else
            {
                temp = ViewState["row3"].ToString();
                temp += cell8.Text;
                ViewState["row3"] = temp;
            }
            if (ViewState["col2"] == null)
            {
                ViewState["col2"] = cell8.Text;
            }
            else
            {
                temp = ViewState["col2"].ToString();
                temp += cell8.Text;
                ViewState["col2"] = temp;
            }
            cell8.Enabled = false;
            cell8.ToolTip = "Can not Click";
            call();
        }

        protected void cell9_Click(object sender, EventArgs e)
        {
            if (ViewState["move"].ToString() == "p1" && ((int)ViewState["Clicks"]) % 2 != 0)
            {
                cell9.Text = "X";
            }
            else
            {
                cell9.Text = "O";
            }
            string temp;
            if (ViewState["row3"] == null)
            {
                ViewState["row3"] = cell9.Text;
            }
            else
            {
                temp = ViewState["row3"].ToString();
                temp += cell9.Text;
                ViewState["row3"] = temp;
            }
            if (ViewState["diag1"] == null)
            {
                ViewState["diag1"] = cell9.Text;
            }
            else
            {
                temp = ViewState["diag1"].ToString();
                temp += cell9.Text;
                ViewState["diag1"] = temp;
            }
            if (ViewState["col3"] == null)
            {
                ViewState["col3"] = cell9.Text;
            }
            else
            {
                temp = ViewState["col3"].ToString();
                temp += cell9.Text;
                ViewState["col3"] = temp;
            }
            cell9.Enabled = false;
            cell9.ToolTip = "Can not Click";
            call();
        }

        protected void player1_Click(object sender, EventArgs e)
        {
            ViewState["move"] = "p1";
        }

        protected void player2_Click(object sender, EventArgs e)
        {
            ViewState["move"] = "p1";

        }

        public void call()
        {
            if (ClicksCount >= 5)
            {
                string temp = check();
                if (temp != null)
                {
                    if (ViewState[temp].ToString() == "XXX")
                    {
                        msg.Text = "Player 1 WON..Hurray!!!!";                     
                    }
                    else
                    {
                        msg1.Text = "Player 2 WON..Hurray!!!!";
                        msg.Text = "";
                    }
                    if (cell1.Text == "cell1")
                    {
                        cell1.Enabled = false;
                        cell1.ToolTip = "Can not Click.";
                    }
                    if (cell2.Text == "cell2")
                    {
                        cell2.Enabled = false;
                        cell2.ToolTip = "Can not Click.";
                    }
                    if (cell3.Text == "cell3")
                    {
                        cell3.Enabled = false;
                        cell3.ToolTip = "Can not Click.";
                    }
                    if (cell4.Text == "cell4")
                    {
                        cell4.Enabled = false;
                        cell4.ToolTip = "Can not Click.";
                    }
                    if (cell5.Text == "cell5")
                    {
                        cell5.Enabled = false;
                        cell5.ToolTip = "Can not Click.";
                    }
                    if (cell6.Text == "cell6")
                    {
                        cell6.Enabled = false;
                        cell6.ToolTip = "Can not Click.";
                    }
                    if (cell7.Text == "cell7")
                    {
                        cell7.Enabled = false;
                        cell7.ToolTip = "Can not Click.";
                    }
                    if (cell8.Text == "cell8")
                    {
                        cell8.Enabled = false;
                        cell8.ToolTip = "Can not Click.";
                    }
                    if (cell9.Text == "cell9")
                    {
                        cell9.Enabled = false;
                        cell9.ToolTip = "Can not Click.";
                    }
                }
            }
            if (ClicksCount == 9 && msg.Text == "")
            {
                msg.Text = "Match Drawn!!!!"+ "<br/>" + "Play Again...";               
            }
        }

        public string check()
        {
            if (ViewState["row1"] != null && (ViewState["row1"].ToString() == "XXX" || ViewState["row1"].ToString() == "OOO"))
                return "row1";
            if (ViewState["row2"] != null && (ViewState["row2"].ToString() == "XXX" || ViewState["row2"].ToString() == "OOO"))
                return "row2";
            if (ViewState["row3"] != null && (ViewState["row3"].ToString() == "XXX" || ViewState["row3"].ToString() == "OOO"))
                return "row3";
            if (ViewState["col1"] != null && (ViewState["col1"].ToString() == "XXX" || ViewState["col1"].ToString() == "OOO"))
                return "col1";
            if (ViewState["col2"] != null && (ViewState["col2"].ToString() == "XXX" || ViewState["col2"].ToString() == "OOO"))
                return "col2";
            if (ViewState["col3"] != null && (ViewState["col3"].ToString() == "XXX" || ViewState["col3"].ToString() == "OOO"))
                return "col3";
            if (ViewState["diag1"] != null && (ViewState["diag1"].ToString() == "XXX" || ViewState["diag1"].ToString() == "OOO"))
                return "diag1";
            if (ViewState["diag2"] != null && (ViewState["diag2"].ToString() == "XXX" || ViewState["diag2"].ToString() == "OOO"))
                return "diag2";
            return null;
        }
    }
}