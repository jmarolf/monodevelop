// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
namespace MonoDevelop.IPhone.Gui {internal partial class IPhoneBuildOptionsPanelWidget {
        private Gtk.VBox vbox2;
        
        private Gtk.Label label2;
        
        private Gtk.Alignment contentsAlignment;
        
        private Gtk.VBox vbox1;
        
        private Gtk.CheckButton debugCheck;
        
        private Gtk.Table table1;
        
        private MonoDevelop.Core.Gui.Components.MenuButtonEntry extraArgsEntry;
        
        private Gtk.ScrolledWindow GtkScrolledWindow;
        
        private Gtk.TreeView i18nTreeView;
        
        private Gtk.Label label1;
        
        private Gtk.Label label3;
        
        private Gtk.Label label4;
        
        private Gtk.Label label5;
        
        private Gtk.ComboBox linkCombo;
        
        private Gtk.ComboBoxEntry sdkComboEntry;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget MonoDevelop.IPhone.Gui.IPhoneBuildOptionsPanelWidget
            Stetic.BinContainer.Attach(this);
            this.Name = "MonoDevelop.IPhone.Gui.IPhoneBuildOptionsPanelWidget";
            // Container child MonoDevelop.IPhone.Gui.IPhoneBuildOptionsPanelWidget.Gtk.Container+ContainerChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.Xalign = 0F;
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("<b>MonoTouch iPhone compiler</b>");
            this.label2.UseMarkup = true;
            this.vbox2.Add(this.label2);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox2[this.label2]));
            w1.Position = 0;
            w1.Expand = false;
            w1.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.contentsAlignment = new Gtk.Alignment(0F, 0.5F, 1F, 1F);
            this.contentsAlignment.Name = "contentsAlignment";
            this.contentsAlignment.LeftPadding = ((uint)(24));
            // Container child contentsAlignment.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.debugCheck = new Gtk.CheckButton();
            this.debugCheck.CanFocus = true;
            this.debugCheck.Name = "debugCheck";
            this.debugCheck.Label = Mono.Unix.Catalog.GetString("Build _debug-mode binaries");
            this.debugCheck.DrawIndicator = true;
            this.debugCheck.UseUnderline = true;
            this.vbox1.Add(this.debugCheck);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.debugCheck]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.table1 = new Gtk.Table(((uint)(4)), ((uint)(2)), false);
            this.table1.Name = "table1";
            this.table1.RowSpacing = ((uint)(6));
            this.table1.ColumnSpacing = ((uint)(6));
            // Container child table1.Gtk.Table+TableChild
            this.extraArgsEntry = new MonoDevelop.Core.Gui.Components.MenuButtonEntry();
            this.extraArgsEntry.Name = "extraArgsEntry";
            this.table1.Add(this.extraArgsEntry);
            Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table1[this.extraArgsEntry]));
            w3.TopAttach = ((uint)(2));
            w3.BottomAttach = ((uint)(3));
            w3.LeftAttach = ((uint)(1));
            w3.RightAttach = ((uint)(2));
            w3.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.GtkScrolledWindow = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow.Name = "GtkScrolledWindow";
            this.GtkScrolledWindow.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow.Gtk.Container+ContainerChild
            this.i18nTreeView = new Gtk.TreeView();
            this.i18nTreeView.CanFocus = true;
            this.i18nTreeView.Name = "i18nTreeView";
            this.GtkScrolledWindow.Add(this.i18nTreeView);
            this.table1.Add(this.GtkScrolledWindow);
            Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindow]));
            w5.TopAttach = ((uint)(3));
            w5.BottomAttach = ((uint)(4));
            w5.LeftAttach = ((uint)(1));
            w5.RightAttach = ((uint)(2));
            w5.XOptions = ((Gtk.AttachOptions)(4));
            w5.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.Xalign = 0F;
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Extra _arguments:");
            this.label1.UseUnderline = true;
            this.table1.Add(this.label1);
            Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table1[this.label1]));
            w6.TopAttach = ((uint)(2));
            w6.BottomAttach = ((uint)(3));
            w6.XOptions = ((Gtk.AttachOptions)(4));
            w6.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.Xalign = 0F;
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("_Linker behavior:");
            this.label3.UseUnderline = true;
            this.table1.Add(this.label3);
            Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table1[this.label3]));
            w7.XOptions = ((Gtk.AttachOptions)(4));
            w7.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label4 = new Gtk.Label();
            this.label4.Name = "label4";
            this.label4.Xalign = 0F;
            this.label4.LabelProp = Mono.Unix.Catalog.GetString("_SDK version:");
            this.label4.UseUnderline = true;
            this.table1.Add(this.label4);
            Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table1[this.label4]));
            w8.TopAttach = ((uint)(1));
            w8.BottomAttach = ((uint)(2));
            w8.XOptions = ((Gtk.AttachOptions)(4));
            w8.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.label5.Xalign = 0F;
            this.label5.Yalign = 0F;
            this.label5.LabelProp = Mono.Unix.Catalog.GetString("I18n assemblies:");
            this.label5.UseUnderline = true;
            this.table1.Add(this.label5);
            Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table1[this.label5]));
            w9.TopAttach = ((uint)(3));
            w9.BottomAttach = ((uint)(4));
            w9.XOptions = ((Gtk.AttachOptions)(4));
            w9.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.linkCombo = Gtk.ComboBox.NewText();
            this.linkCombo.Name = "linkCombo";
            this.table1.Add(this.linkCombo);
            Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table1[this.linkCombo]));
            w10.LeftAttach = ((uint)(1));
            w10.RightAttach = ((uint)(2));
            w10.XOptions = ((Gtk.AttachOptions)(4));
            w10.YOptions = ((Gtk.AttachOptions)(4));
            // Container child table1.Gtk.Table+TableChild
            this.sdkComboEntry = Gtk.ComboBoxEntry.NewText();
            this.sdkComboEntry.Name = "sdkComboEntry";
            this.table1.Add(this.sdkComboEntry);
            Gtk.Table.TableChild w11 = ((Gtk.Table.TableChild)(this.table1[this.sdkComboEntry]));
            w11.TopAttach = ((uint)(1));
            w11.BottomAttach = ((uint)(2));
            w11.LeftAttach = ((uint)(1));
            w11.RightAttach = ((uint)(2));
            w11.XOptions = ((Gtk.AttachOptions)(4));
            w11.YOptions = ((Gtk.AttachOptions)(4));
            this.vbox1.Add(this.table1);
            Gtk.Box.BoxChild w12 = ((Gtk.Box.BoxChild)(this.vbox1[this.table1]));
            w12.Position = 1;
            w12.Expand = false;
            w12.Fill = false;
            this.contentsAlignment.Add(this.vbox1);
            this.vbox2.Add(this.contentsAlignment);
            Gtk.Box.BoxChild w14 = ((Gtk.Box.BoxChild)(this.vbox2[this.contentsAlignment]));
            w14.Position = 1;
            this.Add(this.vbox2);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.label3.MnemonicWidget = this.linkCombo;
            this.label5.MnemonicWidget = this.i18nTreeView;
            this.Hide();
        }
    }
}
