using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace prn211_demo.Models
{
    public class Customer
    {
        // Annotation dùng để kiểm tra tính hợp lệ của dữ liệu
        [Key]
        [DisplayName("Customer ID")]
        [Required(ErrorMessage ="ID cannot be blank")]
        public string cus_id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string cus_name { get; set; }
        [Required]
        [DisplayName("Gender")]
        public string cus_gender { get; set; }
        [Required]
        [DisplayName("Birthday")]
        public DateTime cus_birthday { get; set; }
        [Required]
        [DisplayName("Address")]
        public string cus_address { get; set; }
    }
}