namespace MaskeSatisProject.Entities.Concrete
{
    using MaskeSatisProject.Entities.Abstract;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MaskTable")]
    public partial class MaskTable : IEntity
    {
        [Key]
        public int OperationId { get; set; }

        public int UserId { get; set; }

        public DateTime OperationDate { get; set; }

        public virtual Users Users { get; set; }
    }
}
