using EditorCore;
using EditorCore.Interfaces;
using SARCExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CTTT3DSExt
{
	class CTTT3DSExt : ExtensionManifest
	{
		public string ModuleName => "CTTT3DSEXT";
		public string Author => "Exelix11";
		public string ExtraText => null;

		public Version TargetVersion => new Version(2, 0, 0, 0);
		
		public IMenuExtension MenuExt => new MenuExt();
		
		public bool HasGameModule => true;

		public IFileHander[] Handlers => null;

		public void CheckForUpdates() { }

		public IGameModule GetNewGameModule() => new CTTT3DSModule();
	}

	class MenuExt : IMenuExtension
	{ 
		public ToolStripMenuItem[] FileMenuExtensions { get; internal set; }

        public ToolStripMenuItem[] ToolsMenuExtensions { get; internal set; }

		public ToolStripMenuItem[] TitleBarExtensions { get; internal set; }
		public MenuExt()
		{
			FileMenuExtensions = new ToolStripMenuItem[]
			{
                new ToolStripMenuItem(){ Text = "StageList"}
            };
            FileMenuExtensions[0].Click += StageList;
        }

        public void StageList(object sender, EventArgs e)
		{
			var xmlpath = "Ext/StageList.xml";
		    XDocument document = XDocument.Load(xmlpath);
			var li = document.Descendants("T209")
				.FirstOrDefault()
				.Element("T160");
			

        }
    }
}

