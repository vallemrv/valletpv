
// This file has been generated by the GUI designer. Do not modify.
namespace Valle.GtkUtilidades
{
	public partial class FormularioBase
	{
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Valle.TpvFinal.FormularioBase
			this.Name = "Valle.TpvFinal.FormularioBase";
			this.Title = global::Mono.Unix.Catalog.GetString ("DesgloseTicket");
			
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 30;
			this.DefaultHeight = 30;
			this.Modal = false;
			this.AllowShrink = false;
			this.AllowGrow = false;
			this.Decorated = false;
			this.SkipTaskbarHint = true;
			
			this.ExposeEvent += new global::Gtk.ExposeEventHandler (this.OnExposeEvent);
		}
	}
}
