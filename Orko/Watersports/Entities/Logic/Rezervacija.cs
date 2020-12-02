// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Watersports
{
    public partial class Rezervacija
    {
		#region Methods
		public void Save()
        {
			Validate<Rezervacija>();
            Save<Rezervacija>();
        }
		public async Task SaveAsync()
        {
			Validate<Rezervacija>();
            await SaveAsync<Rezervacija>();
        }
        public void Delete()
        {
            Delete<Rezervacija>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Rezervacija>();
        }
		public void Validate()
		{
			Validate<Rezervacija>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Rezervacija).GetType().Name;
        }
        public override string GetDisplayValue()
        {
            return base.GetDisplayValue();
        }
		public static string GetTooltipValue()
		{
            return string.Empty;
		}
        #endregion
    }
}