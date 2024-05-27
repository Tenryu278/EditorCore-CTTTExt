﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.IO;
using System.Xml;
using System.Diagnostics;
using System.Drawing;
using EditorCore.Interfaces;
using System.Configuration;
using System.Windows;
using System.Runtime.InteropServices;

namespace EditorCore
{
	public static class Constants
	{
		public const string LinkedListName = "____EditorInternalList___";
	}

	public static class CursorHelper
	{
		[StructLayout(LayoutKind.Sequential)]
		public struct POINT
		{
			public int X;
			public int Y;

			public static implicit operator Point(POINT point)
			{
				return new Point(point.X, point.Y);
			}
		}

		/// <summary>
		/// Retrieves the cursor's position, in screen coordinates.
		/// </summary>
		/// <see>See MSDN documentation for further information.</see>
		[DllImport("user32.dll")]
		public static extern bool GetCursorPos(out POINT lpPoint);
		public static Point GetCursorPosition()
		{
			POINT lpPoint;
			GetCursorPos(out lpPoint);
			//bool success = User32.GetCursorPos(out lpPoint);
			// if (!success)

			return lpPoint;
		}
	}

	public static class InputDialog
    {
        public static DialogResult Show(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }

	public static class ComboBoxDialog
	{
		public static DialogResult Show(string title, string promptText, ref string value, string[] values)
		{
			Form form = new Form();
			Label label = new Label();
			ComboBox comboBox = new ComboBox();
			Button buttonOk = new Button();
			Button buttonCancel = new Button();

			comboBox.Items.AddRange(values);

			form.Text = title;
			label.Text = promptText;
			comboBox.Text = value;

			buttonOk.Text = "OK";
			buttonCancel.Text = "Cancel";
			buttonOk.DialogResult = DialogResult.OK;
			buttonCancel.DialogResult = DialogResult.Cancel;

			label.SetBounds(9, 20, 372, 13);
			comboBox.SetBounds(12, 36, 372, 20);
			buttonOk.SetBounds(228, 72, 75, 23);
			buttonCancel.SetBounds(309, 72, 75, 23);

			label.AutoSize = true;
			comboBox.Anchor = comboBox.Anchor | AnchorStyles.Right;
			buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

			form.ClientSize = new Size(396, 107);
			form.Controls.AddRange(new Control[] { label, comboBox, buttonOk, buttonCancel });
			form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
			form.FormBorderStyle = FormBorderStyle.FixedDialog;
			form.StartPosition = FormStartPosition.CenterScreen;
			form.MinimizeBox = false;
			form.MaximizeBox = false;
			form.AcceptButton = buttonOk;
			form.CancelButton = buttonCancel;

			DialogResult dialogResult = form.ShowDialog();
			value = comboBox.Text;
			return dialogResult;
		}
	}

	public static class DeepCloneDictArr
    {
        public static Dictionary<string, dynamic> DeepClone(Dictionary<string, dynamic> d)
        {
            var res = new Dictionary<string, dynamic>();
            foreach (string k in d.Keys)
            {
                if (d[k] is Dictionary<string, dynamic> || d[k] is List<dynamic>)
                    res.Add(k, DeepClone(d[k]));
                else if (d[k] is ICloneable)
                    res.Add(k, d[k].Clone());
                else res.Add(k, d[k]);
            }
            return res;
        }

        public static List<dynamic> DeepClone(List<dynamic> l)
        {
            var res = new List<dynamic>();
            foreach (var o in l)
            {
                if (o is Dictionary<string, dynamic> || o is List<dynamic>)
                    res.Add(DeepClone(o));
                else if (o is ICloneable)
                    res.Add(o.Clone());
                else res.Add(o);
            }
            return res;
        }
    }

	//public class CustomStringWriter : System.IO.StringWriter
 //   {
 //       private readonly Encoding encoding;

 //       public CustomStringWriter(Encoding encoding)
 //       {
 //           this.encoding = encoding;
 //       }

 //       public override Encoding Encoding
 //       {
 //           get { return encoding; }
 //       }
 //   }

    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> items = new List<T>();
        public int MaxItems = 50;

        public int Count
        { get { return items.Count(); } }

        public void Remove(int index)
        {
            items.RemoveAt(index);
        }

        public void Push(T item)
        {
            items.Add(item);
            if (items.Count > MaxItems)
            {
                for (int i = MaxItems; i < items.Count; i++) Remove(0);
            }
        }

