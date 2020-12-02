// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Sistem
{
    public partial class Objekt
    {
		#region Methods
		public void Save()
        {
			Validate<Objekt>();
            Save<Objekt>();
        }
		public async Task SaveAsync()
        {
			Validate<Objekt>();
            await SaveAsync<Objekt>();
        }
        public void Delete()
        {
            Delete<Objekt>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Objekt>();
        }
		public void Validate()
		{
			Validate<Objekt>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Objekt).GetType().Name;
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