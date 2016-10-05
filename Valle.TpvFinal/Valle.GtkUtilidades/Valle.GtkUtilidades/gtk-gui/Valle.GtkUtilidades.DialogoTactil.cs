
// This file has been generated by the GUI designer. Do not modify.
namespace Valle.GtkUtilidades
{
	public partial class DialogoTactil
	{
		private global::Gtk.VBox vbox2;

		private global::Valle.GtkUtilidades.MiLabel lblInf;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button btnSi;

		private global::Gtk.Button btnAceptar;

		private global::Gtk.Button btnNo;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Valle.GtkUtilidades.DialogoTactil
			this.Name = "Valle.GtkUtilidades.DialogoTactil";
			this.Title = global::Mono.Unix.Catalog.GetString ("TactilDialogo");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Modal = true;
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child Valle.GtkUtilidades.DialogoTactil.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(12));
			// Container child vbox2.Gtk.Box+BoxChild
			this.lblInf = new global::Valle.GtkUtilidades.MiLabel();
			this.lblInf.WidthRequest = 390;
			this.lblInf.HeightRequest = 190;
			
			this.vbox2.Add (this.lblInf);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.lblInf]));
			w1.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Homogeneous = true;
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(12));
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnSi = new global::Gtk.Button ();
			this.btnSi.WidthRequest = 90;
			this.btnSi.HeightRequest = 90;
			this.btnSi.CanFocus = true;
			this.btnSi.Name = "btnSi";
			this.btnSi.UseUnderline = true;
			// Container child btnSi.Gtk.Container+ContainerChild
			global::Gtk.Alignment w2 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w3 = new global::Gtk.HBox ();
			w3.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w4 = new global::Gtk.Image ();
			w4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Dialog);
			w3.Add (w4);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w6 = new global::Gtk.Label ();
			w3.Add (w6);
			w2.Add (w3);
			this.btnSi.Add (w2);
			this.hbox1.Add (this.btnSi);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnSi]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnAceptar = new global::Gtk.Button ();
			this.btnAceptar.WidthRequest = 90;
			this.btnAceptar.HeightRequest = 90;
			this.btnAceptar.CanFocus = true;
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.UseUnderline = true;
			// Container child btnAceptar.Gtk.Container+ContainerChild
			global::Gtk.Alignment w11 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w12 = new global::Gtk.HBox ();
			w12.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w13 = new global::Gtk.Image ();
			w13.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Dialog);
			w12.Add (w13);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w15 = new global::Gtk.Label ();
			w12.Add (w15);
			w11.Add (w12);
			this.btnAceptar.Add (w11);
			this.hbox1.Add (this.btnAceptar);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnAceptar]));
			w19.Position = 1;
			w19.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnNo = new global::Gtk.Button ();
			this.btnNo.WidthRequest = 90;
			this.btnNo.HeightRequest = 90;
			this.btnNo.CanFocus = true;
			this.btnNo.Name = "btnNo";
			this.btnNo.UseUnderline = true;
			// Container child btnNo.Gtk.Container+ContainerChild
			global::Gtk.Alignment w20 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w21 = new global::Gtk.HBox ();
			w21.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w22 = new global::Gtk.Image ();
			w22.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Dialog);
			w21.Add (w22);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w24 = new global::Gtk.Label ();
			w21.Add (w24);
			w20.Add (w21);
			this.btnNo.Add (w20);
			this.hbox1.Add (this.btnNo);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.btnNo]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w29.PackType = ((global::Gtk.PackType)(1));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 464;
			this.DefaultHeight = 374;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.btnSi.Clicked += new global::System.EventHandler (this.OnBtnSiClicked);
			this.btnAceptar.Clicked += new global::System.EventHandler (this.OnBtnAceptarClicked);
			this.btnNo.Clicked += new global::System.EventHandler (this.OnBtnNoClicked);
		}
	}
}
