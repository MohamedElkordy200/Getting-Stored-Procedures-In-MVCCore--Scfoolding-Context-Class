using System;
using System.Collections.Generic;

namespace AsyadCapital.Entities.DBEntities
{
    public partial class Requests
    {
        public Requests()
        {
            RequestApprovals = new HashSet<RequestApprovals>();
            RequestBoqchanges = new HashSet<RequestBoqchanges>();
            RequestCancellation = new HashSet<RequestCancellation>();
            RequestDrafts = new HashSet<RequestDrafts>();
            RequestFinialAcceptances = new HashSet<RequestFinialAcceptances>();
            RequestFulfillments = new HashSet<RequestFulfillments>();
            RequestInitialAcceptances = new HashSet<RequestInitialAcceptances>();
            RequestStudyApprovings = new HashSet<RequestStudyApprovings>();
            RequestSuspensions = new HashSet<RequestSuspensions>();
            RequestWorkItemsDeliveries = new HashSet<RequestWorkItemsDeliveries>();
        }

        public int Id { get; set; }
        public string ActivityCode { get; set; }
        public int ProjectId { get; set; }
        public int ProjectPersonnelId { get; set; }
        public DateTime Date { get; set; }
        public string Code { get; set; }
        public string Notes { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public string LastModifiedBy { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ProjectPersonnels ProjectPersonnel { get; set; }
        public virtual ICollection<RequestApprovals> RequestApprovals { get; set; }
        public virtual ICollection<RequestBoqchanges> RequestBoqchanges { get; set; }
        public virtual ICollection<RequestCancellation> RequestCancellation { get; set; }
        public virtual ICollection<RequestDrafts> RequestDrafts { get; set; }
        public virtual ICollection<RequestFinialAcceptances> RequestFinialAcceptances { get; set; }
        public virtual ICollection<RequestFulfillments> RequestFulfillments { get; set; }
        public virtual ICollection<RequestInitialAcceptances> RequestInitialAcceptances { get; set; }
        public virtual ICollection<RequestStudyApprovings> RequestStudyApprovings { get; set; }
        public virtual ICollection<RequestSuspensions> RequestSuspensions { get; set; }
        public virtual ICollection<RequestWorkItemsDeliveries> RequestWorkItemsDeliveries { get; set; }
    }
}
