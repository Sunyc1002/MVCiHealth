//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCiHealth.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_EVALUATION
    {
        public int EVALUATION_ID { get; set; }
        public int PATIENT_ID { get; set; }
        public int DOCTOR_ID { get; set; }
        public int RESERVATION_ID { get; set; }
        public Nullable<double> RATE { get; set; }
        public string DETAIL { get; set; }
        public int AGREETIMES { get; set; }
        public System.DateTime INSDATE { get; set; }
        public string DOCTOR_NM { get; set; }
        public Nullable<double> LEVEL { get; set; }
        public string PATIENT_NM { get; set; }
    }
}