        public T Pop()
        {
            if (items.Count > 0)
            {
                T tmp = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return tmp;
            }
            else return default(T);
        }

        public void RemoveAt(int index) => items.RemoveAt(index);

        public T Peek() { return items[items.Count - 1]; }

        public T[] ToArray()
        {
            return items.ToArray();
        }

        public void Clear()
        {
            items.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }

    public class UndoAction
    {
        public string actionName;
        public Action<dynamic> _act;
        public dynamic _arg;

        public void Undo()
        {
            _act.Invoke(_arg);
        }

        public override string ToString()
        {
            return actionName;
        }

        public UndoAction(string name, Action<dynamic> Act, dynamic arg)
        {
            actionName = name;
            _act = Act;
            _arg = arg;
        }

    }

    public class ClipBoardItem
    {
        public enum ClipboardType
        {
            NotSet = 0,
            Position = 1,
            Rotation = 2,
            Scale = 3,
            IntArray = 4,
            Objects = 5,
            Transform = 8,
        }

        public Transform transform;
        public int[] Args = null;
        public ClipboardType Type = 0;
        public ILevelObj[] Objs = null;

        public override string ToString()
        {
            switch (Type)
            {
                case ClipboardType.Position:
                    return $"Position - {transform.Pos}";
                case ClipboardType.Rotation:
                    return $"Rotation - {transform.Rot}";
                case ClipboardType.Scale:
                    return $"Scale - {transform.Scale}";
                case ClipboardType.IntArray:
                    return "Args[]";
                case ClipboardType.Transform:
                    return $"Transform - Pos {transform.Pos}, Rot {transform.Rot}, Scale {transform.Scale}";
                case ClipboardType.Objects:
                    return "Object[" + Objs.Length.ToString() + "]";
                default:
                    return "Not set";
            }
        }
    }
}

namespace ExtensionMethods
{
	public static class Extensions
	{
		public static float Dot(this Vector3D v, Vector3D v2) => (float)Vector3D.DotProduct(v, v2);
		public static Vector3D Cross(this Vector3D v, Vector3D v2) => Vector3D.CrossProduct(v, v2);

		public static float Get(this Vector3D v, int id)
		{
			switch (id)
			{
				case 0:
					return (float)v.X;
				case 1:
					return (float)v.Y;
				case 2:
					return (float)v.Z;
			}
			throw new Exception();
		}

		public static void Set(this Vector3D v, int id, double val)
		{
			switch (id)
			{
				case 0:
					v.X = val;
					return;
				case 1:
					v.Y = val; return;
				case 2:
					v.Z = val; return;
			}
			throw new Exception();
		}

		public static Vector3D GetNormalize(this Vector3D v)
		{
			var vv = v;
			vv.Normalize();
			return vv;
		}

		public static bool Matches(this byte[] arr, string magic) =>
			arr.Matches(0,magic.ToCharArray());
		public static bool Matches(this byte[] arr, uint startIndex, string magic) =>
			arr.Matches(startIndex, magic.ToCharArray());

		public static bool Matches(this byte[] arr, uint startIndex, params char[] magic)
		{
			if (arr.Length < magic.Length + startIndex) return false;
			for (uint i = 0; i < magic.Length; i++)
			{
				if (arr[i + startIndex] != magic[i]) return false;
			}
			return true;
		}

		public static int AddIfNotContins(this IList l, dynamic obj)
		{
			int index = l.IndexOf(obj);
			if (index == -1)
			{
				l.Add(obj);
				return l.Count - 1;
			}
			else
				return index;
		}

        public static Vector3D ToVect(this Point3D p)
        {
            return new Vector3D(p.X, p.Y, p.Z);
		}

		public static Point3D ToPoint3D(this Vector3D p)
		{
			return new Point3D(p.X, p.Y, p.Z);
		}

		public static void Add<T>(this ApplicationSettingsBase settings, string propertyName, T val)
		{
			if (settings.Properties[propertyName] != null)
				return;

			var p = new SettingsProperty(propertyName)
			{
				PropertyType = typeof(T),
				Provider = settings.Providers["LocalFileSettingsProvider"],
				SerializeAs = SettingsSerializeAs.String
			};

			p.Attributes.Add(typeof(UserScopedSettingAttribute), new UserScopedSettingAttribute());

			settings.Properties.Add(p);
			settings.Reload();

			//finally set value with new value if none was loaded from userConfig.xml
			var item = settings[propertyName];
			if (item == null)
			{
				settings[propertyName] = val;
				settings.Save();
			}
		}
	}
}
