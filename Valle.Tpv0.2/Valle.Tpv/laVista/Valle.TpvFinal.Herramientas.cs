
// This file has been generated by the GUI designer. Do not modify.
namespace Valle.TpvFinal
{
	public partial class Herramientas
	{
		private global::Gtk.VBox vbox1;

		private global::Valle.GtkUtilidades.MiLabel lblTitulo;

		private global::Gtk.VBox hbox1;

		private global::Valle.GtkUtilidades.MiLabel lblImprimir;

		private global::Valle.GtkUtilidades.MiLabel lblAdminitrador;

		private global::Gtk.HButtonBox hbuttonbox1;

		private global::Gtk.Button btnImprimir;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Image imgImprimir;

		private global::Gtk.Label lblBtnImprimir;

		private global::Gtk.Button btnBorrarZ;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Image image130;

		private global::Gtk.Label label2;
		
		private global::Gtk.Button btnArqueoCaja;

		private global::Gtk.VBox vboxArqueoCaja;

		private global::Gtk.Image imageArqueoCaja;

		private global::Gtk.Label labelArqueoCaja;

		private global::Gtk.Button btnTrimestres;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Image image131;

		private global::Gtk.Label label3;

		private global::Gtk.Button btnListado;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Image image132;

		private global::Gtk.Label label4;

		private global::Gtk.Button btnSalir;

		private global::Gtk.VBox vbox6;

		private global::Gtk.Image image133;

		private global::Gtk.Label label5;

		private global::Gtk.HButtonBox hbuttonbox2;

		private global::Gtk.Button btnCambiar;

		private global::Gtk.VBox vbox7;

		private global::Gtk.Image image134;

		private global::Gtk.Label label6;

		private global::Gtk.Button btnReiniciar;

		private global::Gtk.VBox vbox8;

		private global::Gtk.Image image135;

		private global::Gtk.Label label7;

		private global::Gtk.Button btnMinimizar;

		private global::Gtk.VBox vbox9;

		private global::Gtk.Image image136;

		private global::Gtk.Label label8;

		private global::Gtk.Button btnComfiguracion;

		private global::Gtk.VBox vbox10;

		private global::Gtk.Image image137;

		private global::Gtk.Label label9;

		private global::Gtk.Button btnBloquear;

		private global::Gtk.VBox vbox11;

		private global::Gtk.Image imgKey;

		private global::Gtk.Label lblBtnBloquear;

