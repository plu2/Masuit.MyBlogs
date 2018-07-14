//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelCodeGenerate
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            this.Comment = new HashSet<Comment>();
            this.PostAccessRecord = new HashSet<PostAccessRecord>();
            this.PostHistoryVersion = new HashSet<PostHistoryVersion>();
            this.Seminar = new HashSet<Seminar>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public System.DateTime PostDate { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public bool IsFixedTop { get; set; }
        public int CategoryId { get; set; }
        public string ResourceName { get; set; }
        public bool IsWordDocument { get; set; }
        public string Email { get; set; }
        public string Label { get; set; }
        public int VoteUpCount { get; set; }
        public int VoteDownCount { get; set; }
        public int Status { get; set; }
        public bool IsBanner { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostAccessRecord> PostAccessRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PostHistoryVersion> PostHistoryVersion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seminar> Seminar { get; set; }
    }
}