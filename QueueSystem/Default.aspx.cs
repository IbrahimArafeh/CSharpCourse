using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueueSystem
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["TokenQueue"] == null)
            {
                Queue<int> tokenQueue = new Queue<int>();
                Session["TokenQueue"]  = tokenQueue;
            }    

        }

        protected void btnPrintToken_Click(object sender, EventArgs e)
        {
            Queue<int> tokenQuey = (Queue<int>)Session["TokenQueue"];
            lblStatus.Text = "There are " + tokenQuey.Count.ToString() + " Customer are waiting before you";
            if (Session["LastTokenNumberToBeIssued"] == null)
            {
                Session["LastTokenNumberToBeIssued"] = 0;
            }
            int nextTokenNumberToBeIssued = (int)Session["LastTokenNumberToBeIssued"] + 1;
            Session["LastTokenNumberToBeIssued"] = nextTokenNumberToBeIssued;
            tokenQuey.Enqueue(nextTokenNumberToBeIssued);

            addTokenToListBox(tokenQuey);
        }

        private void addTokenToListBox(Queue<int> TokenQueue)
        {
            listTokens.Items.Clear();
            foreach (int token in TokenQueue)
            {
                listTokens.Items.Add(token.ToString());
            }
        }

        protected void btnCounter1_Click(object sender, EventArgs e)
        {
            TakeTokenAndAddToDisplay(textCounter1, 1);
        }

        protected void btnCounter2_Click(object sender, EventArgs e)
        {
            TakeTokenAndAddToDisplay(textCounter2, 2);
        }

        protected void btnCounter3_Click(object sender, EventArgs e)
        {
            TakeTokenAndAddToDisplay(textCounter3, 3);
        }

        private void TakeTokenAndAddToDisplay(TextBox txt,int counterNo)
        {
            Queue<int> tokenQueue = (Queue<int>)Session["TokenQueue"];
            if (tokenQueue == null)
            {
                txtDispaly.Text = "No Customer are Waiting";
            }
            else
            {
                int tokenIstakenByOtherUser = tokenQueue.Dequeue();
                txt.Text = tokenIstakenByOtherUser.ToString();
                txtDispaly.Text = "Token Number " + tokenIstakenByOtherUser.ToString() + " please go to Counter " + counterNo;
                addTokenToListBox(tokenQueue);

            }
        }
    }
}