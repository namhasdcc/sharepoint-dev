using System.Text.Json.Serialization;

namespace ProviderHostedAddInWeb.Models
{
    public class Activation
    {
        public ActivationStatus Status { get; set; }

        public string Reason { get; set; }

        public bool AllowOverAssignment { get; set; }

        public bool FirstComeFirstServedAssignment { get; set; }

        public int? AvailableLicenseQuantity { get; set; }

        public int? LicenseAmount { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActivationStatus
    {
        Success,
        Failure
    }
}