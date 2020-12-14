// Generated on 12/14/2020 9:29 PM using EntityWorks code generation tool.
// Template version: 1.0
// Note: Do not modify!
// Except: Namespace.

using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using System.Threading.Tasks;
using Orko.EntityWorks;

namespace Orko.Watersports
{
    /// <summary>
    /// Hotel entity.
    /// </summary>
    public sealed partial class Hotel : Entity
    {
		#region Members
		
        #endregion
        
		#region Constructors
        static Hotel()
        {
            // Cache field metadata.
            EntityMeta<Hotel>.LoadColumnMetadata
			(
				new ColumnMetadata(nameof(HotelHotel), @"HotelHotel", DbType.Int32, isRequired: true),
                new ColumnMetadata(nameof(HotelAdresa), @"HotelAdresa", DbType.String, isRequired: true),
                new ColumnMetadata(nameof(HotelTelefon), @"HotelTelefon", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(HotelEmail), @"HotelEmail", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(HotelWeb), @"HotelWeb", DbType.String, isRequired: false),
                new ColumnMetadata(nameof(HotelAktivnost), @"HotelAktivnost", DbType.Boolean, isRequired: true),
                new ColumnMetadata(nameof(HotelJezik), @"HotelJezik", DbType.AnsiStringFixedLength, isRequired: true, isLanguageCode: true),
                new ColumnMetadata(nameof(HotelNaziv), @"HotelNaziv", DbType.String, isRequired: true, isLanguage: true),
                new ColumnMetadata(nameof(HotelOpis), @"HotelOpis", DbType.String, isRequired: false, isLanguage: true)
			);

            // Cache entites metadata.
            EntityMeta<Hotel>.LoadRelationMetadata
			(
				null
			);

			// Cache table metadata.
			EntityMeta<Hotel>.HasLanguageTable = true;
            EntityMeta<Hotel>.TableSchema = @"Watersports";
            EntityMeta<Hotel>.TableName = @"Hotel";
            EntityMeta<Hotel>.LanguageTableSchema = @"Watersports";
            EntityMeta<Hotel>.LanguageTableName = @"Hotel_jezik";
        }
        #endregion

        #region Columns
        public int? HotelHotel { get; set; }
        public string HotelAdresa { get; set; }
        public string HotelTelefon { get; set; }
        public string HotelEmail { get; set; }
        public string HotelWeb { get; set; }
        public bool? HotelAktivnost { get; set; }
        public string HotelJezik { get; private set; }
        public string HotelNaziv { get; set; }
        public string HotelOpis { get; set; }
        #endregion

        #region Entities
		
        #endregion

		#region Public methods async
		public static async Task<IEnumerable<Hotel>> GetByAnyAsync(params QueryCondition[] queryConditions)
        {
            return await GetByAnyAsync<Hotel>(queryConditions);
        }
        public static async Task<IEnumerable<Hotel>> GetByAnyAsync(string columnName, QueryOp queryOp, object value)
        {
            return await GetByAnyAsync<Hotel>(columnName, queryOp, value);
        }
		public static async Task<Hotel> GetByPrimaryKeyAsync(int HotelHotel)
        {
            return await GetByPrimaryKeyAsync<Hotel>(HotelHotel);
        }
		public static async Task<Hotel> TryGetByPrimaryKeyAsync(int HotelHotel)
        {
            return await TryGetByPrimaryKeyAsync<Hotel>(HotelHotel);
        }
		#endregion
    }
}