		protected virtual void Init ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Valle.TpvFinal.Herramientas
			this.Name ="Valle.Tpv.iconos.Herramientas";
			this.Title = global::Mono.Unix.Catalog.GetString ("Herramientas");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Valle.TpvFinal.Herramientas.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(12));
			// Container child vbox1.Gtk.Box+BoxChild
			this.lblTitulo = new global::Valle.GtkUtilidades.MiLabel ();
			this.lblTitulo.HeightRequest = 25;
			this.lblTitulo.Events = ((global::Gdk.EventMask)(256));
			this.lblTitulo.Name = "lblTitulo";
			this.vbox1.Add (this.lblTitulo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.lblTitulo]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.VBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.lblImprimir = new global::Valle.GtkUtilidades.MiLabel ();
			this.lblImprimir.HeightRequest = 25;
			this.lblImprimir.Events = ((global::Gdk.EventMask)(256));
			this.lblImprimir.Name = "lblImprimir";
			this.hbox1.Add (this.lblImprimir);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.lblImprimir]));
			w2.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.lblAdminitrador = new global::Valle.GtkUtilidades.MiLabel ();
			this.lblAdminitrador.HeightRequest = 25;
			this.lblAdminitrador.Events = ((global::Gdk.EventMask)(256));
			this.lblAdminitrador.Name = "lblAdminitrador";
			this.hbox1.Add (this.lblAdminitrador);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.lblAdminitrador]));
			w3.Position = 1;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w4.Position = 1;
			w4.Expand = true;
			w4.Fill = true;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox ();
			this.hbuttonbox1.Name = "hbuttonbox1";
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnImprimir = new global::Gtk.Button ();
			this.btnImprimir.WidthRequest = 100;
			this.btnImprimir.HeightRequest = 100;
			this.btnImprimir.CanFocus = true;
			this.btnImprimir.Name = "btnImprimir";
			// Container child btnImprimir.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.imgImprimir = new global::Gtk.Image ();
			this.imgImprimir.Name = "imgImprimir";
			this.imgImprimir.Pixbuf = global::Stetic.IconLoaderEx.LoadIcon (this, "gtk-print", global::Gtk.IconSize.Dialog);
			this.vbox2.Add (this.imgImprimir);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.imgImprimir]));
			w5.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.lblBtnImprimir = new global::Gtk.Label ();
			this.lblBtnImprimir.Name = "lblBtnImprimir";
			this.lblBtnImprimir.LabelProp = global::Mono.Unix.Catalog.GetString ("<big>Imrpimir</big>");
			this.lblBtnImprimir.UseMarkup = true;
			this.vbox2.Add (this.lblBtnImprimir);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.lblBtnImprimir]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.btnImprimir.Add (this.vbox2);
			this.btnImprimir.Label = null;
			this.hbuttonbox1.Add (this.btnImprimir);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.btnImprimir]));
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnBorrarZ = new global::Gtk.Button ();
			this.btnBorrarZ.CanFocus = true;
			this.btnBorrarZ.Name = "btnBorrarZ";
			// Container child btnBorrarZ.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.image130 = new global::Gtk.Image ();
			this.image130.Name = "image130";
			this.image130.Pixbuf = Gdk.Pixbuf.LoadFromResource("Valle.Tpv.iconos.euro.png");
			this.vbox3.Add (this.image130);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.image130]));
			w9.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<big>    Borrar </big>\n<big>Contador Z</big>");
			this.label2.UseMarkup = true;
			this.vbox3.Add (this.label2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.label2]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.btnBorrarZ.Add (this.vbox3);
			this.btnBorrarZ.Label = null;
			this.hbuttonbox1.Add (this.btnBorrarZ);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.btnBorrarZ]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnArqueoCaja = new global::Gtk.Button ();
			this.btnArqueoCaja.CanFocus = true;
			this.btnArqueoCaja.Name = "btnArqueoCaja";
			// Container child btnBorrarZ.Gtk.Container+ContainerChild
			this.vboxArqueoCaja  = new global::Gtk.VBox ();
			this.vboxArqueoCaja.Name = "vboxArqueoCaja";
			this.vboxArqueoCaja.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.imageArqueoCaja = new global::Gtk.Image ();
			this.imageArqueoCaja.Name = "imageArqueoCaja";
			this.imageArqueoCaja.Pixbuf = Gdk.Pixbuf.LoadFromResource("Valle.Tpv.iconos.cajonMonedas.jpeg");
			this.vboxArqueoCaja.Add (this.imageArqueoCaja);
			global::Gtk.Box.BoxChild wAr = ((global::Gtk.Box.BoxChild)(this.vboxArqueoCaja[this.imageArqueoCaja]));
			wAr.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.labelArqueoCaja = new global::Gtk.Label ();
			this.labelArqueoCaja.Name = "labelArqueoCaja";
			this.labelArqueoCaja.LabelProp = global::Mono.Unix.Catalog.GetString ("<big>ArqueoCaja</big>");
			this.labelArqueoCaja.UseMarkup = true;
			this.vboxArqueoCaja.Add (this.labelArqueoCaja);
			global::Gtk.Box.BoxChild wAr1 = ((global::Gtk.Box.BoxChild)(this.vboxArqueoCaja[this.labelArqueoCaja]));
			wAr1.Position = 1;
			wAr1.Expand = false;
			wAr1.Fill = false;
			this.btnArqueoCaja.Add (this.vboxArqueoCaja);
			this.btnArqueoCaja.Label = null;
			this.hbuttonbox1.Add (this.btnArqueoCaja);
			global::Gtk.ButtonBox.ButtonBoxChild wAr12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.btnArqueoCaja]));
			wAr12.Position = 2;
			wAr12.Expand = false;
			wAr12.Fill = false;
			
			
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnTrimestres = new global::Gtk.Button ();
			this.btnTrimestres.CanFocus = true;
			this.btnTrimestres.Name = "btnTrimestres";
			// Container child btnTrimestres.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.image131 = new global::Gtk.Image ();
			this.image131.Name = "image131";
			this.image131.Pixbuf = Gdk.Pixbuf.LoadFromResource("Valle.Tpv.iconos.valances.jpeg");
			this.vbox4.Add (this.image131);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.image131]));
			w13.Position = 0;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("<big>Dias, Meses</big>\n<big> trimestres </big>");
			this.label3.UseMarkup = true;
			this.vbox4.Add (this.label3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label3]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.btnTrimestres.Add (this.vbox4);
			this.btnTrimestres.Label = null;
			this.hbuttonbox1.Add (this.btnTrimestres);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.btnTrimestres]));
			w16.Position = 3;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnListado = new global::Gtk.Button ();
			this.btnListado.CanFocus = true;
			this.btnListado.Name = "btnListado";
			// Container child btnListado.Gtk.Container+ContainerChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.image132 = new global::Gtk.Image ();
			this.image132.Name = "image132";
			this.image132.Pixbuf = Gdk.Pixbuf.LoadFromResource("Valle.Tpv.iconos.OFFCE02C.ICO");
			this.vbox5.Add (this.image132);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.image132]));
			w17.Position = 0;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("<big>Listado</big>\n<big>Cierres</big>");
			this.label4.UseMarkup = true;
			this.vbox5.Add (this.label4);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label4]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			this.btnListado.Add (this.vbox5);
			this.btnListado.Label = null;
			this.hbuttonbox1.Add (this.btnListado);
			global::Gtk.ButtonBox.ButtonBoxChild w20 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.btnListado]));
			w20.Position = 4;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.btnSalir = new global::Gtk.Button ();
			this.btnSalir.CanFocus = true;
			this.btnSalir.Name = "btnSalir";
			// Container child btnSalir.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.image133 = new global::Gtk.Image ();
			this.image133.Name = "image133";
			this.image133.Pixbuf = Gdk.Pixbuf.LoadFromResource("Valle.Tpv.iconos.~APP21MB.ICO");
			this.vbox6.Add (this.image133);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.image133]));
			w21.Position = 0;
			// Container child vbox6.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("<big>Salir</big>");
			this.label5.UseMarkup = true;
			this.vbox6.Add (this.label5);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.label5]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.btnSalir.Add (this.vbox6);
			this.btnSalir.Label = null;
			this.hbuttonbox1.Add (this.btnSalir);
			global::Gtk.ButtonBox.ButtonBoxChild w24 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.btnSalir]));
			w24.Position = 5;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox1.Add (this.hbuttonbox1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbuttonbox1]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnCambiar = new global::Gtk.Button ();
			this.btnCambiar.WidthRequest = 100;
			this.btnCambiar.HeightRequest = 100;
			this.btnCambiar.CanFocus = true;
			this.btnCambiar.Name = "btnCambiar";
			// Container child btnCambiar.Gtk.Container+ContainerChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.image134 = new global::Gtk.Image ();
			this.image134.Name = "image134";
			this.image134.Pixbuf = global::Stetic.IconLoaderEx.LoadIcon (this, "gtk-jump-to", global::Gtk.IconSize.Dialog);
			this.vbox7.Add (this.image134);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.image134]));
			w26.Position = 0;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("<big>Cambiar</big>\n<big>    TPV      </big>");
			this.label6.UseMarkup = true;
			this.vbox7.Add (this.label6);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.label6]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.btnCambiar.Add (this.vbox7);
			this.btnCambiar.Label = null;
			this.hbuttonbox2.Add (this.btnCambiar);
			global::Gtk.ButtonBox.ButtonBoxChild w29 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.btnCambiar]));
			w29.Expand = false;
			w29.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnReiniciar = new global::Gtk.Button ();
			this.btnReiniciar.CanFocus = true;
			this.btnReiniciar.Name = "btnReiniciar";
			// Container child btnReiniciar.Gtk.Container+ContainerChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.image135 = new global::Gtk.Image ();
			this.image135.Name = "image135";
			this.image135.Pixbuf = Gdk.Pixbuf.LoadFromResource("Valle.Tpv.iconos.CONVERT2.ICO");
			this.vbox8.Add (this.image135);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.image135]));
			w30.Position = 0;
			// Container child vbox8.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("<big>Reiniciar</big>\n<big>    TPV  </big>");
			this.label7.UseMarkup = true;
			this.vbox8.Add (this.label7);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.label7]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			this.btnReiniciar.Add (this.vbox8);
			this.btnReiniciar.Label = null;
			this.hbuttonbox2.Add (this.btnReiniciar);
			global::Gtk.ButtonBox.ButtonBoxChild w33 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.btnReiniciar]));
			w33.Position = 1;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnMinimizar = new global::Gtk.Button ();
			this.btnMinimizar.CanFocus = true;
			this.btnMinimizar.Name = "btnMinimizar";
			// Container child btnMinimizar.Gtk.Container+ContainerChild
			this.vbox9 = new global::Gtk.VBox ();
			this.vbox9.Name = "vbox9";
			this.vbox9.Spacing = 6;
			// Container child vbox9.Gtk.Box+BoxChild
			this.image136 = new global::Gtk.Image ();
			this.image136.Name = "image136";
			this.image136.Pixbuf = global::Stetic.IconLoaderEx.LoadIcon (this, "gtk-media-stop", global::Gtk.IconSize.Dialog);
			this.vbox9.Add (this.image136);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.image136]));
			w34.Position = 0;
			// Container child vbox9.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("<big>Minimizar</big>");
			this.label8.UseMarkup = true;
			this.vbox9.Add (this.label8);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.label8]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			this.btnMinimizar.Add (this.vbox9);
			this.btnMinimizar.Label = null;
			this.hbuttonbox2.Add (this.btnMinimizar);
			global::Gtk.ButtonBox.ButtonBoxChild w37 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.btnMinimizar]));
			w37.Position = 2;
			w37.Expand = false;
			w37.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnComfiguracion = new global::Gtk.Button ();
			this.btnComfiguracion.CanFocus = true;
			this.btnComfiguracion.Name = "btnComfiguracion";
			// Container child btnComfiguracion.Gtk.Container+ContainerChild
			this.vbox10 = new global::Gtk.VBox ();
			this.vbox10.Name = "vbox10";
			this.vbox10.Spacing = 6;
			// Container child vbox10.Gtk.Box+BoxChild
			this.image137 = new global::Gtk.Image ();
			this.image137.Name = "image137";
			this.image137.Pixbuf = global::Stetic.IconLoaderEx.LoadIcon (this, "gtk-preferences", global::Gtk.IconSize.Dialog);
			this.vbox10.Add (this.image137);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.image137]));
			w38.Position = 0;
			// Container child vbox10.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Configuracion");
			this.label9.UseMarkup = true;
			this.vbox10.Add (this.label9);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.label9]));
			w39.Position = 1;
			w39.Expand = false;
			w39.Fill = false;
			this.btnComfiguracion.Add (this.vbox10);
			this.btnComfiguracion.Label = null;
			this.hbuttonbox2.Add (this.btnComfiguracion);
			global::Gtk.ButtonBox.ButtonBoxChild w41 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.btnComfiguracion]));
			w41.Position = 3;
			w41.Expand = false;
			w41.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.btnBloquear = new global::Gtk.Button ();
			this.btnBloquear.CanFocus = true;
			this.btnBloquear.Name = "btnBloquear";
			// Container child btnBloquear.Gtk.Container+ContainerChild
			this.vbox11 = new global::Gtk.VBox ();
			this.vbox11.Name = "vbox11";
			this.vbox11.Spacing = 6;
			// Container child vbox11.Gtk.Box+BoxChild
			this.imgKey = new global::Gtk.Image ();
			this.imgKey.Name = "image138";
			this.imgKey.Pixbuf =  Gdk.Pixbuf.LoadFromResource("Valle.Tpv.iconos.MUNECO_CANDAO_03.png");
			this.vbox11.Add (this.imgKey);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.imgKey]));
			w42.Position = 0;
			// Container child vbox11.Gtk.Box+BoxChild
			this.lblBtnBloquear = new global::Gtk.Label ();
			this.lblBtnBloquear.Name = "lblBtnBloquear";
			this.lblBtnBloquear.LabelProp = global::Mono.Unix.Catalog.GetString ("<big>Bloquear</big>");
			this.lblBtnBloquear.UseMarkup = true;
			this.vbox11.Add (this.lblBtnBloquear);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.lblBtnBloquear]));
			w43.Position = 1;
			w43.Expand = false;
			w43.Fill = false;
			this.btnBloquear.Add (this.vbox11);
			this.btnBloquear.Label = null;
			this.hbuttonbox2.Add (this.btnBloquear);
			global::Gtk.ButtonBox.ButtonBoxChild w45 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2[this.btnBloquear]));
			w45.Position = 4;
			w45.Expand = false;
			w45.Fill = false;
			this.vbox1.Add (this.hbuttonbox2);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbuttonbox2]));
			w46.Position = 3;
			w46.Expand = false;
			w46.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 601;
			this.DefaultHeight = 322;
			
			this.btnImprimir.Clicked += new global::System.EventHandler (this.btnModoImp_Click);
			this.btnBorrarZ.Clicked += new global::System.EventHandler (this.btnCajaDia_Click);
			this.btnTrimestres.Clicked += new global::System.EventHandler (this.btnMesesTrim_Click);
			this.btnListado.Clicked += new global::System.EventHandler (this.BtnListCierresClick);
			this.btnSalir.Clicked += new global::System.EventHandler (this.btnSalir_Click);
			this.btnCambiar.Clicked += new global::System.EventHandler (this.btnCambiarTpv_Click);
			this.btnReiniciar.Clicked += new global::System.EventHandler (this.btnReiniciar_Click);
			this.btnComfiguracion.Clicked += new global::System.EventHandler (this.BtnConfigClienteClick);
			this.btnBloquear.Clicked += new global::System.EventHandler (this.btnBloqueo_Click);
			this.btnMinimizar.Clicked += new global::System.EventHandler (this.BtnMinimizarClick);
		}
	}
}
