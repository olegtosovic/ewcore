// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Base
{
    public partial class Drzava
    {
		#region Methods
		public void Save()
        {
			Validate<Drzava>();
            Save<Drzava>();
        }
		public async Task SaveAsync()
        {
			Validate<Drzava>();
            await SaveAsync<Drzava>();
        }
        public void Delete()
        {
            Delete<Drzava>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<Drzava>();
        }
		public void Validate()
		{
			Validate<Drzava>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(Drzava).GetType().Name;
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