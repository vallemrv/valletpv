
// This file has been generated by the GUI designer. Do not modify.
namespace Valle.GesTpv
{
	public partial class VenPrivilegios
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label2;
		private global::Gtk.ComboBox cmbUser;
		private global::Gtk.Button btnAñadirUser;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label1;
		private global::Gtk.ComboBox cmbFormularios;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView lstTabla;
		private global::Gtk.HBox hbox3;
		private global::Gtk.HButtonBox grpModos1;
		private global::Gtk.Button btnAceptar;
		private global::Gtk.Button btnSalir;
		private global::Gtk.Label lblInformacion;
        
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Valle.GesTpv.VenPrivilegios
			this.WidthRequest = 400;
			this.HeightRequest = 450;
			this.Name = "Valle.GesTpv.VenPrivilegios";
			this.Title = global::Mono.Unix.Catalog.GetString ("Gestion de privilegios");
			this.Icon = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./Iconos/exec.gif"));
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Modal = true;
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child Valle.GesTpv.VenPrivilegios.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(12));
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre Usuario");
			this.hbox1.Add (this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label2]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.cmbUser = global::Gtk.ComboBox.NewText ();
			this.cmbUser.Name = "cmbUser";
			this.hbox1.Add (this.cmbUser);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.cmbUser]));
			w2.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.btnAñadirUser = new global::Gtk.Button ();
			this.btnAñadirUser.CanFocus = true;
			this.btnAñadirUser.Name = "btnAñadirUser";
			this.btnAñadirUser.UseUnderline = true;
			// Container child btnAñadirUser.Gtk.Container+ContainerChild
			global::Gtk.Alignment w3 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w4 = new global::Gtk.HBox ();
			w4.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w4.Add (w5);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w7 = new global::Gtk.Label ();
			w4.Add (w7);
			w3.Add (w4);
			this.btnAñadirUser.Add (w3);
			this.hbox1.Add (this.btnAñadirUser);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.btnAñadirUser]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre form");
			this.hbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label1]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.cmbFormularios = global::Gtk.ComboBox.NewText ();
			this.cmbFormularios.Name = "cmbFormularios";
			this.hbox2.Add (this.cmbFormularios);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.cmbFormularios]));
			w14.Position = 1;
			this.vbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.lstTabla = new global::Gtk.TreeView ();
			this.lstTabla.CanFocus = true;
			this.lstTabla.Name = "lstTabla";
			this.GtkScrolledWindow.Add (this.lstTabla);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w17.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.grpModos1 = new global::Gtk.HButtonBox ();
			this.grpModos1.Name = "grpModos1";
			this.grpModos1.Spacing = 14;
			this.grpModos1.BorderWidth = ((uint)(6));
			this.grpModos1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child grpModos1.Gtk.ButtonBox+ButtonBoxChild
			this.btnAceptar = new global::Gtk.Button ();
			this.btnAceptar.CanFocus = true;
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.UseStock = true;
			this.btnAceptar.UseUnderline = true;
			this.btnAceptar.Label = "gtk-ok";
			this.grpModos1.Add (this.btnAceptar);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.grpModos1 [this.btnAceptar]));
			w18.Expand = false;
			w18.Fill = false;
			// Container child grpModos1.Gtk.ButtonBox+ButtonBoxChild
			this.btnSalir = new global::Gtk.Button ();
			this.btnSalir.CanFocus = true;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.UseUnderline = true;
			// Container child btnSalir.Gtk.Container+ContainerChild
			global::Gtk.Alignment w19 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w20 = new global::Gtk.HBox ();
			w20.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w21 = new global::Gtk.Image ();
			w21.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./Iconos/EXIT00C.ICO"));
			w20.Add (w21);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w23 = new global::Gtk.Label ();
			w23.LabelProp = global::Mono.Unix.Catalog.GetString ("Salir");
			w23.UseUnderline = true;
			w20.Add (w23);
			w19.Add (w20);
			this.btnSalir.Add (w19);
			this.grpModos1.Add (this.btnSalir);
			global::Gtk.ButtonBox.ButtonBoxChild w27 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.grpModos1 [this.btnSalir]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.hbox3.Add (this.grpModos1);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.grpModos1]));
			w28.Position = 0;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
			w29.Position = 3;
			w29.Expand = false;
			w29.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.lblInformacion = new global::Gtk.Label ();
			this.lblInformacion.Name = "lblInformacion";
			this.lblInformacion.Xalign = 0F;
			this.lblInformacion.LabelProp = global::Mono.Unix.Catalog.GetString ("Modo no editable activado");
			this.vbox1.Add (this.lblInformacion);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.lblInformacion]));
			w30.Position = 4;
			w30.Expand = false;
			w30.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 410;
			this.DefaultHeight = 479;
			this.btnAceptar.Hide ();
			this.Show ();
			this.cmbUser.Changed += new global::System.EventHandler (this.OnCmbUserChanged);
			this.btnAñadirUser.Clicked += new global::System.EventHandler (this.OnBtnAñadirUserClicked);
			this.cmbFormularios.Changed += new global::System.EventHandler (this.OnCmbFormulariosChanged);
			this.lstTabla.RowActivated += new global::Gtk.RowActivatedHandler (this.OnLstTablaRowActivated);
			this.btnSalir.Clicked += new global::System.EventHandler (this.OnBtnSalirClicked);
		}
	}
}
