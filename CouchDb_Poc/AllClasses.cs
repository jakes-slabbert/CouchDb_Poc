using Newtonsoft.Json;

namespace CouchDb_Poc
{
    public class EnrollCourse
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string CourseName { get; set; }
        public DateTime EnrolledOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public class EnrollInfo
    {
        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonProperty("_rev")]
        public string Rev { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string CourseName { get; set; }
        public DateTime EnrolledOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public class UpdateEnroll
    {
        public string Id { get; set; }
        [JsonIgnore]
        public string Rev { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string CourseName { get; set; }
        public DateTime EnrolledOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public class HttpClientResponse
    {
        public bool IsSuccess { get; set; }
        public dynamic SuccessContentObject { get; set; }
        public string FailedReason { get; set; }
    }
    public class SavedResult
    {
        public string Id { get; set; }
        public string Rev { get; set; }
    }
}
