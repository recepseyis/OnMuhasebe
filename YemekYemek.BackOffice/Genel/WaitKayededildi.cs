﻿using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekYemek.BackOffice.Genel
{
    public partial class WaitKayededildi : WaitForm
    {
        public WaitKayededildi()
        {
            InitializeComponent();
            this.progressPanel1.AutoSize = true;
        }
        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion Overrides

        public enum WaitFormCommand
        {
        }
        private void WaitKayededildi_Load(object sender, EventArgs e)
        {

        }
    }
}
