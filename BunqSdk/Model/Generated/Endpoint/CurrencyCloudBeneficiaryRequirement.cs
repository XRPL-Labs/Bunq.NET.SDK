using Bunq.Sdk.Context;
using Bunq.Sdk.Http;
using Bunq.Sdk.Json;
using Bunq.Sdk.Model.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using Bunq.Sdk.Model.Generated.Object;

namespace Bunq.Sdk.Model.Generated.Endpoint
{
    /// <summary>
    /// Endpoint to list requirements for CurrencyCloud beneficiaries.
    /// </summary>
    public class CurrencyCloudBeneficiaryRequirement : BunqModel
    {
        /// <summary>
        /// Endpoint constants.
        /// </summary>
        protected const string ENDPOINT_URL_LISTING = "user/{0}/currency-cloud-beneficiary-requirement";
    
        /// <summary>
        /// Object type.
        /// </summary>
        private const string OBJECT_TYPE_GET = "CurrencyCloudBeneficiaryRequirement";
    
        /// <summary>
        /// The payment type this requirement is for.
        /// </summary>
        [JsonProperty(PropertyName = "payment_type")]
        public string PaymentType { get; set; }
    
        /// <summary>
        /// The entity type this requirement is for.
        /// </summary>
        [JsonProperty(PropertyName = "legal_entity_type")]
        public string LegalEntityType { get; set; }
    
        /// <summary>
        /// The fields that are required.
        /// </summary>
        [JsonProperty(PropertyName = "all_field")]
        public List<CurrencyCloudBeneficiaryRequirementField> AllField { get; set; }
    
    
        /// <summary>
        /// </summary>
        public static BunqResponse<List<CurrencyCloudBeneficiaryRequirement>> List( IDictionary<string, string> urlParams = null, IDictionary<string, string> customHeaders = null)
        {
            if (urlParams == null) urlParams = new Dictionary<string, string>();
            if (customHeaders == null) customHeaders = new Dictionary<string, string>();
    
            var apiClient = new ApiClient(GetApiContext());
            var responseRaw = apiClient.Get(string.Format(ENDPOINT_URL_LISTING, DetermineUserId()), urlParams, customHeaders);
    
            return FromJsonList<CurrencyCloudBeneficiaryRequirement>(responseRaw, OBJECT_TYPE_GET);
        }
    
    
        /// <summary>
        /// </summary>
        public override bool IsAllFieldNull()
        {
            if (this.PaymentType != null)
            {
                return false;
            }
    
            if (this.LegalEntityType != null)
            {
                return false;
            }
    
            if (this.AllField != null)
            {
                return false;
            }
    
            return true;
        }
    
        /// <summary>
        /// </summary>
        public static CurrencyCloudBeneficiaryRequirement CreateFromJsonString(string json)
        {
            return BunqModel.CreateFromJsonString<CurrencyCloudBeneficiaryRequirement>(json);
        }
    }
}
