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
    public partial class Lokacija2
    {
		#region Methods
		public void Save()
        {
			Validate<Lokacija2>();
            Save<Lokacija2>();
        }
		public async Task SaveAsync()
        {
			Validate<Lokacija2>();
            await SaveAsync<Lokacija2>();
        }
        public void Delete()
        {
            Delete<Lokacija2>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Lokacija2>();
        }
		public void Validate()
		{
			Validate<Lokacija2>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Lokacija2).GetType().Name;
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