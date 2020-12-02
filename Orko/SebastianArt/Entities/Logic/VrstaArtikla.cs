// Generated on 11/29/2020 8:43 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Intended for modification.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.SebastianArt
{
    public partial class VrstaArtikla
    {
		#region Methods
		public void Save()
        {
			Validate<VrstaArtikla>();
            Save<VrstaArtikla>();
        }
		public async Task SaveAsync()
        {
			Validate<VrstaArtikla>();
            await SaveAsync<VrstaArtikla>();
        }
        public void Delete()
        {
            Delete<VrstaArtikla>();
        }
		public async Task DeleteAsync()
        {
            await DeleteAsync<VrstaArtikla>();
        }
		public void Validate()
		{
			Validate<VrstaArtikla>();
		}
		#endregion

        #region Query
        #endregion

        #region Globals
        public static new string GetCaptionValue()
        {
            return typeof(VrstaArtikla).GetType().Name;
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