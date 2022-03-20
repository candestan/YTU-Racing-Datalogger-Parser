using WindowsUI;

namespace YTR_Datalogger_Parser
{
    public partial class Main : WinForm
    {
        public Main()
        {
            InitializeComponent();
            DragEnter += new DragEventHandler(Main_DragEnter);
            DragDrop += new DragEventHandler(Main_DragDrop);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            Globals.FilePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in Globals.FilePaths)
            {
                var ext = Path.GetExtension(file);
                if (ext.Equals(".csv", StringComparison.CurrentCultureIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy;
                    AllowDrop = false;
                    picCSV.Visible = false;
                    pnlDragDrop.Title = "File: " + Globals.FilePaths[0];
                    Refresh();
                    return;
                }
                else
                {
                    Array.Clear(Globals.FilePaths, 0, Globals.FilePaths.Length);
                    MessageBox.Show("Please insert a '.csv' file.", "YTR Datalogger Parser", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutPage aboutPage = new AboutPage();
            aboutPage.Show();
        }
    }
}