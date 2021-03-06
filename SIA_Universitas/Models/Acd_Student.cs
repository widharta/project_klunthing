//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIA_Universitas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Acd_Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Acd_Student()
        {
            this.Acd_App_Sk = new HashSet<Acd_App_Sk>();
            this.Acd_Curriculum_EKUIVALENSI_TRANSKRIP = new HashSet<Acd_Curriculum_EKUIVALENSI_TRANSKRIP>();
            this.Acd_Education_History = new HashSet<Acd_Education_History>();
            this.Acd_Exam_Sched_Detail = new HashSet<Acd_Exam_Sched_Detail>();
            this.Acd_Graduation_Best = new HashSet<Acd_Graduation_Best>();
            this.Acd_Graduation_Reg = new HashSet<Acd_Graduation_Reg>();
            this.Acd_Graduation_Reg_Temp = new HashSet<Acd_Graduation_Reg_Temp>();
            this.Acd_INTERNSHIP = new HashSet<Acd_INTERNSHIP>();
            this.Acd_Sk_Publish = new HashSet<Acd_Sk_Publish>();
            this.Acd_Student_Address = new HashSet<Acd_Student_Address>();
            this.Acd_Student_Card = new HashSet<Acd_Student_Card>();
            this.Acd_Student_Card_Temporary = new HashSet<Acd_Student_Card_Temporary>();
            this.Acd_Student_History = new HashSet<Acd_Student_History>();
            this.Acd_Student_Khs = new HashSet<Acd_Student_Khs>();
            this.Acd_Student_KHS_DELETED = new HashSet<Acd_Student_KHS_DELETED>();
            this.Acd_Student_KHS_PRAK = new HashSet<Acd_Student_KHS_PRAK>();
            this.Acd_Student_Khs_Transfer = new HashSet<Acd_Student_Khs_Transfer>();
            this.Acd_Student_Krs = new HashSet<Acd_Student_Krs>();
            this.Acd_Student_other_rules = new HashSet<Acd_Student_other_rules>();
            this.Acd_Student_Out = new HashSet<Acd_Student_Out>();
            this.Acd_Student_Parent = new HashSet<Acd_Student_Parent>();
            this.Acd_Student_PASSWORD = new HashSet<Acd_Student_PASSWORD>();
            this.Acd_Student_Sched = new HashSet<Acd_Student_Sched>();
            this.Acd_Student_Supervision = new HashSet<Acd_Student_Supervision>();
            this.Acd_Thesis = new HashSet<Acd_Thesis>();
            this.Acd_Transcript = new HashSet<Acd_Transcript>();
            this.Acd_Transcript_Final = new HashSet<Acd_Transcript_Final>();
            this.Fnc_Cost_Krs_Personal = new HashSet<Fnc_Cost_Krs_Personal>();
        }
    
        public long Student_Id { get; set; }
        public string Student_Code { get; set; }
        public string Nim { get; set; }
        public Nullable<long> Register_Id { get; set; }
        public string Register_Number { get; set; }
        public string Full_Name { get; set; }
        public string First_Title { get; set; }
        public string Last_Title { get; set; }
        public Nullable<byte> Gender_Id { get; set; }
        public Nullable<short> Department_Id { get; set; }
        public Nullable<short> Class_Prog_Id { get; set; }
        public Nullable<short> Concentration_Id { get; set; }
        public Nullable<short> Class_Id { get; set; }
        public string Birth_Place { get; set; }
        public Nullable<System.DateTime> Birth_Date { get; set; }
        public Nullable<short> Birth_Place_Id { get; set; }
        public Nullable<short> Birth_Country_Id { get; set; }
        public Nullable<byte> Citizenship_Id { get; set; }
        public Nullable<short> Entry_Period_Id { get; set; }
        public Nullable<short> Entry_Period_Type_Id { get; set; }
        public Nullable<short> Entry_Year_Id { get; set; }
        public Nullable<byte> Entry_Term_Id { get; set; }
        public Nullable<short> Register_Status_Id { get; set; }
        public Nullable<byte> Religion_Id { get; set; }
        public Nullable<byte> Marital_Status_Id { get; set; }
        public Nullable<byte> Job_Id { get; set; }
        public Nullable<byte> Blood_Id { get; set; }
        public Nullable<byte> High_School_Major_Id { get; set; }
        public Nullable<long> Nisn { get; set; }
        public string Nik { get; set; }
        public Nullable<byte> Status_Id { get; set; }
        public Nullable<System.DateTime> Registration_Date { get; set; }
        public Nullable<short> Registration_Officer_Id { get; set; }
        public Nullable<byte> Source_Fund_Id { get; set; }
        public Nullable<byte> Read_Quran { get; set; }
        public Nullable<decimal> Transport { get; set; }
        public string Photo { get; set; }
        public Nullable<byte> Photo_Status { get; set; }
        public string Student_Password { get; set; }
        public string Parent_Password { get; set; }
        public Nullable<short> Hobby_Id { get; set; }
        public Nullable<short> Residence_Type_Id { get; set; }
        public Nullable<short> Transport_Type_Id { get; set; }
        public Nullable<int> Kebutuhan_Khusus { get; set; }
        public string Kk_Name { get; set; }
        public Nullable<decimal> Recieve_Kps { get; set; }
        public string Kps_Number { get; set; }
        public Nullable<System.DateTime> Completion_Date { get; set; }
        public Nullable<System.DateTime> Out_Date { get; set; }
        public string Phone_Home { get; set; }
        public string Phone_Mobile { get; set; }
        public string Email_Corporate { get; set; }
        public string Email_General { get; set; }
        public string Rfid { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_App_Sk> Acd_App_Sk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Curriculum_EKUIVALENSI_TRANSKRIP> Acd_Curriculum_EKUIVALENSI_TRANSKRIP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Education_History> Acd_Education_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Exam_Sched_Detail> Acd_Exam_Sched_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Graduation_Best> Acd_Graduation_Best { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Graduation_Reg> Acd_Graduation_Reg { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Graduation_Reg_Temp> Acd_Graduation_Reg_Temp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_INTERNSHIP> Acd_INTERNSHIP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Sk_Publish> Acd_Sk_Publish { get; set; }
        public virtual Acd_Gpa_TEMP Acd_Gpa_TEMP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Address> Acd_Student_Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Card> Acd_Student_Card { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Card_Temporary> Acd_Student_Card_Temporary { get; set; }
        public virtual Acd_Student_FREE_SKS Acd_Student_FREE_SKS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_History> Acd_Student_History { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Khs> Acd_Student_Khs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_KHS_DELETED> Acd_Student_KHS_DELETED { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_KHS_PRAK> Acd_Student_KHS_PRAK { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Khs_Transfer> Acd_Student_Khs_Transfer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Krs> Acd_Student_Krs { get; set; }
        public virtual Mstr_Blood_Type Mstr_Blood_Type { get; set; }
        public virtual Mstr_Citizenship Mstr_Citizenship { get; set; }
        public virtual Mstr_Class Mstr_Class { get; set; }
        public virtual Mstr_Class_Program Mstr_Class_Program { get; set; }
        public virtual Mstr_Country Mstr_Country { get; set; }
        public virtual Mstr_Department Mstr_Department { get; set; }
        public virtual Mstr_Entry_Period Mstr_Entry_Period { get; set; }
        public virtual Mstr_Entry_Period_Type Mstr_Entry_Period_Type { get; set; }
        public virtual Mstr_Entry_Year Mstr_Entry_Year { get; set; }
        public virtual Mstr_Gender Mstr_Gender { get; set; }
        public virtual Mstr_High_School_Major Mstr_High_School_Major { get; set; }
        public virtual Mstr_Job_Category Mstr_Job_Category { get; set; }
        public virtual Mstr_Marital_Status Mstr_Marital_Status { get; set; }
        public virtual Mstr_Register_Status Mstr_Register_Status { get; set; }
        public virtual Mstr_Religion Mstr_Religion { get; set; }
        public virtual Mstr_Status Mstr_Status { get; set; }
        public virtual Mstr_Term Mstr_Term { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_other_rules> Acd_Student_other_rules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Out> Acd_Student_Out { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Parent> Acd_Student_Parent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_PASSWORD> Acd_Student_PASSWORD { get; set; }
        public virtual Reg_Camaru Reg_Camaru { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Sched> Acd_Student_Sched { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Student_Supervision> Acd_Student_Supervision { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Thesis> Acd_Thesis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Transcript> Acd_Transcript { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acd_Transcript_Final> Acd_Transcript_Final { get; set; }
        public virtual Acd_Yudisium Acd_Yudisium { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fnc_Cost_Krs_Personal> Fnc_Cost_Krs_Personal { get; set; }
    }
}
