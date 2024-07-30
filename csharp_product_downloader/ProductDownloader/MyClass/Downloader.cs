using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ProductDownloader.MyClass
{
    class Downloader
    {
        public void Download(String url, String filename, String targetPath, String objName, String relativeID)
        {
            try
            {
                using (var client = new WebClient())
                {
                    /* Create a Uri*/
                    Uri _uri = new Uri(url);

                    /* Save to computer */
                    client.DownloadFile(_uri, targetPath + "\\" + filename);
                }
            }
            catch
            {
                // missing file...
                MissingFile file = new MissingFile
                {
                    id = relativeID,
                    name = objName,
                    targetpath = targetPath,
                    filename = filename,
                    url = url,
                };
               
    
                /* Read Ticket File */
                string files = File.ReadAllText(targetPath + "\\" + new FormMain().missingFilesName);
                MissingFiles mFiles = JsonConvert.DeserializeObject<MissingFiles>(files);


                /* Update Array */
                mFiles.itemCount++;
                mFiles.missingFiles.Add(file);

                /* Write Missing File */
                string newMissingFiles = JsonConvert.SerializeObject(mFiles);
                File.WriteAllText(targetPath + "\\" + new FormMain().missingFilesName, newMissingFiles);
            }
        }

        public void Download_Children(List<Child> children, String targetPath, System.Windows.Forms.Label myLabel, System.Windows.Forms.ProgressBar myProgress)
        {
            for (int i = 0; i < children.Count; i++)
            {
                /* Current Childrem */
                Child curChild = children[i];

                /* Update Label */
                myLabel.Text = curChild.name + " downloading...";
                myLabel.Refresh();

                /* Update Progressbar */
                if (curChild.level == 1)
                {
                    myProgress.Value = myProgress.Value + myProgress.Step;
                    myProgress.Refresh();
                }

                /* Download current child */
                Download(curChild.downloadTicket.url, curChild.downloadTicket.name, targetPath, curChild.name, curChild.id);

                /* Download current child children */
                Download_Children(curChild.children, targetPath, myLabel, myProgress);

                /* Download Drawing if exist */
                if (curChild.drawings.Count > 0)
                {
                    for (int j = 0; j < curChild.drawings.Count; j++) {
                        /* Update label tag */
                        myLabel.Text = curChild.drawings[j].downloadTicket.name + " downloading...";
                        myLabel.Refresh();

                        /* Download drawing */
                        Download(curChild.drawings[j].downloadTicket.url, curChild.drawings[j].downloadTicket.name, targetPath, curChild.drawings[j].info.name, curChild.drawings[j].info.id);
                    }
                }
            }
        }
    }
}
