namespace LMS_Clone.Models {
    public class BaseEntity {
        public bool isDeleted { get; set; }
        public bool isActive { get; set; }
        public DateTime creationTime { get; set; }
        public DateTime updatedTime { get; set; }
    }
}
