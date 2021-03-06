using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using System.Diagnostics;

namespace IExternalCommand_v2019
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        UIApplication uiApp = null;
        Document doc = null;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(UIApplication incomingUIApp)
        {
            InitializeComponent();
            uiApp = incomingUIApp;
            doc = uiApp.ActiveUIDocument.Document;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            XMLSettings.CreateAppSettings_SetDefaults();
        }
    }
}
