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
    public partial class VrstaIzleta
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaIzleta>();
            Save<VrstaIzleta>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaIzleta>();
            await SaveAsync<VrstaIzleta>();
        }
        public void Delete()
        {
            Delete<VrstaIzleta>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaIzleta>();
        }
		public void Validate()
		{
			Validate<VrstaIzleta>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaIzleta).GetType().Name;
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