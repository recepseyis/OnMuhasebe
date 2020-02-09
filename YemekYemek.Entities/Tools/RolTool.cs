using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekYemek.Entities.Tools
{
    public static class RolTool
    {
        public static void RolleriYukle(XtraForm form)
        {
            Context.YemekYemekContext context = new Context.YemekYemekContext();
            foreach (var item in context.KullaniciRoller.Where(c=> c.FormAdi == form.Name && c.Yetki == false).ToList())
            {
                var bulunan = form.Controls.Find(item.KontrolAdi, true).SingleOrDefault();
                if (bulunan != null)
                {
                    bulunan.Enabled = false;
                }
            }
        }
    }
}
