using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProductDownloader.MyClass
{
    class Notifications
    {

        public NotifyIcon notifier;

        public void Push_Notification(String title, String body)
        {
            notifier.BalloonTipText = title;
            notifier.BalloonTipTitle = body;
            notifier.Icon = SystemIcons.Information;
            notifier.ShowBalloonTip(50000);

        }

        public int Calculate_Progress_Increment(DownloadTicketFile downloadTicket)
        {
            int x = 0;
            for (int i = 0; i < downloadTicket.totalFolder; i++)
            {
                int y = downloadTicket.items[i].children.Count;
                x = x + y;
            }

            return x + downloadTicket.totalFolder;
        }

        public void notif_onClick(object sender, EventArgs e)
        {
            
        }
    }
}
