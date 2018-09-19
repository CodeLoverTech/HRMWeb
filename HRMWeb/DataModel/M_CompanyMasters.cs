//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRMWeb.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class M_CompanyMasters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public M_CompanyMasters()
        {
            this.M_CandidateMasters = new HashSet<M_CandidateMasters>();
            this.M_RequirementMaster = new HashSet<M_RequirementMaster>();
            this.T_CandidateFollowUpDetails = new HashSet<T_CandidateFollowUpDetails>();
            this.T_FinalCandidatePlacementDetails = new HashSet<T_FinalCandidatePlacementDetails>();
        }
    
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string CompanyContactNo { get; set; }
        public string EmailID { get; set; }
        public int LocationID { get; set; }
        public string Locality { get; set; }
        public Nullable<int> OrderBy { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_CandidateMasters> M_CandidateMasters { get; set; }
        public virtual M_LocationMasters M_LocationMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<M_RequirementMaster> M_RequirementMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_CandidateFollowUpDetails> T_CandidateFollowUpDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_FinalCandidatePlacementDetails> T_FinalCandidatePlacementDetails { get; set; }
    }
}